using LTCSDL_1.BUS;
using LTCSDL_1.DAO;
using LTCSDL_1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_1.FRM;

namespace LTCSDL_1
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaikhoan.Text.Trim();
            string matKhau = txtMatkhau.Text;

            if (taiKhoan == "" || matKhau == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (TaikhoanDAO.DangNhap(taiKhoan, matKhau))
            {
                MessageBox.Show("Đăng nhập thành công!");

                frm_Trangchu f = new frm_Trangchu();
                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnQmk_Click(object sender, EventArgs e)
        {
           frm_Quenmk f = new frm_Quenmk();

            f.ShowDialog();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
