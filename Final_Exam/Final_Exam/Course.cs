using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Course
    {
        private string CID;
        private string CName;

        public Course(string courseId, string courseName)
        {
            this.CID = courseId;
            this.CName = courseName;
        }

        public string ID
        {
            get { return this.CID; }
            set { this.CID = value; }
        }

        public string Name
        {
            get { return this.CName; }
            set { this.CName = value; }
        }
    }
}
