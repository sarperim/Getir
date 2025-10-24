using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;

namespace Getir.Data
{
    public interface IUnitOfWork
    {
        IGenericRepository<Address> Address { get; }
        IGenericRepository<RefreshToken> RefreshToken { get; }
        IGenericRepository<User> User { get; }
    }
}