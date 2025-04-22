using System;
using System.Collections.Generic;
using System.Linq;
using T.world.Shared.Models;

namespace T.world.Server.Repositories
{
    public class ProductRepository
    {
        private readonly TworldDBEntities _dbContext;

        public ProductRepository()
        {
            _dbContext = new TworldDBEntities();
        }

        // Lấy tất cả sản phẩm
        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        // Lấy sản phẩm theo ID
        public Product GetById(Guid productId)
        {
            return _dbContext.Products.FirstOrDefault(p => p.id == productId);
        }

        // Tìm kiếm theo tên (chứa từ khoá)
        public List<Product> SearchByName(string keyword)
        {
            return _dbContext.Products
                .Where(p => p.name.Contains(keyword))
                .ToList();
        }

        // Thêm sản phẩm
        public void Create(Product product)
        {
            _dbContext.Products.Add(product);
        }

        // Cập nhật sản phẩm
        public void Update(Product product)
        {
            var existing = GetById(product.id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(product);
            }
        }

        // Xoá sản phẩm
        public void Delete(Guid productId)
        {
            var product = GetById(productId);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
            }
        }

        // Lưu thay đổi
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
