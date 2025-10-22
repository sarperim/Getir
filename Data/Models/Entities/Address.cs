using System.ComponentModel.DataAnnotations;

namespace Getir.Data.Models.Entities
{
    public class Address
    {
        public Guid Id { get; set; } //pk
        public Guid UserId { get; set; } //fk to user table
        [MaxLength(255)]
        public string Apartment { get; set; }
        [MaxLength(3)]
        public int RoomNumber{ get; set; }
        [MaxLength(255)]
        public string Street { get; set; }
        [MaxLength(255)]
        public string Neighbourhood { get; set; }
        [MaxLength(255)]
        public string City{ get; set; }

    }

}
