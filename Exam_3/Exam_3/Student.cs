using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3
{
    abstract class Student
    {
        private string firstName, lastName, studentID;

        public Student(string first, string last, string id)
        {
            FirstName = first;
            LastName = last;
            StudentID = id;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string StudentID { get; }


        public abstract string ImportantThing();
    }
}
