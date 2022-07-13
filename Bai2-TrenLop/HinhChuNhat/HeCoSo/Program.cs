namespace HeCoSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số " + n + " được chuyển sang số nhị phân là : " + Convert.ToString(n,2));
            int check = 0, s;
            do
            {
                check = 0;
                Console.Write("Nhập số nhị phân cần chuyển : ");
                s = Convert.ToInt32(Console.ReadLine());
                char[] a = s.ToString().ToCharArray();
                for(int i = 0; i < a.Length; i++)
                {
                    if (a[i] != '1' && a[i] != '0')
                    {
                        check = 1;
                    }        
                }
                if (check == 1)
                    Console.WriteLine("Nhập số nhị phân không đúng ! Nhập lại");
            }
            while (check != 0);
            
            Console.WriteLine(s + " được chuyển sang cơ số 10 là : " + convertBinaryToDecimal(s));
        }

        static int convertBinaryToDecimal(int s)
        {
            int dec = 0,mod, index = s.ToString().Length - 1;
            while(s > 0)
            {
                mod = s % 10;
                dec += mod * (int)Math.Pow(2, index);
                s /= 10;
                index--;
            }    
            return dec;
        }
        
    }
}