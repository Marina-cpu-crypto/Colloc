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
    }
}
