﻿using Dapper.Contrib.Extensions;
using MyMovies.Application.Interfaces.IRepository;
using System.Data;

namespace MyMovies.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly IDbConnection _dbConnection;
        private readonly IDbTransaction _transaction;

        public GenericRepository(IDbConnection dbConnection, IDbTransaction transaction)
        {
            _dbConnection = dbConnection;
            _transaction = transaction;
        }
        public async Task<int> AddAsync(T entity)
        {
            return await _dbConnection.InsertAsync(entity,_transaction);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbConnection.GetAsync<T>(id);
            if (entity == null) return false;
            return await _dbConnection.DeleteAsync(entity, _transaction);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbConnection.GetAllAsync<T>();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbConnection.GetAsync<T>(id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _dbConnection.UpdateAsync(entity, _transaction);
        }
    }
}
