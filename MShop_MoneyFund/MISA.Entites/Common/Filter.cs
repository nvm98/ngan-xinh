using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Entites.Common
{
    /// <summary>
    /// Lớp dùng để lọc dữ liệu
    /// </summary>
    /// Created by NVMANH 28/7/2019
    public class Filter
    {
        public string Field { get; set; }
        public string Type { get; set; }
        public string DataType { get; set; }
        public string Value { get; set; }

        /// <summary>
        /// Hàm thực hiện build chuỗi câu điều kiện Where
        /// </summary>
        /// <param name="filters">List các trường Filter</param>
        /// <returns>chuỗi where cho câu truy vấn dữ liệu</returns>
        /// Created by NVMANH 28/7/2019
        public static string buidWhereFilterCondition(List<Filter> filters)
        {
            //string where = string.Empty;
            StringBuilder where = new StringBuilder();
            foreach (var item in filters)
            {
                switch (item.DataType)
                {
                    case "decimal":
                        if(item.Value == "")
                        {
                            where.Append("");
                        }
                        else
                        {
                            where.AppendFormat(" AND {0} {1} {2}", item.Field, item.Type, item.Value.Replace(".", ""));
                        }
                        break;
                    case "date":
                        if (item.Value == "")
                        {
                            where.Append("");
                        }
                        else
                        {
                            where.AppendFormat(" AND {0} = CONVERT(VARCHAR(10), CONVERT(date, '{1}', 105), 23)", item.Field, item.Value);
                        }
                        break;
                    case "float":
                    default:
                        where.Append(buidFilterWhereConditionForStringType(item));
                        break;
                }
            }

            return where.ToString();
        }
        /// <summary>
        /// Hàm thực hiện build chuỗi câu điều kiện Where - sử dụng cho kiểu dữ liệu của input là string
        /// </summary>
        /// <param name="filters">List các trường Filter</param>
        /// <returns>chuỗi where cho câu truy vấn dữ liệu</returns>
        /// Created by NVMANH 28/7/2019
        private static string buidFilterWhereConditionForStringType(Filter filter)
        {
            string where = string.Empty;
            string value = filter.Value.Replace("'", "''");
            if (filter.Value == "Tất cả")
            {
                where = "";
            }
            else
            {
                where = String.Format(" AND {0} LIKE N'%{1}%'", filter.Field, value);
            }
            return where;
        }
    }
}
