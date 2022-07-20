namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Student student = new Student();
            student.nhap();
            student.xuat();
        }
    }
}