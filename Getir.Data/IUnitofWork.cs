using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;

namespace Getir.Data
{
    public interface IUnitOfWork
    {
        IUserRepository Users {  get; }
        IAddressRepository Addresses { get; }
        IGenericRepository<RefreshToken> RefreshToken { get; }
    }
}