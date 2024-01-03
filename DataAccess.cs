﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market_management
{
    internal class DataAccess
    {
        SqlConnection objConnection = new SqlConnection();
        public DataAccess()
        {
            string strConnection = @"Data Source=     ";

            objConnection = new SqlConnection(strConnection);

        }
        /// <summary>
        /// Phương thức thực hiện Thêm, Xóa, Sửa bảng dữ liệu
        /// </summary>
        /// <param name="i_updateCommand">Câu lệnh INSERT, DELETE, UPDATE</param>
        public void UpdateData(string i_updateCommand)
        {
            try
            {
                objConnection.Open();
                Console.WriteLine("Connection succeeded");
                SqlCommand cmd = new SqlCommand(i_updateCommand, objConnection);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }
        }

        public DataTable GetDataTable(string i_selectCommand)
        {
            DataTable dt = new DataTable();
            try
            {
                objConnection.Open();
                Console.WriteLine("Connection succeeded");
                SqlDataAdapter objAdapter = new SqlDataAdapter(i_selectCommand, objConnection);

                objAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (objConnection != null)
                    objConnection.Close();
            }

            return dt;
        }
    }
}
