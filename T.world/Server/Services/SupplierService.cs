using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using T.world.server.Services.common;
using T.world.Server.Repositories;
using T.world.Shared.DTOs;
using T.world.Shared.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace T.world.Server.Services
{
    class SupplierService
    {
        private readonly SupplierRepository _supplierRepository;
        public SupplierService()
        {
            _supplierRepository = new SupplierRepository();
        }

        // Tạo nhà phân phối
        public ServiceResult CreateSupplier(SupplierDTO supplier)
        {
            if (_supplierRepository.IsPhoneExists(supplier.phone))
                return ServiceResult.Fail("Số điện thoại này đã được sử dụng.");

            Supplier newSupplier = new Supplier
            {
                id = Guid.NewGuid(),
                name = supplier.name,
                phone = supplier.phone,
                location = supplier.location,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            try
            {
                _supplierRepository.Create(newSupplier);
                _supplierRepository.Save();
                return ServiceResult.Ok("Tạo thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Lấy danh sách nhà phân phối hiện có
        public List<Supplier> GetListSupplier(string keyword, int page, int pageSize)
        {
            return _supplierRepository.GetAll(keyword, page, pageSize);
        }

        // Xóa nhà phân phối
        public ServiceResult DeleteSupplier(Guid supplierId)
        {
            try
            {
                var supplier = _supplierRepository.GetById(supplierId);

                if (supplier == null)
                    return ServiceResult.Fail("Nhà phân phối không tồn tại.");

                _supplierRepository.Delete(supplierId);
                _supplierRepository.Save();

                return ServiceResult.Ok("Xóa nhà phân phối thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Cập nhật thông tin nhà phân phối
        public ServiceResult UpdateSupplier(Guid supplierId, SupplierDTO supplier)
        {
            try
            {
                var existedSupplier = _supplierRepository.GetById(supplierId);

                if (supplier == null)
                    return ServiceResult.Fail("Nhà phân phối không tồn tại.");

                // Kiểm tra nếu số điện thoại đã tồn tại
                if (_supplierRepository.IsPhoneExists(supplier.phone) && supplier.phone != supplier.phone)
                    return ServiceResult.Fail("Số điện thoại này đã được sử dụng.");

                // Cập nhật thông tin
                existedSupplier.name = supplier.name;
                existedSupplier.phone = supplier.phone;
                existedSupplier.location = supplier.location;
                existedSupplier.updated_at = DateTime.Now;

                // Lưu thay đổi
                _supplierRepository.Update(existedSupplier);
                _supplierRepository.Save();

                return ServiceResult.Ok("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        // Lấy tổng số trang
        public int GetTotalPages(string keyword, int pageSize)
        {
            int total = _supplierRepository.Count(keyword);
            return (int)Math.Ceiling((double)total / pageSize);
        }
    }
}
