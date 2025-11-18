using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloc
{
    internal class Program
    {
        public int firstName = 0;
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student1 = new Student();
            Console.WriteLine(student.FIO);
            Console.WriteLine(student1.FIO);
        }
    }
}
