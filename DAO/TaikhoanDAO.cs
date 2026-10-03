using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_1.DAO
{
    internal class TaikhoanDAO
    {
        public static bool DangNhap(string taiKhoan, string matKhau)
        {
            string sql = @"SELECT COUNT(*)
                           FROM TAIKHOAN
                           WHERE TenDangNhap = @TaiKhoan
                           AND MatKhau = @MatKhau";

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=MAYTINH-G4QAOCF;Initial Catalog=QLSVLOP;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@TaiKhoan", System.Data.SqlDbType.NVarChar, 50);
                cmd.Parameters["@TaiKhoan"].Value = taiKhoan;

                cmd.Parameters.Add("@MatKhau", System.Data.SqlDbType.NVarChar, 100);
                cmd.Parameters["@MatKhau"].Value = matKhau;

                int kq = (int)cmd.ExecuteScalar();

                return kq > 0;
            }
        }
    }
}
