using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Khai báo hóa đơn thu nợ
    /// Người tạo NVMANH 22/6/2019
    /// </summary>
    public class BillCollect
    {
        //Mã hóa đơn thu nợ
        public Guid billID { get; set; }
        //Ngày chứng từ hóa đơn thu nợ
        public DateTime billDate { get; set; }
        //số chứng từ hóa đơn thu nợ
        public string billNumber { get; set; }
        //Số tiền phải thu
        public int billDebt { get; set; }
        //Số tiền chưa thu
        public int billCollected { get; set; }
        //Mã khách hàng 
        public Guid supplierID { get; set; }
    }
}