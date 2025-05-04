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
    class BrandService
    {
        private readonly BrandRepository _brandRepository;
        public BrandService()
        {
            _brandRepository = new BrandRepository();
        }

        // Tạo thương hiệu mới
        public ServiceResult CreateBrand(BrandDTO brand)
        {
            Brand newBrand = new Brand
            {
                id = Guid.NewGuid(),
                name = brand.name,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            try
            {
                _brandRepository.Create(newBrand);
                _brandRepository.Save();
                return ServiceResult.Ok("Tạo thương hiệu thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Cập nhật thương hiệu
        public ServiceResult UpdateBrand(Guid brandId, BrandDTO brand)
        {
            try
            {
                var brandExisted = _brandRepository.GetById(brandId);
                if (brand == null)
                    return ServiceResult.Fail("Thương hiệu không tồn tại.");

                brandExisted.name = brand.name;
                brandExisted.description = brand.description;
                brandExisted.updated_at = DateTime.Now;

                _brandRepository.Update(brandExisted);
                _brandRepository.Save();

                return ServiceResult.Ok("Cập nhật thương hiệu thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Xoá thương hiệu
        public ServiceResult DeleteBrand(Guid brandId)
        {
            try
            {
                var brand = _brandRepository.GetById(brandId);
                if (brand == null)
                    return ServiceResult.Fail("Thương hiệu không tồn tại.");

                _brandRepository.Delete(brandId);
                _brandRepository.Save();

                return ServiceResult.Ok("Xoá thương hiệu thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Lấy danh sách thương hiệu
        public List<Brand> GetListBrand(string keyword, int page, int pageSize)
        {
            return _brandRepository.GetAll(keyword, page, pageSize);
        }

        // Lấy tổng số trang
        public int GetTotalPages(string keyword, int pageSize)
        {
            int total = _brandRepository.Count(keyword);
            return (int)Math.Ceiling((double)total / pageSize);
        }
    }
}
