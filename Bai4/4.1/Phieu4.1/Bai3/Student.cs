using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Student
    {
        public string id { get; set; }

        public string name { get; set; }

        public int mark { get; set; }

        public int scholarship {
            get; set;
        }

        public Student()
        {
          
        }    

        
        public Student(string id, string name, int mark, int scholarship)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.scholarship = scholarship;
        }

        public Student(string id )
        {
            this.id = id;
        }

        public void nhap()
        {
            Console.Write("Id = ");     id = Console.ReadLine();
            Console.Write("Name = ");   name = Console.ReadLine();
            Console.Write("Mark = ");   mark = int.Parse(Console.ReadLine());
            scholarship = checkScholarship();
            
        }

        public void xuat()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Mark : " + mark);
            Console.WriteLine("Scholarship : " + scholarship);
        }

        public int checkScholarship()
        {
            if (mark > 8)
                scholarship = 500;
            else if (mark >= 7 && mark <= 8)
                scholarship = 300;
            else
                scholarship = 0;
            return scholarship;
        }

    }
}
