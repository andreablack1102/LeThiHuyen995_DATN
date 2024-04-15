using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models.EF
{
    [Table("tb_ProductImage")]//chua anh cua san pham, 1 san pham co the co nhieu anh
    public class ProductImage
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id auto increase
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string Image { get; set; }
        public bool IsDefault { get; set; }
    }
}