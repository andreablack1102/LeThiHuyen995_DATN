using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models.EF
{
    [Table("ThongKes")]
    public class ThongKe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id auto increase
        public int Id { get; set; }
        public DateTime ThoiGian { get; set; }

        public long SoTruyCap { get; set; }
    }
}