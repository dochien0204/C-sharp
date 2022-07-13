namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chiều dài hình chữ nhật : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Nhập chiều rộng hình chữ nhật : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            hinhChuNhat(a, b);
        }

        static void hinhChuNhat(double a, double b)
        {
            Console.WriteLine("Chu vi hình chữ nhật là : " + (a + b) * 2);
            Console.WriteLine("Diện tích hình chữ nhật là : " + a * b);
        }
    }
}