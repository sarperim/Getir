using System.ComponentModel.DataAnnotations;

namespace Getir.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = null!;
        [MaxLength(255)]
        public string LastName { get; set; } = null!;
        [MaxLength(255)]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // might change time setting functionality to db level
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public UserState State{ get; set; } 

        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();  
        public ICollection<Address> Addresses{ get; set; } = new List<Address>();  
        public ICollection<Password> Passwords{ get; set; } = new List<Password>();  
        
    }
    public enum UserState
    {
        Registered,
        Confirmed,
        Suspended,
        Deleted 

    }
}
