using LTCSDL_1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTCSDL_1.DAO
{
    internal class SinhvienDAO
    {
        public static DataTable ThongTinSinhVien()
        {
            SqlCommand cmd = new SqlCommand("select*from SINHVIEN");
            DataTable dt = new DataTable();
            dt=KNCSDL.DOCDULIEU(cmd);
            return dt;              
        }
        public static DataTable MaSVLonNhat()
        {
            SqlCommand cmd = new SqlCommand("select top 1 MaSV from SINHVIEN order by MaSV desc");
            DataTable dt = new DataTable();
            dt = KNCSDL.DOCDULIEU(cmd);
            return dt;
                
        }


        public static void Them_Sinhvien(SinhVienDTO sv)
        {
            string sql = @"INSERT INTO SINHVIEN
                          (MaSV, HoTen, Phai, NgaySinh, NoiSinh, MaLop)
                          VALUES
                          (@MaSV, @HoTen, @Phai, @NgaySinh, @NoiSinh, @MaLop)";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10).Value = sv.masv;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50).Value = sv.tensv;
            cmd.Parameters.Add("@Phai", SqlDbType.Bit).Value = sv.phai;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value =
                DateTime.Parse(sv.ngaysinh);
            cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar, 50).Value = sv.noisinh;
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10).Value = sv.malop;

            KNCSDL.ThucThiTruyVan(cmd);
        }
        public static void Xoa_Sinhvien(SinhVienDTO sv)
        {
            string sql = "Delete from SINHVIEN where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10).Value = sv.masv;

            KNCSDL.ThucThiTruyVan(cmd);
        }
        public static void CapNhat_SinhVien(SinhVienDTO sv)
        {
            string sql = @"Update SINHVIEN
                           set HoTen = @HoTen,
                               Phai = @Phai,
                               NgaySinh = @NgaySinh,
                               NoiSinh = @NoiSinh,
                               MaLop = @MaLop
                           where MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar, 10).Value = sv.masv;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50).Value = sv.tensv;
            cmd.Parameters.Add("@Phai", SqlDbType.Bit).Value = sv.phai;
            cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value =
                DateTime.Parse(sv.ngaysinh);
            cmd.Parameters.Add("@NoiSinh", SqlDbType.NVarChar, 50).Value = sv.noisinh;
            cmd.Parameters.Add("@MaLop", SqlDbType.NVarChar, 10).Value = sv.malop;

            KNCSDL.ThucThiTruyVan(cmd);
        }

    }
}
