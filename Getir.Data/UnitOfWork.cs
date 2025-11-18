using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;
using Getir.Data.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Getir.Data
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly GetirDbContext _dbContext;
        public IUserRepository Users { get; }
        public IAddressRepository? Addresses { get; }
        public IGenericRepository<RefreshToken>? RefreshTokens;

        public UnitofWork(GetirDbContext dbcontext, IAddressRepository address, IUserRepository user)
        {
            _dbContext = dbcontext;
            Addresses = address;
            Users = user;
        }

        public IGenericRepository<RefreshToken> RefreshToken => RefreshTokens ??= new GenericRepository<RefreshToken>(_dbContext);

        public Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
