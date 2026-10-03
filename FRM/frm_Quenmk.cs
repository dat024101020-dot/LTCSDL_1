using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_1.DAO;
using System.Data.SqlClient;
namespace LTCSDL_1.FRM
{
    public partial class frm_Quenmk : Form
    {
        public frm_Quenmk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string taiKhoan = txtTaikhoan.Text.Trim();
                string matKhauMoi = txtMkmoi.Text;
                string xacNhan = txtXacnhan.Text;

                // Kiểm tra bỏ trống
                if (taiKhoan == "")
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!");
                    txtTaikhoan.Focus();
                    return;
                }

                if (matKhauMoi == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới!");
                    txtMkmoi.Focus();
                    return;
                }

                if (xacNhan == "")
                {
                    MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                    txtXacnhan.Focus();
                    return;
                }

                // Kiểm tra mật khẩu
                if (matKhauMoi != xacNhan)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                    txtXacnhan.Focus();
                    return;
                }

                // Kiểm tra tài khoản có tồn tại không
                string sqlKT = "SELECT COUNT(*) FROM TAIKHOAN " +
                               "WHERE TenDangNhap = @TenDangNhap";

                SqlCommand cmdKT = new SqlCommand(sqlKT);

                cmdKT.Parameters.AddWithValue("@TenDangNhap", taiKhoan);

                DataTable dt = KNCSDL.DOCDULIEU(cmdKT);

                int soLuong = Convert.ToInt32(dt.Rows[0][0]);

                if (soLuong == 0)
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                    return;
                }

                // Cập nhật mật khẩu
                string sql = "UPDATE TAIKHOAN " +
                             "SET MatKhau = @MatKhauMoi " +
                             "WHERE TenDangNhap = @TenDangNhap";

                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                cmd.Parameters.AddWithValue("@TenDangNhap", taiKhoan);

                KNCSDL.ThucThiTruyVan(cmd);

                MessageBox.Show("Đổi mật khẩu thành công!");

                txtTaikhoan.Clear();
                txtMkmoi.Clear();
                txtXacnhan.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void frm_Quenmk_Load(object sender, EventArgs e)
        {

        }
    }
}
