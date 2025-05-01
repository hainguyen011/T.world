using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.world.Shared.Models;

namespace T.world.Server.Repositories
{
    class BatchRepository
    {
        private readonly TworldDBEntities _dbContext;
        public BatchRepository()
        {
            _dbContext = new TworldDBEntities();
        }

        // Lấy tất cả batch có tìm kiếm và phân trang
        public List<Batch> GetAll(int page, int pageSize)
        {
            var query = _dbContext.Batches.AsQueryable();

            return query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        // Lấy batch theo ID
        public Batch GetById(Guid batchId)
        {
            return _dbContext.Batches.FirstOrDefault(b => b.id == batchId);
        }

        // Thêm batch
        public void Create(Batch batch)
        {
            _dbContext.Batches.Add(batch);
        }

        // Cập nhật batch
        public void Update(Batch batch)
        {
            var existing = GetById(batch.id);
            if (existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(batch);
            }
        }

        // Xoá batch
        public void Delete(Guid batchId)
        {
            var batch = GetById(batchId);
            if (batch != null)
            {
                _dbContext.Batches.Remove(batch);
            }
        }

        // Lưu thay đổi
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        // Đếm tổng số bản ghi (cho phân trang)
        public int Count()
        {
            return _dbContext.Batches.Count();
        }
    }
}
