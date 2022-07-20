namespace DoXuanChien_2020600227_proj41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Person person = new Person();
            Console.WriteLine("Nhập thông tin Person : ");
            person.nhap();
            Console.WriteLine("Thông tin người vừa nhập : ");
            person.xuat();
            person.checkAge(person.age);
        }
    }
}