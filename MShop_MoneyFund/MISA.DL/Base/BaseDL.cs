using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.DL.Base
{
    /// <summary>
    /// lớp thực hiện tương tác với cơ sở dữ liệu
    /// </summary>
    /// Created by NVMANH 23/7/2019
    public class BaseDL<T>
    {
        /// <summary>
        /// Lớp lấy tất cả dữ liệu của Bảng
        /// </summary>
        /// <param name="storeName">Tên store thực hiện</param>
        /// <param name="tableName">Tên bảng</param>
        /// <returns>List đối tượng</returns>
        /// Created by NVMANH 23/7/2019
        public List<T> GetAll(string storeName, string tableName)
        {
            var entities = new List<T>();
            using (DataAccess dataAccess = new DataAccess())
            {
                // Khởi tạo đối tượng SqlDataReader hứng dữ liệu trả về:
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandText = storeName;
                sqlCommand.Parameters.AddWithValue("@tableName", tableName);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    var entity = Activator.CreateInstance<T>();
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        // Lấy ra tên propertyName dựa vào tên cột của field hiện tại:
                        var propertyName = sqlDataReader.GetName(i);
                        // Lấy ra giá trị của field hiện tại:
                        var propertyValue = sqlDataReader.GetValue(i);
                        // Gán Value cho Property tương ứng:
                        var propertyInfo = entity.GetType().GetProperty(propertyName);
                        if (propertyInfo != null && propertyValue != DBNull.Value)
                        {
                            propertyInfo.SetValue(entity, propertyValue);
                        }
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }
        /// <summary>
        /// Hàm lấy một bản ghi theo điều kiện
        /// </summary>
        /// <param name="storeName">Tên store thực hiện</param>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="columnName">Tên cột cần lọc</param>
        /// <param name="value">Giá trị cần lọc</param>
        /// <returns>Một bản ghi với điều kiện tương ứng</returns>
        /// Created by NVMANH 23/7/2019
        public T GetDataByAttribute(string storeName, string tableName, string columnName, string value)
        {
            var entity = Activator.CreateInstance<T>();
            using (DataAccess dataAccess = new DataAccess())
            {
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandText = storeName;
                sqlCommand.Parameters.AddWithValue("@TableName", tableName);
                sqlCommand.Parameters.AddWithValue("@ColumnName", columnName);
                sqlCommand.Parameters.AddWithValue("@Value", value);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    for(int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        // Lấy ra tên propertyName dựa vào tên cột của field hiện tại:
                        var propertyName = sqlDataReader.GetName(i);
                        // Lấy ra giá trị của field hiện tại:
                        var propertyValue = sqlDataReader.GetValue(i);
                        // Gán Value cho Property tương ứng:
                        var propertyInfo = entity.GetType().GetProperty(propertyName);
                        if (propertyInfo != null && propertyValue != DBNull.Value)
                        {
                            propertyInfo.SetValue(entity, propertyValue);
                        }
                    }
                }
            }
            return entity;
        }
        /// <summary>
        /// Hàm lấy dữ liệu theo thuộc tính
        /// </summary>
        /// <param name="storeName">Tên store thực hiện</param>
        /// <param name="tableName">Tên bảng</param>
        /// <param name="columnName">Tên cột</param>
        /// <param name="value">Giá trị lọc</param>
        /// <returns>Danh sách bản ghi sau khi lọc</returns>
        /// Created by NVMANH 24/7/2019
        public List<T> GetAllDataByAttribute(string storeName, string tableName, string columnName, string value)
        {
            var entities = new List<T>();
            using (DataAccess dataAccess = new DataAccess())
            {
                // Khởi tạo đối tượng SqlDataReader hứng dữ liệu trả về:
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandText = storeName;
                sqlCommand.Parameters.AddWithValue("@TableName", tableName);
                sqlCommand.Parameters.AddWithValue("@ColumnName", columnName);
                sqlCommand.Parameters.AddWithValue("@Value", value);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    var entity = Activator.CreateInstance<T>();
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        // Lấy ra tên propertyName dựa vào tên cột của field hiện tại:
                        var propertyName = sqlDataReader.GetName(i);
                        // Lấy ra giá trị của field hiện tại:
                        var propertyValue = sqlDataReader.GetValue(i);
                        // Gán Value cho Property tương ứng:
                        var propertyInfo = entity.GetType().GetProperty(propertyName);
                        if (propertyInfo != null && propertyValue != DBNull.Value)
                        {
                            propertyInfo.SetValue(entity, propertyValue);
                        }
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }

        /// <summary>
        /// Phương thức để thêm mới hoặc sửa thực thể
        /// </summary>
        /// <param name="storeName">Tên store thữu hiện</param>
        /// <param name="entity">Đối tượng cần lưu hay thêm mới</param>
        /// <returns>Số bản ghi được lưu hoặc lọc</returns>
        /// Created by NVMANH 24/7/2019
        public int SaveEntity(string storeName, T entity)
        {
            var result = 0;
            using (DataAccess dataAccess = new DataAccess())
            {
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandText = storeName;
                SqlCommandBuilder.DeriveParameters(sqlCommand);
                var parameters = sqlCommand.Parameters;
                SqlTransaction sqlTransaction = sqlCommand.Connection.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                try
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        //Lấy tên parameter tương ứng
                        var paramName = parameter.ToString().Replace("@", string.Empty);
                        //Lấy tên thuộc tính cuả đối tượng
                        var property = entity.GetType().GetProperty(paramName);
                        if (property != null)
                        {
                            var paramValue = property.GetValue(entity);
                            parameter.Value = paramValue != null ? paramValue : DBNull.Value;
                        }
                        else
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }
                    result = sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm xóa các bản ghi 
        /// </summary>
        /// <param name="storeName">tên store thực hiện</param>
        /// <param name="tableName">tên bảng</param>
        /// <param name="columnName">tên cột</param>
        /// <param name="value">giá trị để xóa</param>
        /// <returns>Số bản ghi được xóa</returns>
        /// Created by NVMANH  26/7/2019
        public int DeleteEntity(string storeName, string tableName, string columnName, string value)
        {
            var result = 0;
            using (DataAccess dataAccess = new DataAccess())
            {
                var sqlCommand = dataAccess.SqlCommand;
                SqlTransaction sqlTransaction = sqlCommand.Connection.BeginTransaction();
                sqlCommand.Transaction = sqlTransaction;
                try
                {
                    sqlCommand.CommandText = storeName;
                    sqlCommand.Parameters.AddWithValue("@TableName", tableName);
                    sqlCommand.Parameters.AddWithValue("@ColumnName", columnName);
                    sqlCommand.Parameters.AddWithValue("@Value", value);
                    result = sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch (Exception)
                {
                    sqlTransaction.Rollback();
                }
            }
            return result;
        }
        /// <summary>
        /// Hàm lấy mã tự tăng
        /// </summary>
        /// <param name="storeName">Tên store tạo mã</param>
        /// <returns>Mã cần tạo</returns>
        /// Created by NVMANH 26/7/2019
        public string GetCodeFund(string storeName)
        {
            string fundCode;
            using (DataAccess dataAccess = new DataAccess())
            {
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = storeName;
                fundCode = sqlCommand.ExecuteScalar().ToString();
            }
            return fundCode;
        }
        /// <summary>
        /// Hàm hỗ trợ phân trang và lọc
        /// </summary>
        /// <param name="storeName">Tên store phân trang vào lọc</param>
        /// <param name="where">Điều kiện lọc</param>
        /// <param name="pageNumber">Số trang</param>
        /// <param name="pageSize">Kích thước trang</param>
        /// <returns>Số bản ghi được lọc</returns>
        /// Created by NVMANH 29/7/2019
        public List<T> PagingFund(string storeName, string where, int pageNumber, int pageSize)
        {
            var entities = new List<T>();
            using (DataAccess dataAccess = new DataAccess())
            {
                // Khởi tạo đối tượng SqlDataReader hứng dữ liệu trả về:
                var sqlCommand = dataAccess.SqlCommand;
                sqlCommand.CommandText = storeName;
                sqlCommand.Parameters.AddWithValue("@Condition", where);
                sqlCommand.Parameters.AddWithValue("@PageNumber", pageNumber);
                sqlCommand.Parameters.AddWithValue("@PageSize", pageSize);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    var entity = Activator.CreateInstance<T>();
                    for (int i = 0; i < sqlDataReader.FieldCount; i++)
                    {
                        // Lấy ra tên propertyName dựa vào tên cột của field hiện tại:
                        var propertyName = sqlDataReader.GetName(i);
                        // Lấy ra giá trị của field hiện tại:
                        var propertyValue = sqlDataReader.GetValue(i);
                        // Gán Value cho Property tương ứng:
                        var propertyInfo = entity.GetType().GetProperty(propertyName);
                        if (propertyInfo != null && propertyValue != DBNull.Value)
                        {
                            propertyInfo.SetValue(entity, propertyValue);
                        }
                    }
                    entities.Add(entity);
                }
            }
            return entities;
        }
    }
}
