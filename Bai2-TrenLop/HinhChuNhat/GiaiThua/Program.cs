namespace GiaiThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "! = " + giaiThua(n));
        }

        static int giaiThua(int n)
        {
            if (n <= 0)
                return -1;
            else
            {
                if (n == 1)
                    return 1;
                else
                    return n * giaiThua(n - 1);
            } 
        }
    }
}