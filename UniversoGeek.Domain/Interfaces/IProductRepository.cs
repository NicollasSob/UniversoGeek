﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversoGeek.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(Guid id);
        Task<Product> GetByIdAsync(Guid id);
        IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate);
        Task<IEnumerable<Product>> SearchAsync(Expression<Func<Product, bool>> predicate);
        IEnumerable<Product> Search(Expression<Func<Product, bool>> predicate,
            int pageNumber,
            int pageSize);
        Product Add(Product entity);
        Task<Product> AddAsync(Product entity);
        Product Update(Product entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Product, bool>> expression);
    }
}
