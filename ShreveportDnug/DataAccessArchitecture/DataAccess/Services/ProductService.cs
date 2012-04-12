using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;

namespace Infrastructure.Services
{
    public class ProductService : IProductService

    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> Find<T>(Func<T, bool> where) where T : class
        {
            return _repository.Find<T>().Query.Cast<Product>().Include(x => x.Category);
        }
}