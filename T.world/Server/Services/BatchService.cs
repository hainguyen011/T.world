using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using T.world.server.Services.common;
using T.world.Server.Repositories;
using T.world.Shared.DTOs;
using T.world.Shared.Models;

namespace T.world.Server.Services
{

    class BatchService
    {
        private readonly BatchRepository _batchRepository;
        private readonly ProductRepository _productRepository;
        private readonly SupplierRepository _supplierRepository;

        public BatchService()
        {
            _batchRepository = new BatchRepository();
            _productRepository = new ProductRepository();
            _supplierRepository = new SupplierRepository();
        }

        public ServiceResult CreateBatch(BatchDTO batch)
        {

            var product = _productRepository.GetById(batch.productId);
            if (product == null)
            {
                return ServiceResult.Fail("Sản phẩm không tồn tại");
            }

            var supplier = _supplierRepository.GetById(batch.supplierId);
            if (product == null)
            {
                return ServiceResult.Fail("Nhà cung cấp không tồn tại");
            }


            Batch newBatch = new Batch
            {
                id = Guid.NewGuid(),
                batch_code = "",
                product_id = batch.productId,
                supplier_id = batch.supplierId,
                purchase_price = batch.purchasePrice,
                amount = batch.amount,
                notes = batch.notes,
                import_date = batch.importDate,
                created_at = DateTime.UtcNow,
                updated_at = DateTime.UtcNow
            };

            try
            {
                _batchRepository.Create(newBatch);
                _batchRepository.Save();
                return ServiceResult.Ok("Tạo phiếu thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }
    }
}
