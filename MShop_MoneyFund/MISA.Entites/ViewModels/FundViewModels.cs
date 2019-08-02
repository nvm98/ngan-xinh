using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp lấy ra dữ liệu của hóa đơn
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class FundViewModels
    {
        #region Properties
        //Mã hóa đơn
        public Guid FundID { get; set; }
        //Mã code nhà cung cấp
        public string SupplierCode { get; set; }
        //Loại chứng từ
        public string FundTypeVoucher { get; set; }
        //Tổng tiền
        public decimal FundMoney { get; set; }
        //Đối tượng nộp nhận
        public string FundObject { get; set; }
        //Tên nhà cung cấp
        public string SupplierName { get; set; }
        //Tên loại nhà cung cấp
        //public string SupplierTypeName { get; set; }
        //Địa chỉ nhà cung cấp
        public string SupplierAddress { get; set; }
        //Lý do
        public string FundReason { get; set; }
        //Mã code nhân viên
        public string EmployeeCode { get; set; }
        //Tên nhân viên
        public string EmployeeName { get; set; }
        //Số chưng từ
        public string FundNumberVoucher { get; set; }
        //Ngày chứng từ
        public DateTime FundDate { get; set; }
        //Loại phiếu thu/ trả
        public bool CheckType { get; set; }
        //Loại phiếu khác / phiếu thu nợ
        public bool CheckDifferent { get; set; }
        #endregion

        #region ForeignKeys
        //Mã nhà cung cấp, khóa ngoại đến bảng Supplier
        public Guid SupplierID { get; set; }
        //Mã nhân viên, khóa ngoại đến bảng Employee
        public Guid EmployeeID { get; set; }
        #endregion

        #region Constructor
        public FundViewModels()
        {
            FundID = Guid.NewGuid();
            FundDate = DateTime.Now;
        }
        #endregion
    }
}
