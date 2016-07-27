using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssessmentManager.CONSTANTS;

namespace AssessmentManager
{
    public partial class IntroductionForm : Form
    {

        private Assessment assessment = null;
        private AssessmentScript script = null;

        public IntroductionForm(string[] args)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            DateTime dt = DateTime.Now;
            lblDateTimeDisp.Text = dt.ToLongDateString() + " " + dt.ToLongTimeString();
            if (args.Count() > 0)
            {
                OpenFromFile(args[0]);
            }
            else
            {
                NotifyNothingOpened();
            }
        }

        #region Events

        private void timer_Tick(object sender, EventArgs e)
        {
            //Update the current time and date.
            DateTime dt = DateTime.Now;
            lblDateTimeDisp.Text = dt.ToLongDateString() + " " + dt.ToLongTimeString();
        }

        #endregion

        #region Methods

        public void OpenFromFile()
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = COMBINED_FILTER;
            o.DefaultExt = ASSESSMENT_EXT;
            o.InitialDirectory = DESKTOP_PATH;

            if (o.ShowDialog() == DialogResult.OK)
            {
                OpenFromFile(o.FileName);
            }
        }

        public void OpenFromFile(string path)
        {
            if (File.Exists(path))
            {
                string ext = Path.GetExtension(path);
                if (ext == ASSESSMENT_EXT)
                {
                    try
                    {
                        using (FileStream s = File.Open(path, FileMode.Open))
                        {
                            BinaryFormatter f = new BinaryFormatter();
                            assessment = (Assessment)f.Deserialize(s);
                            NotifyAssessmentOpened();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load file.\n" + ex.Message);
                    }
                }
                else if (ext == ASSESSMENT_SCRIPT_EXT)
                {
                    //TODO:: Open assessment script
                }
                else
                {
                    MessageBox.Show("Unable to open file: " + path + "\n\n File has incorrect extension.");
                }
            }
        }

        private void NotifyAssessmentOpened()
        {
            //Show the assessment information
            #region Assessment information
            if (assessment.CourseInformation != null)
            {
                CourseInformation c = assessment.CourseInformation;
                if (!c.CourseCode.NullOrEmpty())
                    lblCourseCode.Text = c.CourseCode;
                else
                    lblCourseCode.Text = "";

                if (!c.CourseName.NullOrEmpty())
                    lblCourseName.Text = c.CourseName;
                else
                    lblCourseName.Text = "Unkown course";

                if (!c.AssessmentName.NullOrEmpty())
                    lblAssessmentName.Text = c.AssessmentName;
                else
                    lblAssessmentName.Text = "Assessment";

                if (!c.Author.NullOrEmpty())
                    lblAuthor.Text = $"Author: {c.Author}";
                else
                    lblAuthor.Text = "";

                lblWeighting.Text = $"{c.AssessmentWeighting}%";

                //Enable the information panel
                pnlInformation.Enabled = true;
                pnlInformation.Visible = true;
            }
            #endregion

            //Build the assessment script
            AssessmentScript script = AssessmentScript.BuildFromAssessment(assessment);
            this.script = script;

            //Determine if the assessment is published or not and show the correct window
            if (assessment.Published)
            {
                //TODO:: do published stuff
            }
            else
            {
                //Enable practice panel
                pnlPractise.Enabled = true;
                pnlPractise.Visible = true;

                //Disable open assessment panel
                pnlOpenAssessment.Enabled = false;
                pnlOpenAssessment.Visible = false;
            }
        }

        private void NotifyAssessmentScriptOpened()
        {
            //TODO:: Do script opening stuff here

        }

        private void NotifyNothingOpened()
        {
            //Disable information panel
            pnlInformation.Enabled = false;
            pnlInformation.Visible = false;

            //Disable practice panel
            pnlPractise.Enabled = false;
            pnlPractise.Visible = false;

            //TODO:: Disable assessment panel

            //Enable Open Assessment panel
            pnlOpenAssessment.Enabled = true;
            pnlOpenAssessment.Visible = true;
        }

        #endregion

        #region Buttons

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFromFile();
        }

        private void btnYesPractice_Click(object sender, EventArgs e)
        {
            //Ask for the time allowed for the assessment. TimeData should never be null here
            TimeConfig tc = new TimeConfig(false);
            tc.AssessmentTime = script.TimeData.Minutes;
            tc.ReadingTime = script.TimeData.ReadingMinutes;

            if (tc.ShowDialog() == DialogResult.OK)
            {
                script.TimeData.Minutes = tc.AssessmentTime;
                script.TimeData.ReadingMinutes = tc.ReadingTime;
            }

            //Set the start time
            script.TimeData.TimeStarted = DateTime.Now;

            Examinee ex = new Examinee(script);
            ex.Show();
            Hide();
        }

        private void btnNoPractice_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
