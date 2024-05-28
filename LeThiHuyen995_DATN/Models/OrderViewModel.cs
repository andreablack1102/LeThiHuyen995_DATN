using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên khách hàng không để trống")]
        [Display(Name = "CustomerName")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không để trống")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không để trống")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public string CustomerId { get; set; }
        public int TypePayment { get; set; }
        public int TypePaymentVN { get; set; }

    }
}