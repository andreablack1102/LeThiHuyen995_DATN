$(document).ready(function () {
    ShowCount();
    $('body').on('click', '.btnAddToCart', function (e) {
        e.preventDefault();//off href
        var id = $(this).data('id');
        var quantity = 1;
        var tQuantity = $("#quantity_value").text();
        if (tQuantity != '') {
            quantity = parseInt(tQuantity);
        }
        //alert(id + ' ' + quantity);
        $.ajax({
            url: '/shoppingcart/addtocart',
            type: 'POST',
            data: { id: id, quantity: quantity },
            success: function (rs) {
                if (rs.success) {
                    $('#checkout_items').html(rs.count);
                    alert(rs.msg);
                }
            }
        });
    });

    $('body').on('click', '.btnDelete', function (e) {
        e.preventDefault();//off href
        var id = $(this).data('id');
        var conf = confirm('Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?');
        if (conf === true) {
            $.ajax({
                url: '/shoppingcart/delete',
                type: 'POST',
                data: { id: id },
                success: function (rs) {
                    if (rs.success) {
                        $('#checkout_items').html(rs.count);
                        $('trow_' + id).remove();
                        /*location.reload();*/
                        LoadCart();
                    }
                }
            });
        }
    });
    //$('body').on('click', '.btnUpdate', function (e) {
    //    e.preventDefault();//off href
    //    var id = $(this).data("id");
    //    var quantity = $('#Quantity_' + id).val();
    //    alert(quantity);
    //    //Update(id, quantity);
    //    //$.ajax({
    //    //    url: '/shoppingcart/Update',
    //    //    type: 'POST',
    //    //    data: { id: id, quantity: quantity },
    //    //    success: function (rs) {
    //    //        if (rs.success) {
    //    //            alert(rs.msg);
    //    //            LoadCart();
    //    //        }
    //    //        //else {
    //    //        //    alert("Số lượng vượt quá trong kho, vui lòng nhập lại");
    //    //        //    LoadCart();
    //    //        //}
    //    //    }
    //    //});

    //});
    $('body').on('click', '.btnUpdate', function (e) {
        e.preventDefault();//off href
        var id = $(this).data('id');
        var quantity = $('#Quantity_' + id).val();       
        $.ajax({
            url: '/shoppingcart/Update',
            type: 'POST',
            data: { id: id, quantity: quantity },
            success: function (rs) {
                if (rs.success) {
                    alert(rs.msg);
                    //LoadCart();
                }
                else {
                    alert(rs.msg);
                    LoadCart();
                }
            }
        });
    });


    $('body').on('click', '.btnDeleteAll', function (e) {
        e.preventDefault();//off href
        var conf = confirm('Bạn có chắc muốn xóa hết sản phẩm trong giỏ hàng?');
        if (conf === true) {
            DeleteAll();
            /*location.reload();*/
        }
    });
});

function ShowCount() {
    $.ajax({
        url: '/shoppingcart/showcount',
        type: 'GET',
        success: function (rs) {
            $('#checkout_items').html(rs.count);
        }
    });
}

function Update(id, quantity) {
    $.ajax({
        url: '/shoppingcart/Update',
        type: 'POST',
        data: { id: id, quantity: quantity },
        success: function (rs) {
            if (rs.success) {
                alert(rs.msg);
                LoadCart();
            }
            else {
                alert(rs.msg);
                LoadCart();
            }
        }
    });
}

function DeleteAll() {
    $.ajax({
        url: '/shoppingcart/DeleteAll',
        type: 'POST',
        success: function (rs) {
            if (rs.success) {
                LoadCart();
            }
        }
    });
}

function LoadCart() {
    $.ajax({
        url: '/shoppingcart/Partial_Item_Cart',
        type: 'GET',
        success: function (rs) {
            $('#load_data').html(rs);
        }
    });
}