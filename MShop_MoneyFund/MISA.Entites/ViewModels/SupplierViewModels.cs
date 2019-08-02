using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp lấy dữ liệu nhà cung cấp
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class SupplierViewModels
    {
        #region Properties
        //Mã nhà cung cấp
        public Guid SupplierID { get; set; }
        
        //Mã code của nhà cung cấp
        public string SupplierCode { get; set; }
        //tên của nhà cung cấp
        public string SupplierName { get; set; }
        //Tên của lại nhà cung cấp
        public string ObjectTypeName { get; set; }
        //Địa chỉ của nhà cung cấp
        public string SupplierAddress { get; set; }
        #endregion
        #region ForeignKeys
        //Mã của loại nhà cung cấp , khóa ngoài đến bảng SupplierType
        public Guid SupplierTypeID { get; set; }
        #endregion
        #region Constructor
        public SupplierViewModels()
        {
            SupplierID = Guid.NewGuid();
        }
        #endregion
    }
}
