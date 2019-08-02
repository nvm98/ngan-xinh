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
    /// Hàm xử lý nghiệp vụ với bảng Fund
    /// </summary>
    /// Created by NVMANH 31/7/2019
    public class BillBL : BaseBL
    {
        private BillDL billDL;

        public BillBL()
        {
            billDL = new BillDL();
        }
        /// <summary>
        /// Lấy tất cả danh sách hóa đơn
        /// </summary>
        /// <returns>Danh sách hóa đơn</returns>
        /// Created by NVMANH 31/7/2019
        public List<Bill> GetAllBillBL()
        {
            return billDL.GetAllBill();
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ lấy danh sách hóa đơn theo id nhà cung cấp
        /// </summary>
        /// <param name="value">id hóa đơn</param>
        /// <returns>Hóa đơn có id tương ứng</returns>
        /// Created by NVMANH 31/7/2019
        public List<Bill> GetBillBL(Guid value)
        {
            string id = Commons.Commons.ConvertGuidToNvarchar(value);
            return billDL.GetBill(id);
        }
    }
}
