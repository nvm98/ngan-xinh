using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Dictionary
{
    /// <summary>
    /// Xây dựng đối tượng nhân viên
    /// </summary>
    /// Created by NVMANH 22/7/2019
    public class Employee:BaseEntity
    {
        #region Properties
        // id nhân viên
        public Guid EmployeeID { get; set; }
        // Tên nhân viên
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }
        // Mã nhân viên
        [Required]
        [MaxLength(20)]
        public string EmployeeCode { get; set; }
        // Địa chỉ
        [MaxLength(255)]
        public string EmployeeAddress { get; set; }
        // Số điện thoại
        [Required]
        [MaxLength(50)]
        public string EmployeePhone { get; set; }
        #endregion

        #region Constructors
        public Employee()
        {
            EmployeeID = Guid.NewGuid();
        }
        #endregion
    }
}
