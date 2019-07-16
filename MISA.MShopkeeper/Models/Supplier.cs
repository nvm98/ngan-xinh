using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp về nhà cung cấp
    /// Người tạo NVMANH 12/6/2019
    /// </summary>
    public class Supplier
    {
        //Mã nhà cung cấp
        public Guid supplierID { get; set; }
        //Mã code nhà cung cấp
        public string supplierId { get; set; }
        //Tên nhà cung cấp
        public string supplierName { get; set; }
        //Loại nhà cung cấp
        public string supplierType { get; set; }
        //Địa chỉ nhà cung cấp
        public string supplierAddress { get; set; }
        //Mã loại nhà cung cấp
        public Guid supplierTypeID { get; set; }
    }
}