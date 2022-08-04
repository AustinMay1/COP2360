using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    internal class MiddleSchoolStudent : Student, IMathClass
    {
        public MiddleSchoolStudent(string first, string last, string id) : base(first, last, id)
        {

        }

        public override string ImportantThing()
        {
            return "Summer Camp!";
        }

        public string Math()
        {
            return "Geometry";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + " I am a Middle School Student. I have a " + this.ImportantThing() + "I am learning " + this.Math();
        }
    }
}
