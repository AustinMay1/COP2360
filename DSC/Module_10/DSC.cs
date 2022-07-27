using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    internal class DSC
    {
        private string schoolName = "Daytona State College";

        public string getSchoolName()
        {
            return schoolName;
        }

        public virtual string ShowAddress()
        {
            return "1200 W. International Speedway Blvd., Daytona Beach, Florida 32114";
        }
    }
}
