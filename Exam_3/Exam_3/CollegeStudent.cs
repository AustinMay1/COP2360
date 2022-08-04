using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    internal class CollegeStudent: Student, IMathClass
    {
        public CollegeStudent(string first, string last, string id) : base(first, last, id)
        {

        }

        public override string ImportantThing()
        {
            return "Major.";
        }

        public string Math()
        {
            return "Advanced Algebra";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + " I am a College Student. I have a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
