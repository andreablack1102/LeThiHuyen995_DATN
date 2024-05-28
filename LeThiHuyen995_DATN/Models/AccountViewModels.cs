using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeThiHuyen995_DATN.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage ="Vui lòng nhập trường này")]
        [Display(Name = "UserName")]
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public List<string> Roles { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and Confirmation password không giống nhau.")]
        public string ConfirmPassword { get; set; }
    }

    public class EditAccountViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public List<string> Roles { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        
    }

    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        [StringLength(100, ErrorMessage = "{0} cần ít nhất {2} kí tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password and Confirmation password không giống nhau.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
