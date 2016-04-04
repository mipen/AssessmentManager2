﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class Question
    {
        private string name = "Question";
        private int marks=0;
        private string questionText = "";
        private string modelAnswer;
        private string optionA, optionB, optionC, optionD;
        private MultiChoiceOption correctOption = MultiChoiceOption.A;
        private string comments;
        private AnswerType answerType = AnswerType.Open;
        private List<Question> subQuestions = new List<Question>();

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

        public string QuestionText
        {
            get
            {
                return questionText;
            }
            set
            {
                questionText = value;
            }
        }

        #region SubQuestions
        public List<Question> SubQuestions => subQuestions;
        public bool HasSubQuestions => subQuestions.Count != 0;
        #endregion

        #region Answer
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

        public string OptionA
        {
            get
            {
                return optionA;
            }
            set
            {
                optionA = value;
            }
        }

        public string OptionB
        {
            get
            {
                return optionB;
            }
            set
            {
                optionB = value;
            }
        }

        public string OptionC
        {
            get
            {
                return optionC;
            }
            set
            {
                optionC = value;
            }
        }

        public string OptionD
        {
            get
            {
                return optionD;
            }
            set
            {
                optionD = value;
            }
        }

        public MultiChoiceOption CorrectOption
        {
            get
            {
                return correctOption;
            }
            set
            {
                correctOption = value;
            }
        }

        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }
        #endregion


        #region Marks
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
        #endregion

    }
}
