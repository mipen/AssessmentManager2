using System;
using System.Windows.Forms;

namespace AssessmentManager
{
    public partial class CourseInformationForm : Form
    {
        public CourseInformationForm()
        {
            InitializeComponent();
        }

        #region Properties

        public string CourseName
        {
            get
            {
                return tbCourseName.Text;
            }
            set
            {
                tbCourseName.Text = value;
            }
        }

        public string CourseCode
        {
            get
            {
                return textBoxCourseCode1.Text + "." + textBoxCourseCode2.Text;
            }
            set
            {
                string str = value;
                if (!str.NullOrEmpty() && str.Contains("."))
                {
                    int index = str.IndexOf(".");
                    textBoxCourseCode1.Text = value.Substring(0, index);
                    textBoxCourseCode2.Text = value.Substring(index + 1);
                }
                else
                {
                    textBoxCourseCode1.Text = "";
                    textBoxCourseCode2.Text = "";
                }
            }
        }

        public string AssessmentName
        {
            get
            {
                return tbAssessmentName.Text;
            }
            set
            {
                tbAssessmentName.Text = value;
            }
        }

        public string Author
        {
            get
            {
                return textBoxAuthor.Text;
            }
            set
            {
                textBoxAuthor.Text = value;
            }
        }

        public decimal AssessmentWeighting
        {
            get
            {
                return nudAssessmentWeighting.Value;
            }
            set
            {
                nudAssessmentWeighting.Value = value;
            }
        }

        #endregion

        #region Events

        private void textBoxCourseCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            //Stop more than three characters being entered
            if (tbox.Text.Length >= 3)
                e.Handled = true;

            //Only allow numbers to be entered
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (CourseName.NullOrEmpty())
            {
                MessageBox.Show("Please enter the course name.");
                return;
            }
            else if (CourseCode.NullOrEmpty())
            {
                MessageBox.Show("Please enter the course code.");
                return;
            }
            else if (AssessmentName.NullOrEmpty())
            {
                MessageBox.Show("Please enter the assessment name.");
                return;
            }
            else if (Author.NullOrEmpty())
            {
                MessageBox.Show("Please enter the author's name.");
                return;
            }
            this.Close();
        }

        #endregion

        #region Methods

        public static CourseInformationForm FromAssessment(Assessment assessment)
        {
            CourseInformationForm cif = new CourseInformationForm();
            if (assessment.CourseInformation == null) assessment.CourseInformation = new CourseInformation();
            cif.CourseName = assessment.CourseInformation.CourseName;
            cif.CourseCode = assessment.CourseInformation.CourseCode;
            cif.AssessmentName = assessment.CourseInformation.AssessmentName;
            cif.Author = assessment.CourseInformation.Author;
            cif.AssessmentWeighting = assessment.CourseInformation.AssessmentWeighting;
            return cif;
        }

        public static void PopulateCourseInformation(Assessment assessment, CourseInformationForm cif)
        {
            assessment.CourseInformation.CourseName = cif.CourseName;
            assessment.CourseInformation.CourseCode = cif.CourseCode;
            assessment.CourseInformation.AssessmentName = cif.AssessmentName;
            assessment.CourseInformation.Author = cif.Author;
            assessment.CourseInformation.AssessmentWeighting = (int)cif.AssessmentWeighting;
        }

        #endregion

    }
}
