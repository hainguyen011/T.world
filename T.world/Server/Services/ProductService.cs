﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using T.world.server.Services.common;
using T.world.Server.Repositories;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Server.Services
{
    class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly BrandRepository _brandRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            _brandRepository = new BrandRepository();   
        }

        // Tạo sản phẩm mới
        public ServiceResult CreateProduct(ProductDTO product)
        {
            var category = _categoryRepository.GetById(product.categoryId);
            if (category == null)
            {
                return ServiceResult.Fail("Danh mục không tồn tại");
            }

            var brand = _brandRepository.GetById(product.brandId);
            if (brand == null)
            {
                return ServiceResult.Fail("Thương hiệu không tồn tại");
            }

            var newProduct = new Product
            {
                id = Guid.NewGuid(),  
                name = product.name,
                category_id = product.categoryId,
                brand_id = product.brandId,
                description = product.description,
                price_sell = product.priceSell,
                quantity = product.quantity,
                image = product.image,  
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            try
            {
                _productRepository.Create(newProduct);
                _productRepository.Save();
                return ServiceResult.Ok("Tạo sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Cập nhật thông tin sản phẩm 
        public ServiceResult UpdateProduct(Guid productId, ProductDTO product)
        {
            try
            {
                var existing = _productRepository.GetById(productId);
                if (existing == null)
                    return ServiceResult.Fail("Sản phẩm không tồn tại.");


                // Cập nhật thông tin
                existing.name = product.name;
                existing.description = product.description;
                existing.price_sell = product.priceSell;
                existing.quantity = product.quantity;
                existing.image = product.image;
                existing.category_id = product.categoryId;
                existing.brand_id = product.brandId;
                existing.updated_at = DateTime.Now;
         
                _productRepository.Update(existing);
                _productRepository.Save();

                return ServiceResult.Ok("Cập nhật sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Xóa sản phẩm
        public ServiceResult DeleteProduct(Guid id)
        {
            try
            {
                var existing = _productRepository.GetById(id);
                if (existing == null)
                    return ServiceResult.Fail("Sản phẩm không tồn tại.");

                _productRepository.Delete(id);
                _productRepository.Save();

                return ServiceResult.Ok("Xóa sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Lấy danh sách sản phẩm
        public List<Product> GetListProduct(string keyword, int page, int pageSize)
        {
            return _productRepository.GetAll(keyword, page, pageSize);
        }

        // Lấy thông tin sản phẩm theo id sản phẩm
        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        // Lấy tổng số trang sản phẩm hiện có
        public int GetTotalPages(string keyword, int pageSize)
        {
            int total = _productRepository.SearchByName(keyword).Count;
            return (int)Math.Ceiling((double)total / pageSize);
        }

        public int GetTotalProductInStock()
        {
            int total = _productRepository.GetTotalAmount();
            return total;
        }
    }
}
