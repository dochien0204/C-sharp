namespace Bai5._1
{
    internal class Program
    {
        static List<ThiSinhA> thiSinhAs = new List<ThiSinhA>();
        static void Main(string[] args)
        {
            int luaChon =2;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("1. Nhập thông tin 1 thí sinh");
            Console.WriteLine("2. Hiển thị danh sách các thí sinh");
            Console.WriteLine("3. Hiển thị các sinh viên theo tổng điểm");
            Console.WriteLine("4. Hiển thị các sinh viên theo địa chỉ");
            Console.WriteLine("5. Tìm kiếm theo số báo danh");
            Console.WriteLine("6. Kết thúc chương trình");
            while (luaChon > 0 && luaChon <6)
            {

                do
                {
                    Console.WriteLine("Nhập lựa chọn của bạn :");
                    luaChon = int.Parse(Console.ReadLine());
                    if (luaChon <= 0 || luaChon > 6)
                        Console.WriteLine("Lựa chọn không hợp lệ ! ");
                    if (luaChon == 6)
                        Console.WriteLine("Bạn chọn thoát chương trình");

                }
                while (luaChon <= 0 || luaChon > 6);
                switch (luaChon)
            {
                case 1:
                    {
                        ThiSinhA thiSinhA = new ThiSinhA();
                        thiSinhA.nhap();
                        thiSinhAs.Add(thiSinhA);
                        break;
                    }
                case 2:
                    {
                        foreach(ThiSinhA thiSinhA in thiSinhAs)
                        {
                            thiSinhA.xuat();
                        }    
                        break;
                    }
                case 3:
                    {
                        Console.Write("Nhập vào Tổng điểm : ");
                        double tongDiem = double.Parse(Console.ReadLine()); 
                        foreach(ThiSinhA thiSinhA in thiSinhAs)
                        {
                            if (thiSinhA.tongDiem == tongDiem)
                                thiSinhA.xuat();
                        }    
                        break;
                    }
                case 4:
                    {
                        Console.Write("Nhập vào địa chỉ : ");
                        string diaChi = Console.ReadLine();
                        foreach(ThiSinhA thiSinhA in thiSinhAs)
                        {
                            if (thiSinhA.diaChi.CompareTo(diaChi) == 0)
                                thiSinhA.xuat();
                        }    
                        break;
                    }
                case 5:
                    {
                        Console.Write("Nhập vào SBD : ");
                        string sbd = Console.ReadLine();
                        foreach(ThiSinhA thiSinhA in thiSinhAs)
                        {
                            if (thiSinhA.sbd.CompareTo(sbd) == 0)
                                thiSinhA.xuat();
                        }
                        break;
                    } 
                        
            }    
            }    
           

        }
    }
}