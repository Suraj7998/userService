using System.ComponentModel.DataAnnotations;

namespace UserServices.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Username or Email")]
        public string UserName { get; set; }
    }
}
