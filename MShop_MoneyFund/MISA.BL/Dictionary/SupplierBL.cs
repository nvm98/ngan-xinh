using MISA.BL.Base;
using MISA.DL.Dictonary;
using MISA.Entites.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.BL.Dictionary
{
    /// <summary>
    /// Lớp xủa lý nghiệp vụ với bảng Supplier
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class SupplierBL :BaseBL
    {
        private SupplierDL supplierDL;
        public SupplierBL()
        {
            supplierDL = new SupplierDL();
        }
        /// <summary>
        /// Hàm lấy tất cả danh sách nhà cung cấp
        /// </summary>
        /// <returns>danh sách nhà cung cấp</returns>
        /// Created by NVMANH 24/7/2019
        public List<Supplier> GetAllSupplier()
        {
            return supplierDL.GetSupplierData();
        }
        /// <summary>
        /// Hàm lấy dữ liệu của nhà cung cấp theo ID
        /// </summary>
        /// <param name="value">id nhà cung cấp</param>
        /// <returns>Nhà cung cấp có id tương ứng</returns>
        /// Created by NVMANH 24/7/2019
        public Supplier GetSupplierByIDBL(Guid value)
        {
            var id = Commons.Commons.ConvertGuidToNvarchar(value);
            return supplierDL.GetSupplierByID(id);
        }
    }
}
