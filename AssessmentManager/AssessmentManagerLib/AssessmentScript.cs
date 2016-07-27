﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class AssessmentScript
    {
        private List<Question> questions = new List<Question>();
        private Dictionary<string, Answer> answers = new Dictionary<string, Answer>();
        private TimeData timeData = null;
        private StudentData studentData = null;

        public AssessmentScript()
        {

        }

        #region Properties

        public List<Question> Questions => questions;
        public Dictionary<string, Answer> Answers => answers;
        public TimeData TimeData => timeData;
        public StudentData StudentData => studentData;

        #endregion

        #region Methods

        public static AssessmentScript BuildFromAssessment(Assessment assessment)
        {
            AssessmentScript script = new AssessmentScript();
            script.questions = assessment.Questions;
            //Populate answers dictionary with answer objects for each question
            foreach (var q in script.Questions)
            {
                if (!script.Answers.Keys.Contains(q.Name))
                    script.Answers.Add(q.Name, new Answer());
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

            return script;
        }

        #endregion
    }
}
