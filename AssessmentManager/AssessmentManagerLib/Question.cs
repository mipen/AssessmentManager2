using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManager
{
    [Serializable]
    public class Question
    {
        private int _marks;
        private string _modelAnswer;
        private List<Question> _subQuestions = new List<Question>();
        private AnswerType _answerType = AnswerType.None;

        public Question()
        {
        }

        public bool HasSubQuestions => _subQuestions.Count != 0;

        public AnswerType AnswerType
        {
            get
            {
                return _answerType;
            }
            set
            {
                _answerType = value;
            }
        }

        public string ModelAnswer
        {
            get
            {
                return _modelAnswer;
            }
            set
            {
                _modelAnswer = value;
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
                return _marks;
            }
            set
            {
                _marks = value;
            }         
        }

        public List<Question> SubQuestions => _subQuestions;

        /// <summary>
        /// Add a new sub question at the bottom of the collection.
        /// </summary>
        public void AddSubQuestion()
        {
            _subQuestions.Add(new Question());
        }

        /// <summary>
        /// Insert a new sub question at the specified index
        /// </summary>
        /// <param name="index">Desired index for the question to be inserted</param>
        public void AddSubQuestion(int index)
        {
            if (index < 0) index = 0;
            if (index < SubQuestions.Count)
                _subQuestions.Insert(index, new Question());
            else
                _subQuestions.Add(new Question());
        }
    }
}
