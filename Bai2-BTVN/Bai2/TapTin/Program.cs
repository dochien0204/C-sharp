namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\Test\TapTin.txt";
            String[] a = File.ReadAllLines(path);
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            int sum = 0;
            for(int i = 2; i < a.Length; i++)
            {
                string[] num = a[i].Split(" ");
                for(int j = 0; j < num.Length; i++)
                {
                    sum += Convert.ToInt32(num[j]);
                }    
            }
            String s = "Tổng các phần tử trong ma trận là : " + sum + "\n";
            Console.WriteLine(s);
            File.AppendAllText(path,s);
        }
    }
}