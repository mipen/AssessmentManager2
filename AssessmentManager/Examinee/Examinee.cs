using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssessmentManager.CONSTANTS;

namespace AssessmentManager
{
    public partial class Examinee : Form
    {

        private AssessmentScript script;
        private Mode mode = Mode.Running;
        private int marksAttempted = 0;
        private int TotalMarksCache = 0;
        private string filePath = null;

        public Examinee(AssessmentScript script, string path)
        {
            InitializeComponent();
            filePath = path;
            buttonSubmitAssessment.UseCompatibleTextRendering = true;
            StartPosition = FormStartPosition.CenterScreen;
            Script = script;
            NotifyAssessmentOpened();
        }

        #region Properties

        public AssessmentScript Script
        {
            get { return script; }
            private set { script = value; }
        }

        public Question SelectedQuestion
        {
            get
            {
                return SelectedNode.Question;
            }
        }

        public QuestionNode SelectedNode
        {
            get
            {
                return (QuestionNode)treeViewQuestionDisplay.SelectedNode;
            }
        }

        public Answer SelectedQuestionAnswer
        {
            get
            {
                try
                {
                    return script.Answers[SelectedQuestion.Name];
                }
                catch (Exception)
                {
                    MessageBox.Show($"An error has occured: {SelectedQuestion.Name} tried to access its answer, but it doesn't have one.");
                    return null;
                }
            }
        }

        public List<string> UnattemptedQuestions
        {
            get
            {
                List<string> list = new List<string>();
                foreach (var kvp in Script.Answers)
                {
                    if (!kvp.Value.Attempted)
                        list.Add(kvp.Key);
                }
                return list;
            }
        }

        public Mode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        #endregion

        #region Methods

        public void NotifyAssessmentOpened()
        {
            //Reset the image tracker
            ImageTracker.Reset();

            //Load questions into tree view
            Util.PopulateTreeView(treeViewQuestionDisplay, Script);

            //Select the first question
            if (treeViewQuestionDisplay.Nodes.Count > 0)
                treeViewQuestionDisplay.SelectedNode = treeViewQuestionDisplay.Nodes[0];

            //Set the mode:
            if (Script.Started)
            {
                //TODO:: Handle an already started assessment
            }
            else
            {
                //Script has not been started yet:
                Script.Started = true;
                if (Script.TimeData.HasReadingTime)
                    ChangeMode(Mode.Reading);
                else
                    ChangeMode(Mode.Running);
            }

            //Cache the total number of marks
            TotalMarksCache = Script.TotalMarks;

            //Set the maximum for the progress bar
            progressBarMarksAttempted.Maximum = TotalMarksCache;

            //Update the unattempted list
            listBoxUnansweredQuestions.Items.Clear();
            listBoxUnansweredQuestions.Items.AddRange(UnattemptedQuestions.ToArray());

            //Display the times
            UpdateTimeDisplay(true);

        }

        public void NotifyAssessmentClosed()
        {
            //Disable all ui
            panelQuestionAnswer.Enabled = false;
            panelQuestionAnswer.Visible = false;

            panelLeft.Enabled = false;
            panelLeft.Visible = false;

            panelTop.Enabled = false;
            panelTop.Visible = false;
        }

        private void UpdateMarksDisplay()
        {
            //Update the marks
            labelQuestionMarks.Text = SelectedQuestion?.Name;
            labelQuestionMarksNum.Text = $"{SelectedQuestion?.Marks} ({SelectedQuestion?.TotalMarks} total)";

            if (SelectedNode.Parent != null)
            {
                Question pq = ((QuestionNode)SelectedNode.Parent).Question;
                labelSubQuestionMarks.Text = pq.Name;
                labelSubQuestionMarksNum.Text = $"{pq?.Marks} ({pq?.TotalMarks} total)";

                labelSubQuestionMarks.Visible = true;
                labelSubQuestionMarksNum.Visible = true;

                if (SelectedNode.Parent.Parent != null)
                {
                    Question ppq = ((QuestionNode)SelectedNode.Parent.Parent).Question;
                    labelSubSubQuestionMarks.Text = ppq.Name;
                    labelSubSubQuestionMarksNum.Text = $"{ppq?.Marks} ({ppq?.TotalMarks} total)";

                    labelSubSubQuestionMarks.Visible = true;
                    labelSubSubQuestionMarksNum.Visible = true;
                }
                else
                {
                    labelSubSubQuestionMarks.Visible = false;
                    labelSubSubQuestionMarksNum.Visible = false;
                }
            }
            else
            {
                //Display sub question display
                labelSubQuestionMarks.Visible = false;
                labelSubQuestionMarksNum.Visible = false;

                //Disable sub sub question display
                labelSubSubQuestionMarks.Visible = false;
                labelSubSubQuestionMarksNum.Visible = false;
            }

            //Update the progress display
            UpdateAttemptedMarks();
        }

        private void UpdateAttemptedMarks()
        {
            marksAttempted = 0;
            foreach (var q in Script.Questions)
                marksAttempted += q.AttemptedMarks(script.Answers);

            labelMarksAttempted.Text = $"{marksAttempted}/{TotalMarksCache} marks attempted";
            progressBarMarksAttempted.Value = marksAttempted;
        }

        public void ChangeMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Reading:
                    {
                        //Disable all answer entry points
                        panelAnswerContainer.Enabled = false;
                        //Disable submit button
                        buttonSubmitAssessment.Enabled = false;
                        timer.Enabled = true;
                        Mode = Mode.Reading;
                        lblTimeRemaining.Text = "Reading time:";

                        lblMotivational.ForeColor = Color.Orange;
                        lblMotivational.Text = "Reading time";
                        break;
                    }
                case Mode.Running:
                    {
                        //Enable all answer entry points
                        panelAnswerContainer.Enabled = true;
                        timer.Enabled = true;
                        Mode = Mode.Running;
                        lblTimeRemaining.Text = "Time remaining:";
                        break;
                    }
                case Mode.Completed:
                    {
                        //Disable all answer entry points
                        panelAnswerContainer.Enabled = false;
                        Mode = Mode.Completed;
                        lblTimeRemaining.Text = "";
                        lblTimeRemainingTimer.Text = "";
                        lblMotivational.ForeColor = Color.Blue;
                        lblMotivational.Text = "Completed. Please Submit.";
                        timer.Enabled = false;
                        break;
                    }
            }
        }

        private void UpdateTimeDisplay(bool initial = false)
        {
            //Show the start and end times
            if (initial)
            {
                lblTimeBegan.Text = Script.TimeData.StartTime.ToString("hh:mm:ss");
                lblFinishTime.Text = Script.TimeData.FinishTime.ToString("hh:mm:ss");
            }

            switch (Mode)
            {
                case Mode.Reading:
                    {
                        //Will only get here if assessment has reading time, so ReadingFinishTime will never be null.
                        TimeSpan ts = Script.TimeData.ReadingFinishTime - DateTime.Now;
                        if (ts.Hours <= 0 && ts.Minutes <= 0 && ts.Seconds <= 0)
                        {
                            ChangeMode(Mode.Running);
                            break;
                        }
                        lblTimeRemainingTimer.Text = $"{ts.Hours.ToString("00")}:{ts.Minutes.ToString("00")}:{ts.Seconds.ToString("00")}";
                        break;
                    }
                case Mode.Running:
                    {
                        TimeSpan ts = Script.TimeData.FinishTime - DateTime.Now;
                        if (ts.Hours <= 0 && ts.Minutes <= 0 && ts.Seconds <= 0)
                        {
                            ChangeMode(Mode.Completed);
                            break;
                        }
                        lblTimeRemainingTimer.Text = $"{ts.Hours.ToString("00")}:{ts.Minutes.ToString("00")}:{ts.Seconds.ToString("00")}";

                        //Update the motivational display
                        double marksPercentage = (double)marksAttempted / (double)TotalMarksCache;
                        double timePercentage = 1 - (ts.TotalMinutes / Script.TimeData.Minutes);
                        if (marksPercentage >= timePercentage)
                        {
                            //Give good message
                            lblMotivational.ForeColor = Color.Green;
                            lblMotivational.Text = "You are ahead of time";
                        }
                        else
                        {
                            //Give bad message
                            lblMotivational.ForeColor = Color.Red;
                            lblMotivational.Text = "You are falling behind";
                        }
                        break;
                    }
            }
        }

        private void SaveToFile()
        {
            //TODO:: Name the file properly!
            string path = "";
            if (Path.GetExtension(filePath) == ASSESSMENT_SCRIPT_EXT)
            {
                path = filePath;
            }
            else
            {
                string filePath2 = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                path = filePath2 + "\\" + fileName + ASSESSMENT_SCRIPT_EXT;
            }
            try
            {
                using(FileStream s = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(s, Script);
                    filePath = path;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Failed to save \n\n" + ex.Message);
            }
        }

        #endregion

        #region Control Events

        #region Radio Buttons

        private void rbOptionA_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = true;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.SelectedOption = MultiChoiceOption.A;
            }
        }

        private void rbOptionB_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = true;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.SelectedOption = MultiChoiceOption.B;
            }
        }

        private void rbOptionC_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = true;
            rbOptionD.Checked = false;

            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.SelectedOption = MultiChoiceOption.C;
            }
        }

        private void rbOptionD_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = true;

            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.SelectedOption = MultiChoiceOption.D;
            }
        }

        #endregion

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            treeViewQuestionDisplay.ExpandAll();
        }

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            treeViewQuestionDisplay.CollapseAll();
        }

        private void buttonPrevQuestion_Click(object sender, EventArgs e)
        {
            QuestionNode node = SelectedNode;
            if (node != null)
            {
                treeViewQuestionDisplay.SelectedNode = node.PrevVisibleNode;
            }
            treeViewQuestionDisplay.Focus();
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            QuestionNode node = SelectedNode;
            if (node != null)
            {
                treeViewQuestionDisplay.SelectedNode = node.NextVisibleNode;
            }
            treeViewQuestionDisplay.Focus();
        }

        private void btnQuestionImage_Click(object sender, EventArgs e)
        {
            Question question = SelectedQuestion;
            if (question != null && question.Image != null)
            {
                //Show the image if not already shown
                if (!ImageTracker.ImageDisplayShown(question.Name))
                {
                    ImageDisplay id = new ImageDisplay(question.Name, question.Image);
                    id.Show();
                    id.TopMost = true;
                    id.BringToFront();
                }
                else
                {
                    ImageTracker.FindImageDisplay(question.Name).Focus();
                }
            }
        }

        private void trackBarMagnification_Scroll(object sender, EventArgs e)
        {
            rtbQuestion.ZoomFactor = trackBarMagnification.Value;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void rtbAnswerLong_TextChanged(object sender, EventArgs e)
        {
            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.LongAnswer = rtbAnswerLong.Text;
            }
        }

        private void textBoxAnswerShort_TextChanged(object sender, EventArgs e)
        {
            if (SelectedQuestion != null && SelectedQuestion.AnswerType != AnswerType.None)
            {
                SelectedQuestionAnswer.ShortAnswer = textBoxAnswerShort.Text;
            }
        }

        private void listBoxUnansweredQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            TreeNode[] nodes = treeViewQuestionDisplay.Nodes.Find((string)listBoxUnansweredQuestions.SelectedItem, true);
            if (nodes.Count() > 0)
            {
                TreeNode match = nodes[0];
                treeViewQuestionDisplay.SelectedNode = match;
            }
        }

        private void buttonSubmitAssessment_Click(object sender, EventArgs e)
        {
            //TODO:: submit the assessment properly!
            SaveToFile();
        }

        #endregion

        private void treeViewQuestionDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Question question;
            try
            {
                question = SelectedQuestion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, tried to display null question.\n\n" + ex.Message);
                return;
            }

            //Display the question text
            rtbQuestion.Rtf = question.QuestionText;

            //Update the marks display
            UpdateMarksDisplay();

            //Show the question name
            lblQuestionNumber.Text = question.Name;

            //Show the correct answer page and any answer already entered
            #region Answer
            switch (question.AnswerType)
            {
                case AnswerType.None:
                    {
                        panelAnswerLongContainer.Enabled = false;
                        panelAnswerLongContainer.Visible = false;

                        panelAnswerShortContainer.Enabled = false;
                        panelAnswerShortContainer.Visible = false;

                        tlpMultiAnswerContainer.Enabled = false;
                        tlpMultiAnswerContainer.Visible = false;

                        labelAnswerText.Visible = false;
                        break;
                    }
                case AnswerType.Multi:
                    {
                        panelAnswerLongContainer.Enabled = false;
                        panelAnswerLongContainer.Visible = false;

                        panelAnswerShortContainer.Enabled = false;
                        panelAnswerShortContainer.Visible = false;

                        tlpMultiAnswerContainer.Enabled = true;
                        tlpMultiAnswerContainer.Visible = true;

                        labelAnswerText.Visible = true;

                        labelOptionA.Text = SelectedQuestion?.OptionA;
                        labelOptionB.Text = SelectedQuestion?.OptionB;
                        labelOptionC.Text = SelectedQuestion?.OptionC;
                        labelOptionD.Text = SelectedQuestion?.OptionD;

                        //Select the answer that has been selected (if so)
                        switch (SelectedQuestionAnswer.SelectedOption)
                        {
                            case MultiChoiceOption.A:
                                rbOptionA_Click(sender, e);
                                break;
                            case MultiChoiceOption.B:
                                rbOptionB_Click(sender, e);
                                break;
                            case MultiChoiceOption.C:
                                rbOptionC_Click(sender, e);
                                break;
                            case MultiChoiceOption.D:
                                rbOptionD_Click(sender, e);
                                break;
                            default:
                                rbOptionA.Checked = false;
                                rbOptionB.Checked = false;
                                rbOptionC.Checked = false;
                                rbOptionD.Checked = false;
                                break;
                        }
                        break;
                    }
                case AnswerType.Open:
                    {
                        panelAnswerLongContainer.Enabled = true;
                        panelAnswerLongContainer.Visible = true;

                        panelAnswerShortContainer.Enabled = false;
                        panelAnswerShortContainer.Visible = false;

                        tlpMultiAnswerContainer.Enabled = false;
                        tlpMultiAnswerContainer.Visible = false;

                        labelAnswerText.Visible = true;

                        //Show the entered answer
                        rtbAnswerLong.Text = SelectedQuestionAnswer.LongAnswer;
                        break;
                    }
                case AnswerType.Single:
                    {
                        panelAnswerLongContainer.Enabled = false;
                        panelAnswerLongContainer.Visible = false;

                        panelAnswerShortContainer.Enabled = true;
                        panelAnswerShortContainer.Visible = true;

                        tlpMultiAnswerContainer.Enabled = false;
                        tlpMultiAnswerContainer.Visible = false;

                        labelAnswerText.Visible = true;

                        //TODO:: Show the enetered answer
                        textBoxAnswerShort.Text = SelectedQuestionAnswer.ShortAnswer;
                        break;
                    }
            }
            #endregion

            //Show or hide the image button
            if (question.Image != null)
            {
                btnQuestionImage.Enabled = true;
                btnQuestionImage.Visible = true;

                //Show the image if not already shown
                if (!ImageTracker.ImageDisplayShown(question.Name))
                {
                    ImageDisplay id = new ImageDisplay(question.Name, question.Image);
                    id.Show();
                    id.TopMost = true;
                    id.BringToFront();
                }
                else
                {
                    ImageTracker.FindImageDisplay(question.Name).Focus();
                }
            }
            else
            {
                btnQuestionImage.Enabled = false;
                btnQuestionImage.Visible = false;
            }

            //TODO:: Update unanswered questions
            listBoxUnansweredQuestions.Items.Clear();
            listBoxUnansweredQuestions.Items.AddRange(UnattemptedQuestions.ToArray());
        }

        private void Examinee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO:: Ask if user is finished. Save assessment
        }

        private void Examinee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
