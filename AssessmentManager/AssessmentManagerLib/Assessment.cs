using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssessmentManager
{
    [Serializable]
    public class Assessment
    {
        private List<Question> questions = new List<Question>();
        private DateTime dateCreated;
        private DateTime lastModified;
        private CourseInformation course = new CourseInformation();

        public Assessment()
        {

        }
        /// <summary>
        /// Constructor used for creating a new assessment.
        /// </summary>
        /// <param name="createdDateTime">The current date and time the assessment was created.</param>
        public Assessment(DateTime createdDateTime)
        {
            DateCreated = createdDateTime;
        }

        public int TotalMarks
        {
            get
            {
                int tmp=0;
                foreach (var q in Questions)
                    tmp += q.TotalMarks;
                return tmp;
            }
        }

        public List<Question> Questions => questions;

        public CourseInformation Course => course;

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        #region Add Question Methods
        /// <summary>
        /// Add a new top level question to the assessment at the end of the list
        /// </summary>
        public void AddQuestion()
        {
            questions.Add(new Question());
        }

        public void AddQuestion(string name)
        {
            questions.Add(new Question(name));
        }
        #endregion


    }
}
