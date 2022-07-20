using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    internal class Person
    {
        private string name;
        private int age;
        private int yearsToWork;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int YearsToWork
        {
            get { return yearsToWork; }
            set { yearsToWork = value; }
        }

        public int YTK()
        {
            YearsToWork = 65 - Age;
            return YearsToWork;
        }
    }
}
