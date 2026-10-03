using LTCSDL_1.DAO;
using LTCSDL_1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTCSDL_1.BUS
{
    internal class SinhVienBUS
    {
        public static void Them_SinhVien(SinhVienDTO sv)
        {
            try
            {
                SinhvienDAO.Them_Sinhvien(sv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm sinh viên không thành công!");
            }
        }
        public static void Xoa_SinhVien(SinhVienDTO sv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên ban này?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SinhvienDAO.Xoa_Sinhvien(sv);
                }
                catch (Exception)
                {
                    MessageBox.Show("xóa sinh viên không thành công!");
                }
            }

        }
        public static void Capnhat_SinhVien(SinhVienDTO sv)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật sinh viên ban này?", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SinhvienDAO.CapNhat_SinhVien(sv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}