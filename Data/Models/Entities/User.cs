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
        public string Password { get; set; } = null!; 
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow; // might change time setting functionality to db level
        [MaxLength(255)]
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public Icolel
        
    }
}
