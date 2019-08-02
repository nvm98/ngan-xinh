using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp lấy chứng từ thu nợ
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class BillCollectViewModels
    {
        #region Properties
        //Mã hóa đơn thu nợ
        public Guid BillID { get; set; }
        //Ngày chứng từ hóa đơn thu nợ
        public DateTime BillDate { get; set; }
        //số chứng từ hóa đơn thu nợ
        public string BillNumber { get; set; }
        //Số tiền phải thu
        public decimal BillDebt { get; set; }
        //Số tiền chưa thu
        public decimal BillCollected { get; set; }
        #endregion
        #region ForeignKeys
        //Mã khách hàng 
        public Guid SupplierID { get; set; }
        #endregion
        #region Constructor
        public BillCollectViewModels()
        {
            BillID = Guid.NewGuid();
        }
        #endregion
    }
}
