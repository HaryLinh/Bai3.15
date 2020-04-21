using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int SoGiaoVien = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();
            for(int i = 0; i < SoGiaoVien; i++)
            {
                Console.Write("Nhap ten giao vien:");
                string hoTen = Console.ReadLine();
                Console.WriteLine("\nNhap gioi tinh:");
                string gioiTinh = Console.ReadLine();
                Console.WriteLine("\nNhap nam sinh:");
                int namSinh = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNhap dia chi:");
                string diaChi = Console.ReadLine();
                Console.WriteLine("\nNhap so gio giang:");
                int soGioGiang = int.Parse(Console.ReadLine());
                Person person = new GiaoVien(hoTen, gioiTinh, namSinh, diaChi, soGioGiang);
                list.Add(person);
            }

           
            Console.WriteLine("Thong tin danh sach giao vien:");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", "Hoten", "GioiTinh", "DiaChi", "NamSinh",  "SoGioGiang");

            foreach (GiaoVien giaoVien in list)
            {
                Console.WriteLine(giaoVien.ToString());
            }
            Console.ReadLine();
        }
    }
}
