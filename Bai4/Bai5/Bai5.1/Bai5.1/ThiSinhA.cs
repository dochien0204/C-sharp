using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5._1
{
    internal class ThiSinhA
    {
        public string sbd { get; set; }
        public string hoTen { get; set; }
        public string diaChi { get; set; }

        public double toan { get; set; }
        public double ly { get; set; }
        public double hoa { get; set; }

        public double tongDiem{get; set; }

        public void nhap()
        {
            Console.Write("SBD = "); sbd = Console.ReadLine();
            Console.Write("Họ Tên = "); hoTen = Console.ReadLine();
            Console.Write("Địa chỉ = ");    diaChi = Console.ReadLine();
            Console.Write("Toán = ");       toan = double.Parse(Console.ReadLine());
            Console.Write("Lý = "); ly = double.Parse(Console.ReadLine());
            Console.Write("Hóa = "); hoa = double.Parse(Console.ReadLine());
            tongDiem = toan + ly + hoa;
        }

        public void xuat()
        {
            Console.Write("SBD : " + sbd);
            Console.Write("\tHọ Tên : " + hoTen);
            Console.Write("\t\tĐịa chỉ : " + diaChi);
            Console.Write("\tToán : " + toan);
            Console.Write("\tLý : " + ly);
            Console.WriteLine("\tHóa : " + hoa);
        }
    }
}
