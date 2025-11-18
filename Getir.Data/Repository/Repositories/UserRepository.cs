using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;

namespace Getir.Data.Repository.Repositories
{
    public class UserRepository(GetirDbContext db) : GenericRepository<User>(db), IUserRepository
    {
    }
}
