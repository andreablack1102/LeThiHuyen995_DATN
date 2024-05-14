using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models.EF
{
    [Table("tb_Category")]
    public class Category:CommonAbstract
    {
        public Category() {
            this.News = new HashSet<News>();//1 danh muc co the co nhieu tin tuc
                }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id auto increase
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }      
        public int Position { get; set; }

        [StringLength(150)]
        public string SeoTitle { get; set; }

        [StringLength(250)]
        public string SeoDescription { get; set; }

        [StringLength(150)]
        public string SeoKeywords { get; set; }
        public bool IsActive { get; set; }
        public ICollection<News> News { get; set; }
        
    }
}