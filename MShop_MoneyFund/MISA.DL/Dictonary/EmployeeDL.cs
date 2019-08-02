using MISA.DL.Base;
using MISA.Entites.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.DL.Dictonary
{
    /// <summary>
    /// Lớp xử lý dữ liệu với bảng Employee
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class EmployeeDL : BaseDL<Employee>
    {
        /// <summary>
        /// Hàm lấy tất cả dữ liệu nhân viên
        /// </summary>
        /// <returns>danh sách nhân viên</returns>
        /// Created by NVMANH 24/7/2019
        public List<Employee> GetEmployeeData()
        {
            return GetAll("Proc_GetAllData", "Employee");
        }
        /// <summary>
        /// Hàm lấy dữ liệu của nhân viên theo ID
        /// </summary>
        /// <param name="value">id nhân viên</param>
        /// <returns>Nhân viên với id tương ứng</returns>
        /// Created by NVMANH 24/7/2019
        public Employee GetEmployeeByID(string value)
        {
            return GetDataByAttribute("Proc_GetDataByAttribute", "Employee", "EmployeeID", value);
        }
    }
}
