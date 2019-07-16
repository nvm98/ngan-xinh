using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp nhân viên 
    /// Người tạo NVMANH 12/6/2019
    /// </summary>
    public class EmployeeDto
    {
        //Mã nhân viên
        public Guid employeeID { get; set; }
        // Mã code nhân viên
        public string employeeId { get; set; }
        //Tên nhân viên
        public string employeeName { get; set; }
        //Loại nhà cung cấp
        public string objectTypeName { get; set; }
        //Địa chỉ nhân viên
        public string employeeAddress { get; set; }
        //Số điên thoại nhân viên
        public string employeePhone { get; set; }
        /// <summary>
        /// Khởi tạo lớp nhân viên mới
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="employee"></param>
        public EmployeeDto(Employee employee)
        {
            employeeID = employee.employeeID;
            employeeId = employee.employeeId;
            employeeName = employee.employeeName;
            employeeAddress = employee.employeeAddress;
            objectTypeName = GetobjectTypeName(employee.SupplierTypeID);
            employeePhone = employee.employeePhone;
        }
        /// <summary>
        /// Lấy loại nhà cung cấp
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetobjectTypeName(Guid id)
        {
          var name =   Data.ListSupplierType.FirstOrDefault(S => S.supplierTypeID == id).supplierTypeName;

          return name;
        }
    }
    /// <summary>
    /// Lớp nhà cung cấp
    /// Người tạo NVMANH 12/6/2019
    /// </summary>
    public class SupplierDto
    {
        //Mã nhà cung cấp
        public Guid supplierID { get; set; }
        //Loại nhà cung cấp
        public string supplierType { get; set; }
        //Mã của loại nhà cung cấp
        public Guid supplierTypeID { get; set; }
        //Mã code của nhà cung cấp
        public string supplierId { get; set; }
        //tên của nhà cung cấp
        public string supplierName { get; set; }
        //Tên của lại nhà cung cấp
        public string objectTypeName { get; set; }
        //Địa chỉ của nhà cung cấp
        public string supplierAddress { get; set; }
        /// <summary>
        /// Khởi tạo lớp nhà cung cấp
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="supplier"></param>
        public SupplierDto(Supplier supplier)
        {
            supplierID = supplier.supplierID;
            supplierType = supplier.supplierType;
            supplierTypeID = supplier.supplierTypeID;
            supplierId = supplier.supplierId;
            supplierName = supplier.supplierName;
            objectTypeName = GetobjectTypeName(supplier.supplierTypeID);
            supplierAddress = supplier.supplierAddress;

        }
        /// <summary>
        /// Lấy loại nhà cung cấp theo mã
        /// Người tạo NVMANH 12/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetobjectTypeName(Guid id)
        {
            var name = Data.ListSupplierType.FirstOrDefault(x => x.supplierTypeID == id).supplierTypeName;
            return name;
        }
    }
    /// <summary>
    /// Lớp về hóa đơn thanh toán
    /// Người tạo NVMANH 12/6/2019
    /// </summary>
    public class FundDto
    {
        //Mã hóa đơn
        public Guid fundID { get; set; }
        //Mã code nhà cung cấp
        public string supplierId { get; set; }
        //Loại chứng từ
        public string fundTypeVoucher { get; set; }
        //Tổng tiền
        public int fundMoney { get; set; }
        //Đối tượng nộp nhận
        public string fundObject { get; set; }
        //Tên nhà cung cấp
        public string supplierName { get; set; }
        //Tên loại nhà cung cấp
        public string supplierTypeName { get; set; }
        //Địa chỉ nhà cung cấp
        public string supplierAddress { get; set; }
        //Lý do
        public string fundReason { get; set; }
        //Mã code nhân viên
        public string employeeId { get; set; }
        //Tên nhân viên
        public string employeeName { get; set; }
        //Số chưng từ
        public string fundNumberVoucher { get; set; }
        //Ngày chứng từ
        public DateTime fundDate { get; set; }
        //Loại phiếu thu/ trả
        public string typeCheck { get; set; }
        public Guid supplierID { get; set; }
        public Guid employeeID { get; set; }
        public FundDto(Fund fund)
        {
            fundID = fund.fundID;
            fundTypeVoucher = fund.fundTypeVoucher;
            fundMoney = fund.fundMoney;
            fundObject = fund.fundObject;
            supplierId = GetSupplierId(fund.supplierID);
            supplierName = GetSupplierName(fund.supplierID);
            supplierTypeName = GetSupplierTypeName(fund.supplierID);
            supplierAddress = GetSupplierAddress(fund.supplierID);
            fundReason = fund.fundReason;
            employeeId = GetEmployeeId(fund.employeeID);
            employeeName = GetEmployeeName(fund.employeeID);
            fundNumberVoucher = fund.fundNumberVoucher;
            fundDate = fund.fundDate;
            typeCheck = fund.typeCheck;
            supplierID = fund.supplierID;
            employeeID = fund.employeeID;
        }
        /// <summary>
        /// Lấy code của nhà cung cấp theo key
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetSupplierId(Guid id)
        {
            var supplierId = Data.ListSuppliers.FirstOrDefault(x => x.supplierID == id).supplierId;
            return supplierId;
        }
        /// <summary>
        /// Lấy tên nhà cung cấp theo khóa
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetSupplierName(Guid id)
        {
            var supplierName = Data.ListSuppliers.FirstOrDefault(x => x.supplierID == id).supplierName;
            return supplierName;
        }
        /// <summary>
        /// Lấy kiểu nhà cung cấp theo khóa
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetSupplierTypeName(Guid id)
        {
            var supplierTypeID = Data.ListSuppliers.FirstOrDefault(x => x.supplierID == id).supplierTypeID;
            var supplierTypeName = Data.ListSupplierType.FirstOrDefault(x => x.supplierTypeID == supplierTypeID).supplierTypeName;
            return supplierTypeName;
        }
        /// <summary>
        /// Lấy địa chỉ của nhà cung cấp theo khóa
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetSupplierAddress(Guid id)
        {
            var supplierAddress = Data.ListSuppliers.FirstOrDefault(x => x.supplierID == id).supplierAddress;
            return supplierAddress;
        }
        /// <summary>
        /// Lấy code của nhân viên theo khóa
        /// Người tạo NVMANH 20/6/2019
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetEmployeeId(Guid id)
        {
            var employeeId = Data.ListEmployees.FirstOrDefault(x => x.employeeID == id).employeeId;
            return employeeId;
        }
        /// <summary>
        /// Lấy tên nhân viên theo khóa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetEmployeeName(Guid id)
        {
            var employeeName = Data.ListEmployees.FirstOrDefault(x => x.employeeID == id).employeeName;
            return employeeName;
        }
    };
}