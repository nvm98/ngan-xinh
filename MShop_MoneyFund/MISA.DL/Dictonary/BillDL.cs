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
    /// Lớp xử lý data với bảng Bill
    /// </summary>
    /// Created by NVMANH 1/8/2019
    public class BillDL: BaseDL<Bill>
    {
        /// <summary>
        /// Lấy tất cả bản ghi trên bảng Bill
        /// </summary>
        /// <returns>Danh sách hóa đơn</returns>
        /// Created by NVMANH 31/7/2019
        public List<Bill> GetAllBill()
        {
            return GetAll("Proc_GetAllData", "Bill");
        }
        /// <summary>
        /// Hàm lấy một danh sách hóa đơn theo ID nhà cung cấp
        /// </summary>
        /// <param name="value">id nhà cung cấp</param>
        /// <returns>danh sách hóa đơn theo nhà cung cấp</returns>
        /// Created by NVMANH 31/7/2019
        public List<Bill> GetBill(string value)
        {
            return GetAllDataByAttribute("Proc_GetAllDataByAttribute", "Bill", "SupplierID", value);
        }
    }
}
