using MISA.DL.Base;
using MISA.Entites.Dictionary;
using MISA.Entites.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.DL.Dictonary
{
    /// <summary>
    /// Lớp xử lý dữ liệu với bảng Fund
    /// </summary>
    /// Created by NVMANH 23/7/2019
    public class FundDL : BaseDL<Fund>
    {
        /// <summary>
        /// Hàm lấy tất cả dữ liệu chứng từ
        /// </summary>
        /// <returns>danh sách phiếu</returns>
        /// Created by NVMANH 23/7/2019
        public List<Fund> GetFundData()
        {
            return GetAll("Proc_GetAllData", "Fund");
        }
        /// <summary>
        /// Hàm lấy dữ liệu bản ghi theo ID
        /// </summary>
        /// <param name="value">id của phiếu</param>
        /// <returns>bản ghi của một phiếu</returns>
        /// Created by NVMANH 24/7/2019
        public Fund GetFundByID(string value)
        {
            return GetDataByAttribute("Proc_GetDataByAttribute", "Fund", "FundID", value);
        }
        /// <summary>
        /// Hàm lấy dữ liệu bản ghi theo mã hóa đơn
        /// </summary>
        /// <param name="code">Mã code của phiếu</param>
        /// <returns>phiếu thu có mã tương ứng</returns>
        /// Created by NVMANH 26/7/2019
        public Fund GetFundByFundCode(string code)
        {
            return GetDataByAttribute("Proc_GetDataByAttribute", "Fund", "FundNumberVoucher", code);
        }
        /// <summary>
        /// Hàm thêm mới dữ liệu hóa đơn
        /// </summary>
        /// <param name="fund">Đối tượng phiếu</param>
        /// <returns>Số bản ghi được thêm</returns>
        /// Created by NVMANH 25/7/2019
        public int CreateFund(Fund fund)
        {
            return SaveEntity("Proc_CreateFund", fund);
        }
        /// <summary>
        /// Hàm xóa dữ liệu hóa đơn
        /// </summary>
        /// <param name="value">id của phiếu</param>
        /// <returns>số bản ghi bị xóa</returns>
        /// Created by NVMANH 26/7/2019
        public int DeleteFund(string value)
        {
            return DeleteEntity("Proc_Delete", "Fund", "FundID", value);
        }
        /// <summary>
        /// Hàm sửa dữ liệu hóa đơn
        /// </summary>
        /// <param name="fund">Đối tượng phiếu</param>
        /// <returns>Số bản ghi được sửa</returns>
        /// Created by NVMANH 26/7/2019
        public int EditFund(Fund fund)
        {
            return SaveEntity("Proc_EditFund", fund);
        }

        /// <summary>
        /// Lấy mã tự tăng phiếu thu
        /// </summary>
        /// <returns>Mã phiếu thu tăng hợp lệ</returns>
        /// Created by NVMANH 26/7/2019
        public string GetCollectCodeAuto()
        {
            return GetCodeFund("SELECT [dbo].[Func_CollectCodeAutoIncrease] ()");
        }
        /// <summary>
        /// Lấy mã tự tăng phiếu chi
        /// </summary>
        /// <returns>Mã phiếu chi tăng hợp lệ</returns>
        /// Created by NVMANH 26/7/2019
        public string GetPayCodeAuto()
        {
            return GetCodeFund("SELECT [dbo].[Func_PayCodeAutoIncrease] ()");
        }
        /// <summary>
        /// Hàm xử lý phân trang tương tác với bảng Fund
        /// </summary>
        /// <param name="where">Chuỗi điều kiện lọc</param>
        /// <param name="pageNumber">Số trang</param>
        /// <param name="pageSize">Kích thước trang</param>
        /// <returns></returns>
        /// Created by NVMANH 29/7/2019
        public List<Fund> PagingFundDL(string where, int pageNumber, int pageSize)
        {
            return PagingFund("Proc_Filter", where, pageNumber, pageSize);
        }
    }
}
