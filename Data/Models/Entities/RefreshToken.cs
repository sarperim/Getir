using Getir.Data.Model.Entities;

namespace Getir.Data.Models.Entities
{
    public class RefreshToken
    {
        public Guid Id { get; set; } //PK
        public Guid UserId { get; set; } //FK to User
        public string Token { get; set; }
        public DateTime Expires { get; set; } 
        public bool IsExpired => DateTime.UtcNow >= Expires;

        public User User { get; set; } = null!;
    }
}
