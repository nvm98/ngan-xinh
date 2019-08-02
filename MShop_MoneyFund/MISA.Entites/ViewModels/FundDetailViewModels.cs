using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp lấy dữ liệu chi tiết hóa đơn
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class FundDetailViewModels
    {
        #region Properties
        //Mã của chi tiết hóa đơn
        public Guid FundDetailID { get; set; }
        //Lý do chi tiết
        public string FundReason { get; set; }
        //Số tiền chi tiết
        public decimal FundMoney { get; set; }
        //Loại của chi tiết hóa đơn
        public string FundTypeVoucher { get; set; }
        #endregion
        #region ForeignKeys
        //Mã hóa đơn, khóa ngoại đến bảng Fund
        public Guid FundID { get; set; }
        #endregion
        #region Constructor
        public FundDetailViewModels() {
            FundDetailID = Guid.NewGuid();
        }
        #endregion
    }
}
