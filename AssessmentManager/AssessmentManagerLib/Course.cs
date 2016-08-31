using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public class Course
    {
        private CourseInformation courseInfo = new CourseInformation();
        private string id = "";
        public string ID => id;

        public Course(string id)
        {
            this.id = id;
        }
    }
}
