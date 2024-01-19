using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public SanPham()
        {
            
        }

        public SanPham(int maSP, string tenSP, double donGia, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public void In()
        {
            Console.WriteLine("Ma SP: " + this.MaSP);
            Console.WriteLine("Ten SP: " + this.TenSP);
            Console.WriteLine("Don Gia: " + this.DonGia);
            Console.WriteLine("So Luong: " + this.SoLuong);
            Console.WriteLine("Thanh Tien: " + ThanhTien());
        }
    }
}
