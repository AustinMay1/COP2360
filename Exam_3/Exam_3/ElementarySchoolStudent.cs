using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    internal class ElementarySchoolStudent : Student , IMathClass
    {
        public ElementarySchoolStudent(string first, string last, string id) : base(first, last, id)
        {

        }

        public override string ImportantThing()
        {
            return "Farm field trip!";
        }

        public string Math()
        {
            return "Basic Math";
        }

        public override string ToString()
        {
            return "My name is " + this.FirstName + " " + this.LastName + " I am a Elementary School Student. I have a " + this.ImportantThing() + " I am learning " + this.Math();
        }
    }
}
