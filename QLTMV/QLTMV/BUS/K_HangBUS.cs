using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTMV.DAL; //sử dụng thành phần DAL

namespace QLTMV.BUS
{
    class K_HangBUS
    {
        private K_HangDAL khachhangDAL = new K_HangDAL();

        public void Them(string makhachhang, string tenkhachhang, string diachi, string ngaysinh, string sdt)
        {
            khachhangDAL.Them(makhachhang, tenkhachhang, diachi, ngaysinh, sdt);
        }

        public void Sua(string makhachhang, string tenkhachhang, string diachi, string ngaysinh, string sdt)
        {
            khachhangDAL.Sua(makhachhang, tenkhachhang, diachi, ngaysinh, sdt);
        }

        public void Xoa(string makhachhang)
        {
            khachhangDAL.Xoa(makhachhang);
        }

        public List<String> LayDanhSach()
        {
            return khachhangDAL.LayDanhSach();
        }
    }
}
