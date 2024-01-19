using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            for (int i = 1; i <= 3; i++)
            {
                SanPham sanPham = new SanPham();
                Console.Write($"Ma SP {i}: ");
                sanPham.MaSP = int.Parse(Console.ReadLine());
                Console.Write($"Ten SP {i}: ");
                sanPham.TenSP = Console.ReadLine();
                Console.Write($"Don Gia SP {i}: ");
                sanPham.DonGia = double.Parse(Console.ReadLine());
                Console.Write($"So Luong SP {i}: ");
                sanPham.SoLuong = int.Parse(Console.ReadLine());

                arrayList.Add(sanPham);
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------");

            foreach (SanPham sanPham in arrayList)
            {
                sanPham.In();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
