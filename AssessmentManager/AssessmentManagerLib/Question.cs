using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class Question
    {
        private int marks;
        private string modelAnswer;
        private string name = "Question";
        private List<Question> subQuestions = new List<Question>();
        private AnswerType answerType = AnswerType.Single;

        public Question()
        {
        }

        public Question(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool HasSubQuestions => subQuestions.Count != 0;

        public AnswerType AnswerType
        {
            get
            {
                return answerType;
            }
            set
            {
                answerType = value;
            }
        }

        public string ModelAnswer
        {
            get
            {
                return modelAnswer;
            }
            set
            {
                modelAnswer = value;
            }
        }

        /// <summary>
        /// The sum of all sub question marks, including the marks for this question.
        /// </summary>
        public int TotalMarks
        {
            get
            {
                if (!HasSubQuestions)
                    return Marks;
                else
                {
                    int tmp = Marks;
                    foreach (var q in SubQuestions)
                        tmp += q.TotalMarks;
                    return tmp;
                }
            }
        }

        /// <summary>
        /// The number of marks for the question.
        /// </summary>
        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
            }         
        }

        public List<Question> SubQuestions => subQuestions;

        /// <summary>
        /// Add a new sub question at the bottom of the collection.
        /// </summary>
        public void AddSubQuestion()
        {
            subQuestions.Add(new Question());
        }

        /// <summary>
        /// Insert a new sub question at the specified index
        /// </summary>
        /// <param name="index">Desired index for the question to be inserted</param>
        public void AddSubQuestion(int index)
        {
            if (index < 0) index = 0;
            if (index < SubQuestions.Count)
                subQuestions.Insert(index, new Question());
            else
                subQuestions.Add(new Question());
        }
    }
}
