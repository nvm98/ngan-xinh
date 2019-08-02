using MISA.DL.Base;
using MISA.Entites.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.DL.Dictonary
{
    /// <summary>
    /// Hàm xử lý dữ liệu với bảng Supplier
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class SupplierDL:BaseDL<Supplier>
    {
        /// <summary>
        /// Hàm lấy tất cả dữ liệu của nhà cung cấp
        /// </summary>
        /// <returns>Danh sách nhà cung cấp</returns>
        /// Created by NVMANH 24/7/2019
        public List<Supplier> GetSupplierData()
        {
            return GetAll("Proc_GetAllData", "Supplier");
        }
        /// <summary>
        /// Hàm lấy dữ liệu nhà cung cấp theo ID
        /// </summary>
        /// <param name="value">ID nhà cung cấp</param>
        /// <returns>Nhà cung cấp có ID tương ứng</returns>
        /// Created by NVMANH 24/7/2019
        public Supplier GetSupplierByID(string value)
        {
            return GetDataByAttribute("Proc_GetDataByAttribute", "Supplier", "SupplierID", value);
        }
    }
}
