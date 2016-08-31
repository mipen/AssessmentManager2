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
        private CourseInformation courseInfo = new CourseInformation();
        private string id = "";
        private List<Student> students = new List<Student>();
        public string ID => id;
        public CourseInformation CourseInfo => courseInfo;
        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }
        public string CourseTitle
        {
            get
            {
                return CourseInfo.CourseCode + " " + CourseInfo.CourseName;
            }
        }

        //Should only be used by the course manager when registering a new course!
        public void SetIdDirect(string newID)
        {
            id = newID;
        }
    }
}
