namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            List<String> thanhPho = new List<String>();
            add(ref thanhPho);
            Console.WriteLine("Danh sách các thành phố như sau : ");
            showCity(thanhPho);
            Console.Write("Nhập tên thành phố muốn xóa : ");
            String nameCity = Console.ReadLine();
            removeCity(ref thanhPho, nameCity);
            Console.WriteLine("Danh sách các thành phố sau khi xóa : ");
            showCity(thanhPho);
        }

        static void showCity(List<String> thanhPho)
        {
            thanhPho.ForEach(city =>
            {
                Console.WriteLine(city);
            });
        }

        static void add(ref List<String> thanhPho)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Nhập tên thành phố thứ : " + i);
                thanhPho.Add(Console.ReadLine());
            }    
        }

        static void removeCity(ref List<String> thanhPho, String nameCity)
        {
            for(int i = 0; i < thanhPho.Count; i++)
            {
                if (thanhPho[i].CompareTo(nameCity) == 0)
                {
                    thanhPho.RemoveAt(i);
                }
            }    
        }
    }
}