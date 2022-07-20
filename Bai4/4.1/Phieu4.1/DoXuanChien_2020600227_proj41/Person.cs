using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoXuanChien_2020600227_proj41
{
    internal class Person
    {
        private string id { get; set; }
        private string name { get; set; }
        public int age { get; set; }
        private string email { get; set; }
        private string address { get; set; }

        public Person ()
        {

        }

        public Person(string id, string name, int age, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.email = email;
            this.address = address;
        }

        public void nhap()
        {
            Console.Write("Id: "); Console.ReadLine();
            Console.Write("Name: "); name = Console.ReadLine();
            Console.Write("Age: "); age = int.Parse(Console.ReadLine());
            Console.Write("Email: "); email = Console.ReadLine();
            Console.Write("Address: "); address = Console.ReadLine();
        }

        public void xuat()
        {
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Email : " + email);
            Console.WriteLine("Adress : " + address);
        }

        public void checkAge(int age)
        {
            
            if (age >= 18)
                Console.WriteLine("Bạn đủ tuổi bầu cử");
            else
            {
                Console.WriteLine("Bạn còn nhỏ");
            }
        }
    }
}
