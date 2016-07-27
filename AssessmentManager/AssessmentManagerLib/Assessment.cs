﻿using System;
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
        private CourseInformation courseInformation = new CourseInformation();

        public TimeData TimeData = null;
        public StudentData StudentData = null;

        private bool published = false;

        public Assessment()
        {

        }

        public int TotalMarks
        {
            get
            {
                int num=0;
                foreach (var q in Questions)
                {
                    num += q.TotalMarks;
                }
                return num;
            }
        }

        //TODO:: Set this to true when publishing assessment
        public bool Published
        {
            get
            {
                return published;
            }
            set
            {
                published = value;
            }
        }

        public List<Question> Questions => questions;

        public CourseInformation CourseInformation
        {
            get
            {
               return courseInformation;
            }
            set
            {
                courseInformation = value;
            }
        }

        #region Add Question Methods
        /// <summary>
        /// Add a new top level question to the assessment at the end of the list
        /// </summary>
        public void AddQuestion()
        {
            AddQuestion("unnamed");
        }

        public void AddQuestion(string name)
        {
            questions.Add(new Question(name));
        }
        #endregion

        public List<Question> CheckMissingMarks()
        {
            List<Question> list = new List<Question>();
            foreach(var q in Questions)
            {
                q.CheckMissingMarks(list);
            }
            return list;
        }

    }
}
