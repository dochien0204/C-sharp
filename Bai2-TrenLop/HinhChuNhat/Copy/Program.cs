namespace Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string sourceFile = @"C:\source\source.txt";
            string targetFile = @"D:\target\target.txt";

            try
            {
                File.Delete(targetFile);

                File.Copy(sourceFile, targetFile);

                Console.WriteLine("Copy thành công !");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.WriteLine("Nhấn Enter để tiếp tục");
            Console.Read();
        }
    }
}