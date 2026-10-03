using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCSDL_1.DAO
{
    internal class KNCSDL
    {
      
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=MAYTINH-G4QAOCF;Initial Catalog=QLSVLOP;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối không thành công!");
            }
        }
        public static void DongKetNoi()
        {
            if(cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable DOCDULIEU(string sql)
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr=cd.ExecuteReader();
            DataTable dt=new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiTruyVan(string sql)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
        public static void ThucThiTruyVan(SqlCommand cmd)
        {
            MoKetNoi();

            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
        //là hàm này dùng cho các câu SQL có Parameter.
        public static DataTable DOCDULIEU(SqlCommand cmd)
        {
            MoKetNoi();
            cmd.Connection = cnn;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
    }

}
