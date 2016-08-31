using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class Student
    {
        private string userName;
        private string firstName;
        private string lastName;
        private string studentID;

        public Student()
        {

        }

        public Student(string userName, string lastName, string firstName, string studentID)
        {
            this.userName = userName;
            this.lastName = lastName;
            this.firstName = firstName;
            this.studentID = studentID;
        }

        #region Properties

        public string StudentNumber
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        #endregion
    }
}
