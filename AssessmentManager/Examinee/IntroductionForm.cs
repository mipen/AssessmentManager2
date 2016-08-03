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
        private string filePath = null;

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
                            NotifyAssessmentOpened(path);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load file " + path + "\n\n" + ex.Message);
                    }
                }
                else if (ext == ASSESSMENT_SCRIPT_EXT)
                {
                    try
                    {
                        using (FileStream s = File.Open(path, FileMode.Open))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            script = (AssessmentScript)formatter.Deserialize(s);
                            NotifyAssessmentScriptOpened(path);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to load file " + path + "\n\n" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to open file: " + path + "\n\n File has incorrect extension.");
                }
            }
        }

        private void NotifyAssessmentOpened(string path)
        {
            //Record the file path
            filePath = path;
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
            script = AssessmentScript.BuildFromAssessment(assessment);

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

                //Disable continue panel
                pnlContinueAssessment.Enabled = false;
                pnlContinueAssessment.Visible = false;
            }
        }

        private void NotifyAssessmentScriptOpened(string path)
        {
            //TODO:: Do script opening stuff here

            //Record the path
            filePath = path;

            //Show the assessment information
            #region Assessment information
            if (script.CourseInformation != null)
            {
                CourseInformation c = script.CourseInformation;
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

            //Determine if the assessment can be continued
            if (DateTime.Now < script.TimeData.FinishTime)
            {
                //Assessment can be continued

                //Enable continue panel
                pnlContinueAssessment.Enabled = true;
                pnlContinueAssessment.Visible = true;

                //Disable practice panel
                pnlPractise.Enabled = false;
                pnlPractise.Visible = false;

                //Disable open assessment panel
                pnlOpenAssessment.Enabled = false;
                pnlOpenAssessment.Visible = false;

                //Add check for remaining time to timer tick
                timer.Tick += CheckTimeRemainingForContinue;

                //Show start and finish times
                lblTimeStarted.Text = script.TimeData.StartTime.ToString("F");
                lblFinishingTime.Text = script.TimeData.FinishTime.ToString("F");
            }
            else
            {
                //Assessment has finished

                //TODO:: Show panel which lets user know the assessment has finished
            }
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

        private void CheckTimeRemainingForContinue(object sender, EventArgs e)
        {
            if(DateTime.Now>=script.TimeData.FinishTime)
            {
                //Remove check method from timer
                timer.Tick -= CheckTimeRemainingForContinue;

                //Enable assessment finished panel

                //Disable continue panel
                pnlContinueAssessment.Enabled = false;
                pnlContinueAssessment.Visible = false;

                //Disable practice panel
                pnlPractise.Enabled = false;
                pnlPractise.Visible = false;

                //Disable open assessment panel
                pnlOpenAssessment.Enabled = false;
                pnlOpenAssessment.Visible = false;
            }
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
            script.TimeData.StartTime = DateTime.Now;
            //Set the finish time
            script.TimeData.FinishTime = script.TimeData.StartTime.AddMinutes(script.TimeData.Minutes + script.TimeData.ReadingMinutes);
            //Set reading finish time
            script.TimeData.ReadingFinishTime = script.TimeData.StartTime.AddMinutes(script.TimeData.ReadingMinutes);

            Examinee ex = new Examinee(script, filePath);
            ex.Show();
            timer.Enabled = false;
            Hide();
        }

        private void btnNoPractice_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinueNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinueYes_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
