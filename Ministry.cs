using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colloc
{
    internal class Ministry
    {
        List<School> schools = new List<School>();
        //delegate List<Student> FilterHonors(List<School> schools);
        public List<Student> FilterHonors()
        {
            List<Student> result = new List<Student>();

            foreach (var school in schools)
                result.Add(school.Analize(school.listStudents, x => x.performance == 5));

            return result;
        }
        public List<School> FilterLoser()
        {
            List<School> result = new List<School>();

            foreach (var school in schools)
                if (school.Analize(school.listStudents, x => x.performance < 3) != null)
                    result.Add(school);

            return result;
        }

    }
}
