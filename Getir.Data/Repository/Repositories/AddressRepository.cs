using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;

namespace Getir.Data.Repository.Repositories
{
    public class AddressRepository(GetirDbContext db) : GenericRepository<Address>(db), IAddressRepository
    {
    }
}
