using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class CourseInformation
    {
        public string CourseName = "";
        public string CourseCode = "";
        public string Year = "2010";
        public string Semester = "1";

        public string[] CourseCodeSeparated
        {
            get
            {
                string[] str = new string[2] { "", "" };
                if (!CourseCode.NullOrEmpty() && CourseCode.Contains("."))
                {
                    int index = CourseCode.IndexOf(".");
                    str[0] = CourseCode.Substring(0, index);
                    str[1] = CourseCode.Substring(index + 1);
                }
                else
                {
                    str[0] = "";
                    str[1] = "";
                }
                return str;
            }
        }
    }
}
