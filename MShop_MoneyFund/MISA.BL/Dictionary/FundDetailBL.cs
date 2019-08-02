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
    /// Lớp xử lý nghiệp vụ với bảng FundDetail
    /// </summary>
    /// Created by NVMANH 24/7/2019
    public class FundDetailBL:BaseBL
    {
        private FundDetailDL fundDetailDL;
        public FundDetailBL()
        {
            fundDetailDL = new FundDetailDL();
        }
        /// <summary>
        /// Lấy danh sách chi tiết hóa đơn theo mã hóa đơn
        /// </summary>
        /// <param name="value">ID của phiếu</param>
        /// <returns>Danh sách chi tiết phiếu theo mã phiếu</returns>
        /// Created by NVMANH 24/7/2019
        public List<FundDetail> GetAllFundDetailByFundID(Guid value)
        {
            var id = Commons.Commons.ConvertGuidToNvarchar(value);
            return fundDetailDL.GetAllDetailByFundID(id);
        }
        /// <summary>
        /// Hàm thêm mới chi tiết hóa đơn
        /// </summary>
        /// <param name="fundDetail">Chi tiết của phiếu</param>
        /// <returns>Số phiếu được thêm mới</returns>
        /// Created by NVMANH 26/7/2019
        public int CreateFundDetailBL(FundDetail fundDetail)
        {
            return fundDetailDL.CreateFundDetail(fundDetail);
        }
        /// <summary>
        /// Hàm xóa chi tiết hóa đơn
        /// </summary>
        /// <param name="id">id của chi tiết phiếu</param>
        /// <returns>Số bản ghi bị xóa</returns>
        /// Created by NVMANH 26/7/2019
        public int DeleteFundDetailBL(Guid id)
        {
            var value = Commons.Commons.ConvertGuidToNvarchar(id);
            return fundDetailDL.DeleteFundDetail(value);
        }
        /// <summary>
        /// Hàm xử lý nghiệp vụ sửa chi tiết hóa đơn
        /// </summary>
        /// <param name="fundDetail">bản ghi Chi tiết phiếu</param>
        /// <returns>Số bản ghi bị sửa</returns>
        /// Created by NVMANH 26/7/2019
        public int EditFundDetailBL(FundDetail fundDetail) {
            return fundDetailDL.EditFundDetail(fundDetail);
        }
    }
}
