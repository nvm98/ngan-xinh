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
    /// Lớp xử lý dữ liệu với bảng FundDetail
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class FundDetailDL:BaseDL<FundDetail>
    {
        /// <summary>
        /// Hàm lấy tất cả các bản chi tiết theo ID hóa đơn
        /// </summary>
        /// <param name="value">id của phiếu</param>
        /// <returns>danh sách chi tiết hóa đơn</returns>
        /// Created by NVMANH 24/7/2019
        public List<FundDetail> GetAllDetailByFundID(string value)
        {
            return GetAllDataByAttribute("Proc_GetAllDataByAttribute", "FundDetail", "FundID", value);
        }
        /// <summary>
        /// Hàm thêm mới dữ liệu cho bản ghi chi tiết hóa đơn
        /// </summary>
        /// <param name="fundDetail">bản ghi chi tiết phiếu</param>
        /// <returns>Số bản ghi được thêm mới</returns>
        /// Created by NVMANH 26/7/2019
        public int CreateFundDetail(FundDetail fundDetail)
        {
            return SaveEntity("Proc_CreateFundDetail", fundDetail);
        }
        /// <summary>
        /// Hàm xóa chi tiết hóa đơn
        /// </summary>
        /// <param name="value">id của chi tiết phiếu</param>
        /// <returns>Số bản ghi bị xóa</returns>
        /// Created by NVMANH 26/7/2019
        public int DeleteFundDetail(string value)
        {
            return DeleteEntity("Proc_Delete", "FundDetail", "FundDetailID", value);
        }
        /// <summary>
        /// Hàm sửa chi tiết hóa đơn
        /// </summary>
        /// <param name="fundDetail">bản ghi chi tiết hóa đơn</param>
        /// <returns>Số bản ghi được sửa</returns>
        /// Created by NVMANH 26/7/2019
        public int EditFundDetail(FundDetail fundDetail)
        {
            return SaveEntity("Proc_EditFundDetail", fundDetail);
        }
    }
}
