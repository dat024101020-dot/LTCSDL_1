using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTCSDL_1.BUS;
using LTCSDL_1.DAO;
using LTCSDL_1.DTO;
namespace LTCSDL_1
{
    public partial class frm_Trangchu : Form
    {
        public frm_Trangchu()
        {
            InitializeComponent();
        }
        public void DanhSachSinhVien()
        {
            DataTable dt=new DataTable();
            dt=SinhvienDAO.ThongTinSinhVien();
            dgDanhsach.DataSource = dt;
        }
        public void DanhSachLop()
        {
            DataTable dt = new DataTable();
            dt = LopDao.ThongTinLop();
            cboLophoc.DataSource = dt;
            cboLophoc.ValueMember = "MaLop";
            cboLophoc.DisplayMember = "TenLop";
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DanhSachSinhVien();
            DanhSachLop();
      
        }

        private void dgDanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasv.Text = dgDanhsach.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgDanhsach.CurrentRow.Cells[1].Value.ToString();
            if (dgDanhsach.CurrentRow.Cells[2].Value.ToString() == "True")
                radNam.Checked = true;
            else radNu.Checked = true;
            dtNgaysinh.Text = dgDanhsach.CurrentRow.Cells[3].Value.ToString();
            txtNoisinh.Text = dgDanhsach.CurrentRow.Cells[4].Value.ToString();
            cboLophoc.SelectedValue = dgDanhsach.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SinhvienDAO.MaSVLonNhat();
            string masv = dt.Rows[0][0].ToString();
            txtMasv.Text="022101"+(int.Parse(masv.Substring(6,masv.Length-6))+1).ToString("000");
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SinhVienDTO SV=new SinhVienDTO();
            SV.masv = txtMasv.Text;
            SV.tensv = txtHoten.Text;
            SV.ngaysinh = dtNgaysinh.Value.ToString("MM/dd/yyyy");
            if (radNam.Checked == true)
                SV.phai = "1";
            else SV.phai = "0";
            SV.noisinh=txtNoisinh.Text;
            SV.malop = cboLophoc.SelectedValue.ToString();
            SinhVienBUS.Them_SinhVien(SV);
            DanhSachSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv=new SinhVienDTO();
            sv.masv = txtMasv.Text;
            SinhVienBUS.Xoa_SinhVien(sv);
            DanhSachSinhVien();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.masv=txtMasv.Text;
            sv.tensv=txtHoten.Text;
            sv.ngaysinh = dtNgaysinh.Value.ToString("yyyy-MM-dd");
            if(radNam.Checked==true)
                sv.phai="1";
            else sv.phai = "0";
            sv.noisinh=txtNoisinh.Text;
            sv.malop = cboLophoc.SelectedValue.ToString();
            SinhVienBUS.Capnhat_SinhVien(sv);
            DanhSachSinhVien();
        }

        private void btnXemdiem_Click(object sender, EventArgs e)
        {
            if (txtMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên!");
                return;
            }

            frm_BangDiem f = new frm_BangDiem(txtMasv.Text);
            f.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frm_dangnhap f = new frm_dangnhap();
            f.Show();
            this.Hide();
        }
    }
}
