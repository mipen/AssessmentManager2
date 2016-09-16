using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class StudentData : Student
    {
        private string accountName = "";
        private string accountPassword = "";
        private DateTime startTime;
        private int assessmentLength = 0;
        private int readingTime = 0;

        public StudentData(string userName, string lastName, string firstName, string studentID, DateTime startTime, int assessmentLength, int readingTime, string accountName, string accountPassword):base(userName,lastName,firstName,studentID)
        {
            this.accountName = accountName;
            this.accountPassword = accountPassword;
            this.startTime = startTime;
            this.assessmentLength = assessmentLength;
            this.readingTime = readingTime;
        }

        #region Properties

        public string AccountName
        {
            get
            {
                return accountName;
            }

            set
            {
                accountName = value;
            }
        }

        public string AccountPassword
        {
            get
            {
                return accountPassword;
            }

            set
            {
                accountPassword = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public int AssessmentLength
        {
            get
            {
                return assessmentLength;
            }

            set
            {
                assessmentLength = value;
            }
        }

        public int ReadingTime
        {
            get
            {
                return readingTime;
            }

            set
            {
                readingTime = value;
            }
        }

        #endregion

        #region Methods


        public override bool ResolveErrors()
        {
            return base.ResolveErrors() && !AccountName.NullOrEmpty() && !AccountPassword.NullOrEmpty() && startTime != null && AssessmentLength > 0;
        }

        public override List<ErrorType> GetErrors()
        {
            List<ErrorType> list = base.GetErrors();

            if (AccountName.NullOrEmpty())
                list.Add(ErrorType.AccountName);
            if (AccountPassword.NullOrEmpty())
                list.Add(ErrorType.AccountPassword);
            if (StartTime == null || StartTime == CONSTANTS.INVALID_DATE)
                list.Add(ErrorType.StartTime);
            if (AssessmentLength <= 0)
                list.Add(ErrorType.AssessmentLength);
            if (ReadingTime < 0)
                list.Add(ErrorType.ReadingTime);

            return list;
        }

        #endregion

    }
}
