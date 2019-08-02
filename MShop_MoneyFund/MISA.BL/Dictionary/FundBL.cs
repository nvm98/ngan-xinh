using MISA.BL.Base;
using MISA.DL.Dictonary;
using MISA.Entites.Dictionary;
using MISA.Entites.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.BL.Dictionary
{
    /// <summary>
    /// Hàm sử lý nghiệp vụ với bảng Fund
    /// </summary>
    /// Created by NVMANH 23/7/2019
    public class FundBL : BaseBL
    {
        private FundDL fundDL;

        public FundBL()
        {
            fundDL = new FundDL();
        }
        /// <summary>
        /// Hàm lấy tất cả danh sách chứng từ
        /// </summary>
        /// <returns>Danh sách tất cả các phiếu</returns>
        /// Created by NVMANH 23/7/2019
        public List<Fund> GetAllFund()
        {
            return fundDL.GetFundData();
        }
        /// <summary>
        /// Hàm lấy một phiếu theo ID
        /// </summary>
        /// <param name="value">ID của phiếu</param>
        /// <returns>Phiếu thu</returns>
        /// Created by NVMANH 24/7/2019
        public Fund GetFundByIDBL(Guid value)
        {
            var id = Commons.Commons.ConvertGuidToNvarchar(value);
            return fundDL.GetFundByID(id);
        }
        /// <summary>
        /// Hàm láy một phiếu theo mã phiếu
        /// </summary>
        /// <param name="code">Mã code của phiếu thu</param>
        /// <returns>Phiếu có mã code cần tìm</returns>
        /// Created by NVMANH 24/7/2019
        public Fund GetFundByFundCodeBL(string code)
        {
            var fundCode = Commons.Commons.ConvertGuidToNvarchar(code);
            return fundDL.GetFundByFundCode(fundCode);
        }
        /// <summary>
        /// Hàm lấy dữ liệu FundViewModels theo ID
        /// </summary>
        /// <param name="fundID">ID của phiếu</param>
        /// <returns>Nội dung của phiếu</returns>
        /// Created by NVMANH 24/7/2019
        public FundViewModels GetFundViewModel(Guid fundID)
        {
            var id = Commons.Commons.ConvertGuidToNvarchar(fundID);
            var fund = fundDL.GetFundByID(id);
            return MapFundToFundViewModel(fund);
        }

        /// <summary>
        /// Hàm chuyển từ bản ghi Fund sang FundViewModel
        /// </summary>
        /// <param name="fund">phiếu thu</param>
        /// <returns></returns>
        /// Created by NVMANH 24/7/2019
        public FundViewModels MapFundToFundViewModel(Fund fund)
        {
            var fundViewModel = new FundViewModels();
            var employeeBL = new EmployeeBL();
            var supplierBL = new SupplierBL();
            var supplierID = fund.SupplierID;
            var employeeID = fund.EmployeeID;
            fundViewModel.FundID = fund.FundID;
            fundViewModel.SupplierCode = supplierBL.GetSupplierByIDBL(supplierID).SupplierCode;
            fundViewModel.FundTypeVoucher = fund.FundTypeVoucher;
            fundViewModel.FundMoney = fund.FundMoney;
            fundViewModel.FundObject = fund.FundObject;
            fundViewModel.SupplierName = supplierBL.GetSupplierByIDBL(supplierID).SupplierName;
            fundViewModel.SupplierAddress = supplierBL.GetSupplierByIDBL(supplierID).SupplierAddress;
            fundViewModel.FundReason = fund.FundReason;
            fundViewModel.EmployeeCode = employeeBL.GetEmployeeByIDBL(employeeID).EmployeeCode;
            fundViewModel.EmployeeName = employeeBL.GetEmployeeByIDBL(employeeID).EmployeeName;
            fundViewModel.FundNumberVoucher = fund.FundNumberVoucher;
            fundViewModel.FundDate = fund.FundDate;
            fundViewModel.CheckType = fund.CheckType;
            fundViewModel.CheckDifferent = fund.CheckDifferent;
            fundViewModel.SupplierID = fund.SupplierID;
            fundViewModel.EmployeeID = fund.EmployeeID;
            return fundViewModel;
        }

        /// <summary>
        /// Hàm xử lý nghiệp vụ thêm mới với bảng FUND
        /// </summary>
        /// <param name="fund">Phiếu thu</param>
        /// <returns>Số phiếu bị ảnh hưởng</returns>
        /// Created by NVMANH 25/7/2019
        public int CreateFundBL(Fund fund)
        {
            return fundDL.CreateFund(fund);
        }

        /// <summary>
        /// Hàm xử lý xóa dữ liệu bản ghi
        /// </summary>
        /// <param name="id">ID phiếu</param>
        /// <returns>Số bản ghi bị xóa</returns>
        /// Created by NVMANH 26/7/2019
        public int DeleteFundBL(Guid id)
        {
            var value = Commons.Commons.ConvertGuidToNvarchar(id);
            return fundDL.DeleteFund(value);
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ sửa hóa đơn
        /// </summary>
        /// <param name="fund">Phiếu cần xóa</param>
        /// <returns>Số bản ghi sửa</returns>
        /// Created by 26/7/2019
        public int EditFundBL(Fund fund)
        {
            return fundDL.EditFund(fund);
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ lấy mã phiếu thu tự tăng
        /// </summary>
        /// <returns>Mã phiếu thu hợp lệ</returns>
        /// Created by 26/7/2019
        public string GetCollectCodeAutoBL()
        {
            return fundDL.GetCollectCodeAuto();
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ lấy phiếu chi tự tăng
        /// </summary>
        /// <returns>Mã phiếu chi hợp lệ</returns>
        /// Created by NVMANH 26/7/2019
        public string GetPayCodeAutoBL()
        {
            return fundDL.GetPayCodeAuto();
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ lọc dữ liệu
        /// </summary>
        /// <param name="where">Điều kiện lọc</param>
        /// <param name="pageNumber">Số trang</param>
        /// <param name="pageSize">Kích thước trang</param>
        /// <returns>Số bản ghi được lọc</returns>
        /// Created by NVMANH 29/7/2019
        public List<Fund> PagingFundBL(string where, int pageNumber, int pageSize)
        {
            return fundDL.PagingFundDL(where, pageNumber, pageSize);
        }
    }
}







