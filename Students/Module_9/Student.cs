using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9
{
    internal class Student
    {
        public static int Count = 0;
        private static readonly Random rnd = new Random();
        private string firstName;
        private string lastName;
        private int sID;

        public Student(string first, string last, int id)
        {
            firstName = first;
            lastName = last;
            sID = id;
            Count++;
        }

        public Student(string first = "", string last = "")
        {
            firstName = first;
            lastName = last;
            sID = rnd.Next(1000, 9999);
            Count++;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int StudentID
        {
            get { return this.sID; }
            set { this.sID = value; }
        }
    }
}
