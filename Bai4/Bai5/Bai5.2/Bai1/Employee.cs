using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int workingdays { get; set; }
        public double salary { get; set; }

        public const int PRICE = 50;
        
        public Employee()
        {

        }

        public Employee(string id, string name, int age, int workingdays)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.workingdays = workingdays;
           
        }

        public void input()
        {
            Console.WriteLine("ID = ");     id = Console.ReadLine();
            Console.WriteLine("Name = ");   name = Console.ReadLine();
            Console.WriteLine("Age = ");    age = int.Parse(Console.ReadLine());
            Console.WriteLine("Workingdays = ");    workingdays = int.Parse(Console.ReadLine());    

        }

        public void output()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Workingdays : " + workingdays);
            Console.WriteLine("Salary : " + workingdays * PRICE);
        }
    }
}
