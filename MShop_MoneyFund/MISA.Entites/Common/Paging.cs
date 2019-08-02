using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Common
{
    public class Paging<T>
    {
        public List<T> Entities { get; set; }
        public int TotalPage { get; set; }
        public int TotalRecord { get; set; }
    }
}
