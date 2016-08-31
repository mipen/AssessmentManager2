using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class Course
    {
        private string id       = "";
        public string CourseName        = "";
        public string CourseCode        = "";
        public string AssessmentName    = "";
        public string Author            = "";
        public int AssessmentWeighting  = 0;
        public string ID => id;

        public Course(string id)
        {
            this.id = id;
        }
    }
}
