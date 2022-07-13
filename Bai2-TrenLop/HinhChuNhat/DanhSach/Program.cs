namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a;
            a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ " + (i + 1) + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mảng đã nhập được hiển thị như sau : ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            danhSach(a, n);

        }

        static void danhSach(int[] a, int n)
        {
            Console.WriteLine("Danh sách số chẵn trong dãy là : ");
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Danh sách các số lẻ là : ");
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0) Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Danh sách các số nguyên tố là : ");
            for(int i = 0; i < n; i++)
            {
                if (a[i] <= 1)
                    continue;
                else
                {
                    if (a[i] == 2)
                        Console.Write(a[i] + " ");
                    else
                    {
                        if (a[i] % 2 != 0)
                            Console.Write(a[i] + " ");
                    }
                }
            }    
        }
    }
}