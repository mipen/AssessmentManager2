using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class AssessmentScript
    {
        public CourseInformation CourseInformation = null;
        public AssessmentInformation AssessmentInfo = null;
        private List<Question> questions = new List<Question>();
        private Dictionary<string, Answer> answers = new Dictionary<string, Answer>();
        private TimeData timeData = null;
        private StudentData studentData = null;
        public bool Started = false;
        public bool Published = false;

        public AssessmentScript()
        {
        }

        #region Properties

        public List<Question> Questions => questions;
        public Dictionary<string, Answer> Answers => answers;
        public TimeData TimeData => timeData;
        public StudentData StudentData => studentData;

        public int TotalMarks
        {
            get
            {
                int num = 0;
                foreach (var q in Questions)
                {
                    num += q.TotalMarks;
                }
                return num;
            }
        }

        #endregion

        #region Methods

        public static AssessmentScript BuildFromAssessment(Assessment assessment)
        {
            AssessmentScript script = new AssessmentScript();
            script.questions = assessment.Questions;
            script.Published = assessment.Published;
            //Populate answers dictionary with answer objects for each question
            foreach (var q in script.Questions)
            {
                q.AddToAnswerDict(script.Answers);
            }
            if (assessment.TimeData != null)
                script.timeData = assessment.TimeData;
            else
                script.timeData = new TimeData()
                {
                    DateIsPlanned = false,
                    MinutesArePlanned = false,
                    Minutes = 60
                };

            if (assessment.StudentData != null)
                script.studentData = assessment.StudentData;
            if (assessment.CourseInformation != null)
                script.CourseInformation = assessment.CourseInformation;

            return script;
        }

        #endregion
    }
}
