namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập n : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (n < 0) Console.WriteLine("Nhập n không hợp lệ ! Nhập lại !");
            }
            while(n < 0);
            Console.WriteLine("Số fibonacci thứ " + n + " là : " + fibonacci(n - 1));
            Console.WriteLine("Dãy " + n + " số Fibonacci là : ");
            for(int i = 0; i < n; i++)
                Console.Write(fibonacci(i) + " ");
        }

        static int fibonacci(int n)
        {
            if (n < 0)
                return -1;
            else
            {
                if (n == 0 || n == 1)
                    return n;
                else
                    return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}