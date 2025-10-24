using Getir.Data.Models;
using Getir.Data.Repository.Interfaces;
using Getir.Data.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Getir.Data
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly GetirDbContext _dbContext;
        private IGenericRepository<User>? Users;
        private IGenericRepository<Address>? Addresses;
        private IGenericRepository<RefreshToken>? RefreshTokens;

        public UnitofWork(GetirDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public IGenericRepository<User> User => Users ??= new GenericRepository<User>(_dbContext);
        public IGenericRepository<Address> Address => Addresses ??= new GenericRepository<Address>(_dbContext);
        public IGenericRepository<RefreshToken> RefreshToken => RefreshTokens ??= new GenericRepository<RefreshToken>(_dbContext);

    }
}
