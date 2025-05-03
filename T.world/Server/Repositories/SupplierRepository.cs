using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            int startRow = (page - 1) * pageSize + 1;
            int endRow = startRow + pageSize - 1;

            string sql = @"
        WITH OrderedSuppliers AS (
            SELECT *, ROW_NUMBER() OVER (ORDER BY name) AS RowNum
            FROM dbo.Supplier
            WHERE (@keyword IS NULL OR name LIKE '%' + @keyword + '%')
        )
        SELECT *
        FROM OrderedSuppliers
        WHERE RowNum BETWEEN @startRow AND @endRow
        ORDER BY RowNum;";

            var suppliers = _dbContext.Database.SqlQuery<Supplier>(
                sql,
                new SqlParameter("@keyword", string.IsNullOrWhiteSpace(keyword) ? (object)DBNull.Value : keyword),
                new SqlParameter("@startRow", startRow),
                new SqlParameter("@endRow", endRow)
            ).ToList();

            return suppliers;
        }

            return query
                .OrderBy(s => s.name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }

        // Lấy Nhà phân phối theo ID
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

        // Thêm Nhà phân phối
        public void Create(Supplier Supplier)
        {
            _dbContext.Suppliers.Add(Supplier);
        }

        // Cập nhật Nhà phân phối
        public void Update(Supplier supplier)
        {
            var existing = GetById(supplier.id);

            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(supplier);
                _dbContext.Entry(existing).State = EntityState.Modified;
            }
        }

        // Xoá Nhà phân phối
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
