using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Interface
{
    public class Student
    {
        private static int _counter = 1;
        public int Id { get; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public Student(string fullname, double point)
        {
            Id = _counter++;
            Fullname = fullname;
            Point = point;
        }

        public void StudentIhfo()
        {
            Console.WriteLine($"{Id},{Fullname},{Point}");
        }
    }
}
