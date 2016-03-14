using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManager
{
    [Serializable]
    public class Assessment
    {
        private List<Question> _questions = new List<Question>();
        private DateTime _dateCreated;
        private DateTime _lastModified;
        private CourseInformation _course = new CourseInformation();

        public Assessment() { }
        /// <summary>
        /// Constructor used for creating a new assessment.
        /// </summary>
        /// <param name="createdDateTime">The current date and time the assessment was created.</param>
        public Assessment(DateTime createdDateTime)
        {

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

        public List<Question> Questions => _questions;

        public CourseInformation Course => _course;

        #region Add Questions
        /// <summary>
        /// Add a new top level question to the assessment at the end of the list
        /// </summary>
        public void AddQuestion()
        {
            _questions.Add(new Question());
        }

        /// <summary>
        /// Add a new top level question at the specified index.
        /// If the index is out of range of the collection, adds a new question to the end.
        /// </summary>
        /// <param name="index">The desired index for the question to be inserted to.</param>
        public void AddQuestion(int index)
        {
            if (index < 0) index = 0;
            if (index < Questions.Count)
            {
                _questions.Insert(index, new Question());
            }
            else
                _questions.Add(new Question());
        }

        /// <summary>
        /// Add a new sub question to the selected question, at the bottom of the question's sub questions list.
        /// </summary>
        /// <param name="question">The question to add the sub question to.</param>
        public void AddSubQuestion(Question question)
        {
            question.AddSubQuestion();
        }

        /// <summary>
        /// Insert a new sub question at the specified index on the specified question.
        /// </summary>
        /// <param name="question">The question to add the sub question to.</param>
        /// <param name="index">The desired index to insert the question to.</param>
        public void AddSubQuestion(Question question, int index)
        {
            question.AddSubQuestion(index);
        } 
        #endregion


    }
}
