using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.ViewModels
{
    /// <summary>
    /// Lớp chứa kết quả khi gọi Ẫ
    /// </summary>
    public class AjaxResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int Code { get; set; }
        public AjaxResult()
        {
            Success = true;
        }
    }
}
