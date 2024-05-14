using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeThiHuyen995_DATN.Models.EF
{
    [Table("tb_Adv")]
    public class Adv : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id auto increase
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Link { get; set; }
        public int Type { get; set; }
    }
}