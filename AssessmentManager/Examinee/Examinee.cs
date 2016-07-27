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

namespace AssessmentManager
{
    public partial class Examinee : Form
    {

        private AssessmentScript script;

        public Examinee(AssessmentScript script)
        {
            InitializeComponent();
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

        #endregion

        #region Methods

        public void NotifyAssessmentOpened()
        {
            //Enable all ui
            panelQuestionAnswer.Enabled = true;
            panelQuestionAnswer.Visible = true;

            panelLeft.Enabled = true;
            panelLeft.Visible = true;

            panelTop.Enabled = true;
            panelTop.Visible = true;

            //Load questions into tree view
            Util.PopulateTreeView(treeViewQuestionDisplay, Script);

            //Select the first question
            if (treeViewQuestionDisplay.Nodes.Count > 0)
                treeViewQuestionDisplay.SelectedNode = treeViewQuestionDisplay.Nodes[0];

            //Reset the image tracker
            ImageTracker.Reset();

            //Display the times
            DateTime timeStarted = Script.TimeData.TimeStarted;
            lblTimeBegan.Text = timeStarted.ToString("hh:mm:ss");
            DateTime finishTime = timeStarted.AddMinutes(Script.TimeData.Minutes);
            lblFinishTime.Text = finishTime.ToString("hh:mm:ss");
            TimeSpan time = finishTime - timeStarted;
            lblTimeRemainingTimer.Text = time.ToString();
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
            //TODO:: Show the marks attempted
            labelMarksAttempted.Text = $"x // {Script.TotalMarks} marks attempted ((y)%)";
        }

        #endregion

        #region Control Events

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
            //TODO:: Include reading minutes
            //TODO:: Event for when time runs out. Go into ReadOnly mode and ask to save.

            //Update the time remaining display
            DateTime startTime = Script.TimeData.TimeStarted;
            DateTime finishTime = startTime.AddMinutes(Script.TimeData.Minutes);
            TimeSpan ts = finishTime - DateTime.Now;
            lblTimeRemainingTimer.Text = $"{ts.Hours.ToString("00")}:{ts.Minutes.ToString("00")}:{ts.Seconds.ToString("00")}";
        }

        #endregion

        #region Radio Buttons

        private void rbOptionA_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = true;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            //TODO:: record answer
        }

        private void rbOptionB_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = true;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            //TODO:: record answer
        }

        private void rbOptionC_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = true;
            rbOptionD.Checked = false;

            //TODO:: record answer
        }

        private void rbOptionD_Click(object sender, EventArgs e)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = true;

            //TODO:: record answer
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

                        //TODO:: Select the answer that has been selected (if so)
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

                        //TODO:: Show the entered answer
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
