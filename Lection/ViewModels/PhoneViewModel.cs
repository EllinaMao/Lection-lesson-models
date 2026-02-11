using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Lection.ViewModels
{
    public class PhoneViewModel
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int CompanyId { get; set; }
        [ValidateNever]
        public string? Errors { get; set; }

    }
}
