using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    internal class Campus:DSC
    {

        private string campusName;

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }

        public Campus(string cName)
        {
            campusName = cName;
        }

        public override string ShowAddress()
        {
            return "1770 Williamson Blvd., Daytona Beach, Florida 32117";
        }

        public string Departments()
        {
            return "Computer Scinece Department, Emergency Care Department, Police Academy";
        }

        public override string ToString()
        {
            return getSchoolName() + "\nis located at " + ShowAddress() + "\nit has " + Departments();
        }
    }
}
