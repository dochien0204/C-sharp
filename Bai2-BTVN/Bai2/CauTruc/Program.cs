namespace CauTruc
{
    internal class Program
    {
        struct HocSinh {
            public String hoTen;
            public int tuoi;
            public bool gioiTinh;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            HocSinh[] hocSinh = new HocSinh[5];
            for(int i = 0; i < hocSinh.Length; i++)
            {
                Console.WriteLine("Nhập thông tin học sinh thứ " + (i + 1) + " : ");
                Console.Write("Nhập họ tên : ");
                hocSinh[i].hoTen = Console.ReadLine();
                Console.WriteLine("Nhập tuổi : ");
                hocSinh[i].tuoi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập giới tính : ");
                String gioiTinh = Console.ReadLine().Trim().ToUpper();
                if (gioiTinh.CompareTo("NAM") == 0)
                    hocSinh[i].gioiTinh = true;
                else
                    hocSinh[i].gioiTinh = false;
               
            }
            int sum = 0;
            for (int i = 0; i < hocSinh.Length; i++)
                sum += hocSinh[i].tuoi;
            Console.WriteLine("Tổng tuổi của các em học sinh là : " + sum);
        }
    }
}