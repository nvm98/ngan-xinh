using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Commons
{
    /// <summary>
    /// Lớp chứa các phương thức thường dùng
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class Commons
    {
        /// <summary>
        /// Hàm chuyển kiểu từ Guid sang Nvarchar
        /// </summary>
        /// <param name="id">Chuỗi cần chuyển</param>
        /// <returns>Chuổi kiểu nvarchar</returns>
        /// Created by NVMANH 24/7/2019
        public static string ConvertGuidToNvarchar(object id)
        {
            return "'" + id + "'";
        }
    }
  
}
