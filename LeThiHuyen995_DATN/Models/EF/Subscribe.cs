using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models.EF
{
    [Table("tb_Subscribe")]
    public class Subscribe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id tu tang
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}