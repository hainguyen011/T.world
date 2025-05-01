using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.world.Shared.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace T.world.Server.Repositories
{
    class SupplierRepository
    {
        private readonly TworldDBEntities _dbContext;
        public SupplierRepository()
        {
            _dbContext = new TworldDBEntities();
        }


        // Lấy tất cả nhà phân phối
        public List<Supplier> GetAll(string keyword, int page, int pageSize)
        {
            var query = _dbContext.Suppliers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(s => s.name.Contains(keyword));
            }

            return query
                .OrderBy(s => s.name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        // Lấy sản phẩm theo ID
        public Supplier GetById(Guid SupplierId)
        {
            return _dbContext.Suppliers.FirstOrDefault(p => p.id == SupplierId);
        }

        // Tìm kiếm theo tên (chứa từ khoá)
        public List<Supplier> SearchByName(string keyword)
        {
            return _dbContext.Suppliers
                .Where(p => p.name.Contains(keyword))
                .ToList();
        }

        public bool IsPhoneExists(string phone)
        {
            return _dbContext.Suppliers.Any(a => a.phone == phone);
        }

        // Thêm sản phẩm
        public void Create(Supplier Supplier)
        {
            _dbContext.Suppliers.Add(Supplier);
        }

        // Cập nhật sản phẩm
        public void Update(Supplier Supplier)
        {
            var existing = GetById(Supplier.id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(Supplier);
            }
        }

        // Xoá sản phẩm
        public void Delete(Guid SupplierId)
        {
            var Supplier = GetById(SupplierId);
            if (Supplier != null)
            {
                _dbContext.Suppliers.Remove(Supplier);
            }
        }

        public int Count(string keyword)
        {
            var query = _dbContext.Suppliers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(s => s.name.Contains(keyword));
            }

            return query.Count();
        }

        // Lưu thay đổi
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
