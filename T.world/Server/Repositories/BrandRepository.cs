using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.world.Shared.Models;

namespace T.world.Server.Repositories
{
    class BrandRepository
    {
        private readonly TworldDBEntities _dbContext;

        public BrandRepository()
        {
            _dbContext = new TworldDBEntities();
        }

        // Lấy tất cả thương hiệu có tìm kiếm và phân trang
        public List<Brand> GetAll(string keyword, int page, int pageSize)
        {
            var query = _dbContext.Brands.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(b => b.name.Contains(keyword));
            }

            return query
                .OrderBy(b => b.name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }
        // Lấy thương hiệu theo ID
        public Brand GetById(Guid brandId)
        {
            return _dbContext.Brands.FirstOrDefault(b => b.id == brandId);
        }

        // Tìm kiếm theo tên
        public List<Brand> SearchByName(string keyword)
        {
            return _dbContext.Brands
                .Where(b => b.name.Contains(keyword))
                .ToList();
        }

        // Thêm thương hiệu
        public void Create(Brand brand)
        {
            _dbContext.Brands.Add(brand);
        }

        // Cập nhật thương hiệu
        public void Update(Brand brand)
        {
            var existing = GetById(brand.id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(brand);
            }
        }

        // Xoá thương hiệu
        public void Delete(Guid brandId)
        {
            var brand = GetById(brandId);
            if (brand != null)
            {
                _dbContext.Brands.Remove(brand);
            }
        }

        // Đếm tổng số bản ghi (cho phân trang)
        public int Count(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _dbContext.Brands.Count();
            return _dbContext.Brands.Count(b => b.name.Contains(keyword));
        }

        // Lưu thay đổi
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
