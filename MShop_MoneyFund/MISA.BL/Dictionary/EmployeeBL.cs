using MISA.BL.Base;
using MISA.DL.Dictonary;
using MISA.Entites.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.BL.Dictionary
{
    /// <summary>
    /// Lớp xử lý nghiệp vụ với bảng Employee
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class EmployeeBL : BaseBL
    {
        private EmployeeDL employeeDL;
        public EmployeeBL()
        {
            employeeDL = new EmployeeDL();
        }
        /// <summary>
        /// Hàm lấy tất cả danh sách nhân viên
        /// </summary>
        /// <returns>Danh sách tất cả nhân viên</returns>
        /// Created by NVMANH 24/7/2019
        public List<Employee> GetAllEmployee()
        {
            return employeeDL.GetEmployeeData();
        }
        /// <summary>
        /// Hàm lấy nhân viên theo ID
        /// </summary>
        /// <param name="value">Id nhân viên</param>
        /// <returns>Nhân viên có id tương ứng</returns>
        /// Created by NVMANH 24/7/2019
        public Employee GetEmployeeByIDBL(Guid value)
        {
            var id = Commons.Commons.ConvertGuidToNvarchar(value);
            return employeeDL.GetEmployeeByID(id);
        }
    }
}
