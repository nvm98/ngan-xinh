using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp để lấy dữ liệu cho lớp nhân viên
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class EmployeeViewModels
    {
        #region Properties
        //Mã nhân viên
        public Guid EmployeeID { get; set; }
        // Mã code nhân viên
        public string EmployeeCode { get; set; }
        //Tên nhân viên
        public string EmployeeName { get; set; }
        //Địa chỉ nhân viên
        public string EmployeeAddress { get; set; }
        //Số điên thoại nhân viên
        public string EmployeePhone { get; set; }
        #endregion
        #region Constructor
        public EmployeeViewModels()
        {
            EmployeeID = Guid.NewGuid();
        }
        #endregion
    }
}
