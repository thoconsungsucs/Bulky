﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
            Product = new ProductRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
