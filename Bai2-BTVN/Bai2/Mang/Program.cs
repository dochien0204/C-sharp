namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("Các phần tử của mảng được hiển thị như sau : ");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            mang(a, n);
        }

        static void mang(int[] a , int n)
        {
            int max = a[0], min = a[0], sum = 0;
            for(int i = 0; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
                sum += a[i];
            }
            Console.WriteLine();
            Console.WriteLine("Số lớn nhất trong mảng là : " + max);
            Console.WriteLine("Số nhỏ nhất trong mảng là : " + min);
            Console.WriteLine("Tổng các phần tử trong mảng là : " + sum);
        }
    }
}