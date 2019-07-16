using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.MShopkeeper.Models
{
    /// <summary>
    /// Lớp cho loại nhà cung cấp
    /// Người tạo NVMANH 25/6/2019
    /// </summary>
    public class SupplierType
    {
        //mã loại nhà cung cấp
        public Guid supplierTypeID { get; set; }
        //tên loại nhà cung cấp
        public string supplierTypeName { get; set; }
    }
}