using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lection.ViewModels
{
    public class UserView
    {
        [Required(ErrorMessage = "Забыл юзернейм? пиши давай")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Забыл возраст? пиши давай")]
        [Range(18, 100, ErrorMessage = "Старше 18 или младше 100 лет!")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Забыл почту? Пиши, нам тебе спам рассылать надо")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Забыл пароль? Пиши, а то и взламывать будет не надо")]
        public string? Password { get; set; }

        [ValidateNever]
        public string? Errors { get; set; }
    }
}
