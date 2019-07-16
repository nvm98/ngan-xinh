using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp khai báo nhân viên
    /// Người tạo NVMANH 20/6/2019
    /// </summary>
    public class Employee
    {
        //Mã nhân viên
        public Guid employeeID { get; set; }
        //Mã code của nhân viên
        public string employeeId { get; set; }
        //Tên cả nhân viên
        public string employeeName { get; set; }
        //Mã loại khách hàng
        public Guid SupplierTypeID { get; set; }
        //Địa chỉ nhân viên
        public string employeeAddress { get; set; }
        //Số điện thoại của nhân viên
        public string employeePhone { get; set; }
    }
}