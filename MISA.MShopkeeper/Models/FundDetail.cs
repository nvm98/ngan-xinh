using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp khai báo phần chi tiết của hóa đơn
    /// Người tạo NVMANH 7/7/2019
    /// </summary>
    public class FundDetail
    {
        //Mã của chi tiết hóa đơn
        public Guid fundDetailID { get; set; }
        //Lý do chi tiết
        public string fundReason { get; set; }
        //Số tiền chi tiết
        public int fundMoney { get; set; }
        //Loại của chi tiết hóa đơn
        public string fundTypeVoucher { get; set; }
        //Mã hóa đơn
        public Guid fundID { get; set; }
        //Khởi tạo lấy mã chi tiết
        public FundDetail()
        {
            fundDetailID = Guid.NewGuid();
        }
    }
}