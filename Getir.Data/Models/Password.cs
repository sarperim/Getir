using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getir.Data.Models
{
    public class Password
    {
        public Guid Id { get; set; }
        public string PasswordHash {  get; set; }
        public string PasswordSalt {  get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
