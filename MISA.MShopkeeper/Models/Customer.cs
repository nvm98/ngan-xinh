using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp khai báo khách hàng
    /// Người tạo NVMANH 20/6/2019
    /// </summary>
    public class Customer
    {
        //Mã khách hàng
        public Guid CustomerID { get; set; }
        //Mã code của khách hàng
        public string CustomerId { get; set; }
        //Tên khách hàng
        public string CustomerName { get; set; }
        //Loại khách hàng
        public string CustomerType { get; set; }
    }
}