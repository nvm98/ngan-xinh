using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Dictionary
{
    /// <summary>
    /// Xây dựng đối tượng phiếu thu chi
    /// </summary>
    /// Created by 20/7/2019
    public class Fund:BaseEntity
    {
        #region Properties
        //Id
        public Guid FundID { get; set; }
        //Mã chứng từ
        [Required(ErrorMessage = "Vui lòng điền mã chứng từ")]
        [MaxLength(20)]
        public string FundNumberVoucher { get; set; }
        //Ngày chứng từ
        [Required(ErrorMessage = "Vui lòng điền ngày chứng từ")]
        public DateTime FundDate { get; set; }
        //Tổng tiền
        [Required(ErrorMessage = "Vui lòng điền tổng tiền")]
        public decimal FundMoney { get; set; }
        //Người nộp/nhận
        [MaxLength(100)]
        public string FundObject { get; set; }
        //Lý do
        [MaxLength(255)]
        public string FundReason { get; set; }
        //loại chứng từ
        [MaxLength(255)]
        public string FundTypeVoucher { get; set; }
        //Check phiếu thu/chi
        [Required]
        public bool CheckType { get; set; }
        //Check loại chứng từ là Khác hay trả nợ
        [Required]
        public bool CheckDifferent { get; set; }
        #endregion

        #region ForeignKey
        //Khóa ngoại đến bảng Supplier
        [Required]
        public Guid SupplierID { get; set; }

        //Khóa ngoại đến bảng Employee
        [Required]
        public Guid EmployeeID { get; set; }
        //Tổng số bản ghi
        public int TotalCount { get; set; }
        #endregion

        #region Constructors
        //Hàm khởi tạo chứng từ
        public Fund()
        {
            FundID = Guid.NewGuid();
            FundDate = DateTime.Now;
        }

        #endregion
    }
}
