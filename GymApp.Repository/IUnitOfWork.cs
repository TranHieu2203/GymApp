using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Repository
{
    public interface IUnitOfWork : IDisposable
   {

        /// <summary>
        /// Lưu các thay đổi đang chờ xử lý
        /// </summary>
        /// <returns>Số lượng đối tượng ở trạng thái Đã thêm, Sửa đổi hoặc Đã xóa</returns>
        int Commit();
   }

}
