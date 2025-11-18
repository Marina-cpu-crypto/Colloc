using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloc
{
    internal class Ministry
    {
        List<School> schools=new List<School>();
        //delegate List<Student> FilterHonors(List<School> schools);
        public List<Student> FilterHonors()
        {
            List < Student > result = new List<Student>();
            foreach (var school in schools)
            {
                List<Student> list = school.listStudents;
                foreach (var student in list)
                {
                    if(student != null)
                    {
                        if (student.performance==5) result.Add(student);
                    }
                }
            }
            return result;
        }
        public List<School> FilterLoser()
        {
            List<School> result = new List<School>();
            foreach (var school in schools)
            {
                List<Student> list = school.listStudents;
                foreach (var student in list)
                {
                    if (student != null)
                    {
                        if (student.performance == 5) result.Add(school);
                    }
                }
            }
            return result;
        }
    }
}
