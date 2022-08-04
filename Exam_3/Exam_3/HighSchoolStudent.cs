using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    internal class HighSchoolStudent : Student , IMathClass
    {
        public HighSchoolStudent(string first, string last, string id) : base(first, last, id)
        {

        }

        public override string ImportantThing()
        {
            return "SAT exam.";
        }

        public string Math()
        {
            return "Basic Algebra";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + " I am a High School Student. I have a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
