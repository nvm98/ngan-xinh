using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp khai báo hóa đơn
    /// Người tạo NVMANH 20/6/2019
    /// </summary>
    public class Fund
    {
        //Mã hóa đơn
        public Guid fundID { get; set; }
        //Ngày chứng từ
        public DateTime fundDate { get; set; }
        //Số chứng từ
        public string fundNumberVoucher { get; set; }
        //Loại chứng từ
        public string fundTypeVoucher { get; set; }
        //Tổng tiền hóa đơn
        public int fundMoney { get; set; }
        //Đối tượng nộp nhận
        public string fundObject { get; set; }
        //Lý do
        public string fundReason { get; set; }
        //Mã nhân viên
        public Guid employeeID { get; set; }
        //Mã nhà cung cấp
        public Guid supplierID { get; set; }
        //Loại phiếu chi / phiếu thu
        public string typeCheck { get; set; }
        //Khởi tạo lấy mã hóa đơn
        public Fund()
        {
            fundID = Guid.NewGuid();
        }
    }
}