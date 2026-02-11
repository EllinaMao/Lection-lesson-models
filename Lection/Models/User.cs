using System.ComponentModel.DataAnnotations;

namespace Lection.Models
{
    public record User
    {
        public Guid? Id { get; set; }
        public string? Username { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }


}
