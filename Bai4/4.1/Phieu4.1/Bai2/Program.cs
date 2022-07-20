namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Circle circle = new Circle();

            Console.WriteLine("Nhập bán kính hình tròn : ");
            circle.radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình tròn là : " + circle.Area());
            Console.WriteLine("Chu vi hình tròn là : " + circle.Perimeter());
        }
    }
}