Create proc sp_ThongKe
AS
BEGIN
	DECLARE @SoTruyCapGanNhat int
	DECLARE @Count int
	SELECT @Count=COUNT(*) FROM ThongKes
	IF @Count IS NULL SET @Count=0
	IF @Count=0
		INSERT INTO ThongKes(ThoiGian, SoTruyCap)
		VALUES(GETDATE(),1)
	ELSE
		BEGIN
			DECLARE @ThoiGianGanNhat datetime
			SELECT @SoTruyCapGanNhat = tk.SoTruyCap, @ThoiGianGanNhat=tk.ThoiGian FROM ThongKes tk
			WHERE tk.Id = (SELECT MAX(tk1.Id) FROM ThongKes tk1)
			IF @SoTruyCapGanNhat IS NULL SET @SoTruyCapGanNhat=0
			IF @ThoiGianGanNhat IS NULL SET @ThoiGianGanNhat=GETDATE()
			--neu chuyen sang ngay moi
			IF DAY(@ThoiGianGanNhat) = DAY(GETDATE())
				BEGIN
					UPDATE ThongKes
					SET 
						SoTruyCap=@SoTruyCapGanNhat+1,
						ThoiGian = GETDATE()
					WHERE Id = (SELECT MAX(tk1.Id)  FROM ThongKes tk1)
				END
				---neu da sang ngay moi thi them 1 ban ghi moi
			ELSE
				INSERT INTO ThongKes(ThoiGian, SoTruyCap)
				VALUES(GETDATE(),1)
		END

		---thong ke hom nay, hom qua, tuan nay, tuan truoc, thang nay, thang truoc
		DECLARE @HomNay int
		SET @HomNay = DATEPART(DW, GETDATE());
		SELECT @SoTruyCapGanNhat=SoTruyCap, @ThoiGianGanNhat=ThoiGian  FROM ThongKes 
		WHERE Id = (SELECT MAX(Id) FROM ThongKes)

		--so truy cap ngay hom qua
		DECLARE @TruyCapHomQua bigint
		SELECT @TruyCapHomQua=ISNULL(SoTruyCap, 0), @ThoiGianGanNhat=ThoiGian FROM ThongKes 
		WHERE CONVERT(nvarchar(20), ThoiGian, 103)=CONVERT(nvarchar(20), GETDATE()-1, 103)
		IF @TruyCapHomQua IS NULL SET @TruyCapHomQua = 0;

		--truy cap dau tuan nay
		DECLARE @DauTuanNay datetime
		SET @DauTuanNay=DATEADD(wk, DATEDIFF(wk, 6, GETDATE()), 6)
		--tinh ngay dau của tuan truoc. tinh tu thoi diem 0:00
		DECLARE @NgayDauTuanTruoc datetime
		SET @NgayDauTuanTruoc = CAST(CONVERT(nvarchar(30), DATEADD(dd, -(@HomNay+6), GETDATE()), 101) AS datetime)
		--tinh ngay cuoi tuan truoc tinh den 24h ngay cuoi tuan
		DECLARE @NgayCuoiTuanTruoc datetime
		SET @NgayCuoiTuanTruoc = CAST(CONVERT(nvarchar(30), DATEADD(dd, -@HomNay, GETDATE()), 101) +' 23:59:59' AS datetime)
		
		--so truy cap tuan nay
		DECLARE @TruyCapTuanNay bigint
		SELECT @TruyCapTuanNay = ISNULL(SUM(SoTruyCap),0) FROM ThongKes
		WHERE ThoiGian BETWEEN @DauTuanNay AND GETDATE()

		--so truy cap tuan truoc
		DECLARE @SoTruyCapTuanTruoc bigint
		SELECT @SoTruyCapTuanTruoc = ISNULL(SUM(SoTruyCap),0) FROM ThongKes ttk
		WHERE ttk.ThoiGian BETWEEN @NgayDauTuanTruoc AND @NgayCuoiTuanTruoc

		--so truy cap thang nay
		DECLARE @SoTruyCapThangNay bigint
		SELECT @SoTruyCapThangNay = ISNULL(SUM(SoTruyCap),0) FROM ThongKes ttk
		WHERE MONTH(ttk.ThoiGian)=MONTH(GETDATE())

		--so truy cap thang truoc
		DECLARE @SoTruyCapThangTruoc bigint
		SELECT @SoTruyCapThangTruoc = ISNULL(SUM(SoTruyCap),0) FROM ThongKes ttk
		WHERE MONTH(ttk.ThoiGian)=MONTH(GETDATE())-1

		--tinh tong so
		DECLARE @TongSo bigint
		SELECT @TongSo = ISNULL(SUM(SoTruyCap),0) FROM ThongKes ttk

		SELECT @SoTruyCapGanNhat AS HomNay,
		@TruyCapHomQua AS HomQua,
		@TruyCapTuanNay AS TuanNay,
		@SoTruyCapTuanTruoc AS TuanTruoc,
		@SoTruyCapThangNay AS ThangNay,
		@SoTruyCapThangTruoc AS ThangTruoc,
		@TongSo AS TatCa
END
--drop proc sp_ThongKe