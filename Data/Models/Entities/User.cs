using System.ComponentModel.DataAnnotations;

namespace Getir.Data.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = null!;
        [MaxLength(255)]
        public string LastName { get; set; } = null!;
        [MaxLength(255)]
        public string PasswordHash { get; set; } = null!; 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // might change time setting functionality to db level
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public UserState State{ get; set; } 

        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();  
        
    }
    public enum UserState
    {
        Registered,
        Confirmed,
        Suspended,
        Deleted 

    }
}
