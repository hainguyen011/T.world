using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.world.Shared.Models;

namespace T.world.Server.Repositories
{
    class CategoryRepository
    {
        private readonly TworldDBEntities _dbContext;

        public CategoryRepository()
        {
            _dbContext = new TworldDBEntities();
        }

        // Lấy tất cả danh mục có tìm kiếm và phân trang
        public List<Category> GetAll(string keyword, int page, int pageSize)
        {
            var query = _dbContext.Categories.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(c => c.name.Contains(keyword));
            }

            return query
                .OrderBy(c => c.name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }

        // Lấy danh mục theo ID
        public Category GetById(Guid categoryId)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.id == categoryId);
        }

        // Tìm kiếm theo tên
        public List<Category> SearchByName(string keyword)
        {
            return _dbContext.Categories
                .Where(c => c.name.Contains(keyword))
                .ToList();
        }

        // Thêm danh mục
        public void Create(Category category)
        {
            _dbContext.Categories.Add(category);
        }

        // Cập nhật danh mục
        public void Update(Category category)
        {
            var existing = GetById(category.id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(category);
            }
        }

        // Xoá danh mục
        public void Delete(Guid categoryId)
        {
            var category = GetById(categoryId);
            if (category != null)
            {
                _dbContext.Categories.Remove(category);
            }
        }

        // Đếm tổng số bản ghi (cho phân trang)
        public int Count(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _dbContext.Categories.Count();
            return _dbContext.Categories.Count(c => c.name.Contains(keyword));
        }

        // Lưu thay đổi
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
