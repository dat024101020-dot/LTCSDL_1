using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using LTCSDL_1.DAO;


namespace LTCSDL_1
{
    public partial class frm_BangDiem : Form
    {
        string maSV;
        public frm_BangDiem(string maSV)
        {

            InitializeComponent();
            this.maSV = maSV;
        }

        private void frm_BangDiem_Load(object sender, EventArgs e)
        {
            LoadBangDiem();

            txtDiemCSDL.Enabled = false;
            txtDiemLT.Enabled = false;
            txtDiemCTDL.Enabled = false;
        }
        private void LoadBangDiem()
        {
            string sql = "SELECT " +
                "SINHVIEN.MaSV, " +
                "SINHVIEN.HoTen, " +
                "(SELECT Diem FROM DIEM WHERE MaSV = @MaSV AND MaMH = 'CSDL') AS DiemCSDL, " +
                "(SELECT Diem FROM DIEM WHERE MaSV = @MaSV AND MaMH = 'LT') AS DiemLT, " +
                "(SELECT Diem FROM DIEM WHERE MaSV = @MaSV AND MaMH = 'CTDL') AS DiemCTDL " +
                "FROM SINHVIEN " +
                "WHERE SINHVIEN.MaSV = @MaSV";

            SqlCommand cmd = new SqlCommand(sql);

            cmd.Parameters.AddWithValue("@MaSV", maSV);

            DataTable dt = KNCSDL.DOCDULIEU(cmd);

            dgBangdiem.DataSource = dt;
        }

        private void dgBangdiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDiemCSDL.Text = dgBangdiem.Rows[e.RowIndex].Cells["DiemCSDL"].Value.ToString();
                txtDiemLT.Text = dgBangdiem.Rows[e.RowIndex].Cells["DiemLT"].Value.ToString();
                txtDiemCTDL.Text = dgBangdiem.Rows[e.RowIndex].Cells["DiemCTDL"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtDiemCSDL.Enabled = true;
            txtDiemCTDL.Enabled = true;
            txtDiemLT.Enabled = true;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                decimal diemCSDL;

                if (!decimal.TryParse(txtDiemCSDL.Text, out diemCSDL))
                {
                    MessageBox.Show("Điểm CSDL phải là số!");
                    return;
                }

                decimal diemLT;

                if (!decimal.TryParse(txtDiemLT.Text, out diemLT))
                {
                    MessageBox.Show("Điểm LT phải là số!");
                    return;
                }

                decimal diemCTDL;

                if (!decimal.TryParse(txtDiemCTDL.Text, out diemCTDL))
                {
                    MessageBox.Show("Điểm CTDL phải là số!");
                    return;
                }

                if (diemCSDL < 0 || diemCSDL > 10 ||
                    diemLT < 0 || diemLT > 10 ||
                    diemCTDL < 0 || diemCTDL > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!");
                    return;
                }

                string sql = "UPDATE DIEM " +
                             "SET Diem = CASE " +
                             "WHEN MaMH = 'CSDL' THEN @DiemCSDL " +
                             "WHEN MaMH = 'LT' THEN @DiemLT " +
                             "WHEN MaMH = 'CTDL' THEN @DiemCTDL " +
                             "END " +
                             "WHERE MaSV = @MaSV " +
                             "AND MaMH IN ('CSDL', 'LT', 'CTDL')";

                SqlCommand cmd = new SqlCommand(sql);

                cmd.Parameters.AddWithValue("@DiemCSDL", diemCSDL);
                cmd.Parameters.AddWithValue("@DiemLT", diemLT);
                cmd.Parameters.AddWithValue("@DiemCTDL", diemCTDL);
                cmd.Parameters.AddWithValue("@MaSV", maSV);

                KNCSDL.ThucThiTruyVan(cmd);

                MessageBox.Show("Cập nhật điểm thành công!");

                LoadBangDiem();

                txtDiemCSDL.Enabled = false;
                txtDiemLT.Enabled = false;
                txtDiemCTDL.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công!\n" + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frm_Trangchu ftr = new frm_Trangchu();
            ftr.Show();
            this.Hide();

        }
    }
}
