using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Repository
{
    
    public sealed class UnitOfWork : IUnitOfWork
    {

        private DbContext _dbContext;

        
        public UnitOfWork(DbContext context)
        {

            _dbContext = context;
        }



        /// <summary>
        /// Lưu tất cả các thay đổi đang chờ xử lý
        /// </summary>
        /// <returns>Số lượng đối tượng ở trạng thái Đã thêm, Sửa đổi hoặc Đã xóa</returns>
        public int Commit()
        {
            // Lưu các thay đổi với các tùy chọn mặc định
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }

}
