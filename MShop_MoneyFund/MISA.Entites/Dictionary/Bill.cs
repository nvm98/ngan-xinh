using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Dictionary
{
    /// <summary>
    /// lớp Hóa đơn
    /// </summary>
    /// Created by 20/7/2019
    public class Bill:BaseEntity
    {
        #region Properties
        public Guid BillID { get; set; }
        // Mã chứng từ thu
        [Required]
        [MaxLength(20)]
        public string BillNumber { get; set; }
        //Ngày chứng từ
        public DateTime BillDate { get; set; }
        // Số tiền phải thu
        public decimal BillDebt { get; set; }
        //Số tiền chưa thu
        public decimal BillCollected { get; set; }
        #endregion

        #region ForeignKey
        //Khóa ngoại đến bảng Supplier
        public Guid SupplierID { get; set; }
        #endregion

        #region Constructors
        public Bill()
        {
            BillID = Guid.NewGuid();
        }
        #endregion
    }
}
