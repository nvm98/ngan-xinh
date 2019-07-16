using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    //Class hóa đơn trả nợ
    public class BillPay
    {
        //mã hóa đơn trả nợ
        public Guid billPayID { get; set; }
        //Ngày hóa đơn trả nợ
        public DateTime billPayDate { get; set; }
        //Số hóa đơn trả nợ
        public string billPayNumber { get; set; }
        //Số phải trả
        public int billPayPaid { get; set; }
        //Số chưa trả
        public int billPayUnpaid { get; set; }
        //Mã nhà cung cấp
        public Guid supplierID { get; set; }
    }
}