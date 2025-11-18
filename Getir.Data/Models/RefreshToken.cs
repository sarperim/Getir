using System.ComponentModel.DataAnnotations;

namespace Getir.Data.Models
{
    public class RefreshToken
    {
        public Guid Id { get; set; } //PK
        public Guid UserId { get; set; } //FK to User
        [MaxLength(255)]
        public string Token { get; set; }
        public DateTime Expires { get; set; } 
        public bool IsExpired => DateTime.UtcNow >= Expires;

        public User User { get; set; } = null!;
    }
}
