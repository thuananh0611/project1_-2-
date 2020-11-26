using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTMV.Presentation;
using QLTMV.Utility;
namespace QLTMV
{
    class Program
    {
        static void Main(string[] args)
        {
            DangNhap dn = new DangNhap();
            bool ok = dn.Hien(10, 5, "1", "1");
            if (ok)
            {
                Hien();
            }
            else Environment.Exit(0);

        }
        public static void Hien()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Quan ly TMV");
                Console.WriteLine("1. Quan ly ....");
                Console.WriteLine("2. Quan ly khach hang");
                Console.WriteLine("3. Quan ly ....");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon: ");
                String s = Console.ReadLine();

                switch (s)
                {
                    case "1":
                        Console.WriteLine("Chức năng chưa được hoàn thiện...!");
                        break;
                    case "2":
                        K_HangPresentation khachhang = new K_HangPresentation();
                        khachhang.HienMenu();
                        break;
                    case "3":
                        Console.WriteLine("Chức năng chưa được hoàn thiện...!");

                        break;
                    case "4":
                        end = true;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
