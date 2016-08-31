using System;
using System.Windows.Forms;

namespace AssessmentManager
{
    public partial class AssessmentInformationForm : Form
    {
        public AssessmentInformationForm()
        {
            InitializeComponent();
        }

        #region Properties

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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (AssessmentName.NullOrEmpty())
            {
                MessageBox.Show("Please enter the assessment name.","Assessment name required");
                
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        #region Methods

        public static AssessmentInformationForm FromAssessment(Assessment assessment)
        {
            AssessmentInformationForm aif = new AssessmentInformationForm();
            if (assessment.AssessmentInfo == null) assessment.AssessmentInfo = new AssessmentInformation();
            aif.AssessmentName = assessment.AssessmentInfo.AssessmentName;
            aif.Author = assessment.AssessmentInfo.Author;
            aif.AssessmentWeighting = assessment.AssessmentInfo.AssessmentWeighting;
            return aif;
        }

        public static void PopulateAssessmentInformation(Assessment assessment, AssessmentInformationForm aif)
        {
            assessment.AssessmentInfo.AssessmentName = aif.AssessmentName;
            assessment.AssessmentInfo.Author = aif.Author;
            assessment.AssessmentInfo.AssessmentWeighting = (int)aif.AssessmentWeighting;
        }

        #endregion

    }
}
