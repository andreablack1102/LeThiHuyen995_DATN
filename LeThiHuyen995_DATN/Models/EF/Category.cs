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
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]//id tu tang
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }

        public ICollection<News> News { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}