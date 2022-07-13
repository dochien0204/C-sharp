namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào 1 chuỗi : ");
            String s = Console.ReadLine();
            phanA(s);
            Console.WriteLine("b) Chuỗi được chuẩn hóa : " + phanB(ref s));
        }

        static void phanA(String s)
        {
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
        }

        static String phanB(ref String s)
        {
            s = s.Trim();
            while (s.Contains("  "))
            {
                s = s.Remove(s.IndexOf("  "), 1);
            }
            return s;
        }
    }
}