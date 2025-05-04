using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.world.server.Services.common;
using T.world.Server.Repositories;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Server.Services
{
    class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        // Tạo danh mục mới
        public ServiceResult CreateCategory(CategoryDTO category)
        {
            Category newCategory = new Category
            {
                id = Guid.NewGuid(),
                name = category.name,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            try
            {
                _categoryRepository.Create(newCategory);
                _categoryRepository.Save();
                return ServiceResult.Ok("Tạo danh mục thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Cập nhật thông tin danh mục
        public ServiceResult UpdateCategory(Guid categoryId, CategoryDTO category)
        {
            try
            {
                var existedCate = _categoryRepository.GetById(categoryId);

                if (existedCate == null)
                    return ServiceResult.Fail("Danh mục không tồn tại.");

                existedCate.name = category.name;
                existedCate.updated_at = DateTime.Now;

                _categoryRepository.Update(existedCate);
                _categoryRepository.Save();

                return ServiceResult.Ok("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Xoá danh mục
        public ServiceResult DeleteCategory(Guid categoryId)
        {
            try
            {
                var category = _categoryRepository.GetById(categoryId);

                if (category == null)
                    return ServiceResult.Fail("Danh mục không tồn tại.");

                _categoryRepository.Delete(categoryId);
                _categoryRepository.Save();

                return ServiceResult.Ok("Xoá danh mục thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Lấy Danh sách danh mục hiện có
        public List<Category> GetListCategory(string keyword, int page, int pageSize)
        {
            return _categoryRepository.GetAll(keyword, page, pageSize);
        }

        // Lấy tổng số trang danh mục
        public int GetTotalPages(string keyword, int pageSize)
        {
            int total = _categoryRepository.Count(keyword);
            return (int)Math.Ceiling((double)total / pageSize);
        }
    }
}
