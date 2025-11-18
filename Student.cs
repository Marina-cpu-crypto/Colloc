using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Colloc
{
    internal class Student
    {
        private string[] names = { "A", "B", "C", "D", "E", "F", "G"};
        public int firstName=0;
        public string FIO { get; set; }
        public int grade { get; set; }//класс
        public double performance { get; set; }//средняя успеваемость
        public Educationlevel stage { get; set; }//уровень образования
        Random rnd = new Random();
        public enum Educationlevel
        {
            elementary,
            secondary,
            higher
        }
        public Student()
        {
            FIO = names[firstName];
            firstName=firstName++;
            grade = rnd.Next(1, 12);
            performance = rnd.Next(5);
            if (grade < 5) stage = Educationlevel.elementary;
            else
            {
                if (grade < 8) stage = Educationlevel.secondary;
                else stage = Educationlevel.higher;
            }
        }
        public Student(string name, int grade, double performance)
        {
            FIO = name;
            this.grade = grade;
            this.performance = performance;
        }
        public void Pass()
        {
            grade++;
            if (grade < 5) stage = Educationlevel.elementary;
            else
            {
                if (grade < 8) stage = Educationlevel.secondary;
                else stage = Educationlevel.higher;
            }
        }
        public override string ToString()
        {
            return $"{FIO}, {stage} школа, {grade} класс, {performance} балла";
        }
    }
}
