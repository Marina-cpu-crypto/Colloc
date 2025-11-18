using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloc
{
    internal class School
    {
        public string Name {  get; set; }
        public List<Student> listStudents = new List<Student>();
        public void initializationSchool(string name)
        {
            Name = name;
        }
        public void Add(Student student)
        {
            listStudents.Add(student);
        }
        public override string ToString()
        {
            for(int i=0;i<listStudents.Count;i++)
            {
                return i+". "+listStudents[i].ToString();
            }
            return null;
        }
        public List<Student> Analize()
        {
            List<Student> result = new List<Student>();
            foreach (var student in listStudents)
            {
                if (student != null)
                {
                    if (student.performance == 5) result.Add(student);
                }
            }
            return result;
        }
        public List<School> Analize1()
        {
            List<School> result = new List<School>();
            foreach (var student in listStudents)
            {
                if (student != null)
                {
                    if (student.performance <3) result.Add(this);
                }
            }
            return result;
        }
    }
}
