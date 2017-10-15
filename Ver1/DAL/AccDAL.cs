using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ver1.DAL
{
    class AccDAL
    {
        private SqlConnection Con;
        private SqlCommand Cmd = null;
        private SqlDataReader dr = null;

        public AccDAL()
        {
            string Connect = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            Con = new SqlConnection(Connect);
        }


        /// <summary>
        /// Hàm dùng mở kết nối nếu lỗi ném ra
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hàm dùng đóng kết nối nếu lỗi ném ra
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hàm cho phép tất cả BNL đọc từ bảng table
        /// </summary>
        /// <param name="Table"> là tên bảng cần đọc </param>
        /// <returns> trả về SqlDataReader </returns>
        public SqlDataReader ReadData (string Table)
        {
            try
            {
                string Query = @"SELECT * FROM " + Table;
                Cmd = new SqlCommand(Query, Con);
                this.OpenConnection();
                dr = Cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dr;
        }
        public void ChangeData(string Query)
        {
            Cmd = new SqlCommand(Query, Con);
            try
            {
                this.OpenConnection();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
