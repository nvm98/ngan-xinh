using MISA.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Dictionary
{
    /// <summary>
    /// Lớp nhà cung cấp
    /// Người tạo NVMANH 22/7/2019
    /// </summary>
    public class Supplier:BaseEntity
    {
        #region Properties
        public Guid SupplierID { get; set; }
        // Mã nhà cung cấp
        [Required]
        [MaxLength(20)]
        public string SupplierCode { get; set; }
        // Tên nhà cung cấp
        [Required]
        [MaxLength(255)]
        public string SupplierName { get; set; }
        // Địa chỉ
        [MaxLength(255)]
        public string SupplierAddress { get; set; }
        #endregion
        //Khóa ngoại đến bảng SupplierType
        [Required]
        public int SupplierType { get; set; }
        public string SupplierTypeName {
            get
            {
                string supplierTypeName;
                Enumeration.SupplierType supplierType = (Enumeration.SupplierType)(this.SupplierType);
                switch (supplierType)
                {
                    case Enumeration.SupplierType.Customer:
                        supplierTypeName = "Khách hàng";
                        break;
                    case Enumeration.SupplierType.Employee:
                        supplierTypeName = "Nhân viên";
                        break;
                    case Enumeration.SupplierType.Shipper:
                        supplierTypeName = "Đối tác giao hàng";
                        break;
                    case Enumeration.SupplierType.Supplier:
                        supplierTypeName = "Nhà cung cấp";
                        break;
                    default:
                        supplierTypeName = "Không xác định";
                        break;
                }
                return supplierTypeName;
            }
            set
            {


            }
        }

        #region Constructors
        /// <summary>
        /// Hàm khởi tạo mặc đinh khi tạo đối tượng
        /// Người tạo NVMANH 22/7/2019
        /// </summary>
        public Supplier()
        {
            SupplierID = Guid.NewGuid();
        }
        #endregion
    }
}
