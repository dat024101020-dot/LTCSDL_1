using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace LTCSDL_1.DTO
{
    internal class SinhVienDTO
    {
        private string _masv;
        private string _tensv;
        private string _phai;
        private string _ngaysinh;
        private string _diachi;
        private string _malop;
        private string _Noisinh;
        public string _taikhoan;
        public string _matkhau;
        public string masv {get;set;}
        public string tensv {get;set;}
        public string phai { get;set;}
        public string ngaysinh {get;set;}
        public string diachi {get;set;} 
        public string malop {get;set;}
        public string noisinh {get;set;}
        public string taikhoan {get;set;}
        public string matkhau { get;set;}
        public SinhVienDTO()
        {
            _masv = " ";
            _tensv = " ";
            _phai = " ";
            _ngaysinh = " ";
            _diachi = " ";
            _malop=" ";
            _Noisinh = " ";
            _taikhoan = "";
            _matkhau= " ";
        }
        public SinhVienDTO(string MaSV,string TenSV,string Phai,string NgaySinh,string DiaChi,string MaLop,string taikhoan,string matkhau)
        {
            _masv = MaSV;
            _tensv = TenSV;
            _phai = Phai;
            _ngaysinh = NgaySinh;
            _diachi = DiaChi;
            _malop = MaLop;
            _taikhoan = taikhoan;
            _matkhau=matkhau;
        }
    }
}
