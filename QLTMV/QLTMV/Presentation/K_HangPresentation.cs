using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTMV.BUS;

namespace QLTMV.Presentation
{
    class K_HangPresentation
    {
        private K_HangBUS K_HangBUS = new K_HangBUS();

        public void HienMenu()
        {
            bool end = false;
            while (!end)
            {
                Console.Clear(); //xóa màn hình

                Console.WriteLine("Quan ly khach hang");
                Console.WriteLine("1. Hien danh sach khach hang");
                Console.WriteLine("2. Them khach hang");
                Console.WriteLine("3. Sua khach hang");
                Console.WriteLine("4. Xoa khach hang");
                Console.WriteLine("5. Quay lai");
                Console.Write("Chon: ");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1": HienKhachHang(); Console.ReadKey(); break;
                    case "2": ThemKhachHang(); Console.ReadKey(); break;
                    case "3": SuaKhachHang(); Console.ReadKey(); break;
                    case "4": XoaKhachHang(); Console.ReadKey(); break;
                    case "5": end = true; break;
                }
            }
        }

        public void HienKhachHang()
        {
            Console.WriteLine("Danh sach cac khach hang");
            Console.WriteLine("Mã kh\t\t\tTên kh\t\t\tĐịa chỉ\t\t\tNgày sinh\t\t\tSố điện thoại");
            foreach (String s in K_HangBUS.LayDanhSach())
            {
                Console.WriteLine(s);
            }

        }

        public void ThemKhachHang()
        {
            Console.WriteLine("Nhap thong tin cho khach hang:");
            Console.Write("Ma khach hang: ");
            string ma = Console.ReadLine();
            Console.Write("Ten khach hang: ");
            string ten = Console.ReadLine();
            Console.Write("Dia chi khach hang: ");
            string dc = Console.ReadLine();
            Console.Write("Ngay sinh khach hang: ");
            string ns = Console.ReadLine();
            Console.Write("So dien thoai khach hang: ");
            string dt = Console.ReadLine();

            K_HangBUS.Them(ma, ten, dc, ns, dt);
            Console.WriteLine("Da them danh muc!");
        }

        public void SuaKhachHang()
        {
            Console.Write("Nhap ma khach hang can sua: ");
            string ma = Console.ReadLine();
            Console.Write("Nhap ten khach hang moi: ");
            string ten = Console.ReadLine();
            Console.Write("Dia chi khach hang moi: ");
            string dc = Console.ReadLine();
            Console.Write("Ngay sinh khach hang moi: ");
            string ns = Console.ReadLine();
            Console.Write("So dien thoai khach hang moi: ");
            string dt = Console.ReadLine();
            K_HangBUS.Sua(ma, ten, dc, ns, dt);
            Console.WriteLine("Da sua danh muc!");
        }

        public void XoaKhachHang()
        {
            Console.Write("Nhap ma khach hang can xoa: ");
            string ma = Console.ReadLine();

            K_HangBUS.Xoa(ma);
            Console.WriteLine("Da xoa danh muc!");
        }
    }
}
