using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace QLTMV.DAL
{
    class K_HangDAL
    {
        private static String FILE_NAME = "Data/K_Hang.txt"; //File text lưu thông tin các danh mục

        public List<String> LayDanhSach()
        {
            StreamReader sr = new StreamReader(FILE_NAME);
            String s;
            List<String> ds = new List<string>();
            while ((s = sr.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(s))
                    continue;

                String[] tmp = s.Split('#'); //tách thông tin từng dòng

                String kq = tmp[0] + "\t" + tmp[1] + "\t\t" + tmp[2] + "\t" + tmp[3] + "" +
                    "\t" + tmp[4];
                ds.Add(kq); //thêm vào list kết quả

            }

            sr.Close();

            return ds;
        }

        public void Them(string MaKH, string TenKH, string Diachi, string Ngaysinh, string Sdt)
        {
            StreamWriter sw = new StreamWriter(FILE_NAME, true);

            sw.WriteLine(MaKH + "#" + TenKH + "#" + Diachi + "#" + Ngaysinh + "#" + Sdt);

            sw.Close();
        }

        public void Sua(string MaKH, string TenKH, string Diachi, string Ngaysinh, string Sdt)
        {
            //ý tưởng của sửa: 
            /* ta đọc qua các dòng trong file
             * nếu gặp dòng nào có mã như vậy ta sẽ cập nhật lại thông tin mới
             * và ghi lại toàn bộ file
             */
            String kq = "";
            String s;
            StreamReader sr = new StreamReader(FILE_NAME);

            while ((s = sr.ReadLine()) != null)
            {
                String[] tmp = s.Split('#');

                if (tmp[0] != MaKH)
                {
                    kq += s + "\n";
                }
                else
                {
                    //cập nhật nếu đúng mã cần sửa
                    kq += MaKH + "#" + TenKH + "#" + Diachi + "#" + Ngaysinh + "#" + Sdt + "\n";
                }
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FILE_NAME);

            sw.Write(kq);

            sw.Close();
        }

        public void Xoa(string MaKH)
        {
            //ý tưởng của xóa: 
            /* ta đọc qua các dòng trong file
             * nếu gặp dòng nào có mã như vậy ta sẽ bỏ qua
             * và ghi lại toàn bộ file
             */
            String kq = "";
            String s;
            StreamReader sr = new StreamReader(FILE_NAME);

            while ((s = sr.ReadLine()) != null)
            {
                String[] tmp = s.Split('|');

                if (tmp[0] != MaKH)
                {
                    kq += s + "\n";
                }
            }

            sr.Close();

            StreamWriter sw = new StreamWriter(FILE_NAME);

            sw.Write(kq);

            sw.Close();
        }

    }
}
