using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Dictionary
{
    /// <summary>
    /// Lớp chi tiết hóa đơn
    /// </summary>
    /// Created by NVMANH 22/7/2019
    public class FundDetail:BaseEntity
    {
        #region Properties
        //Khóa chính
        public Guid FundDetailID { get; set; }
        //Diễn giải
        public string FundReason { get; set; }
        //Số tiền
        public decimal FundMoney { get; set; }
        //Loại chứng từ
        public string FundTypeVoucher { get; set; }
        #endregion

        #region ForeignKeys
        //Khóa ngoại đến bảng Fund
        public Guid FundID { get; set; }
        #endregion

        #region Constructors
        //Hàm khởi tạo
        public FundDetail()
        {
            FundDetailID = Guid.NewGuid();
        }
        #endregion
    }
}
