using System.ComponentModel.DataAnnotations;

namespace YetgenAkbankWeek11.WebApi.ViewModels
{
   
    public class AuthLoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}