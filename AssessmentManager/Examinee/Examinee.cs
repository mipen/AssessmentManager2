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

        private Assessment assessment;
        private FileInfo file;
        private string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        public Examinee()
        {
            InitializeComponent();
            NotifyAssessmentClosed();
        }

        public Examinee(string path)
        {
            InitializeComponent();
            OpenFromFile(path);
            if (treeViewQuestionDisplay.Nodes.Count > 0)
            {
                treeViewQuestionDisplay.SelectedNode = treeViewQuestionDisplay.Nodes[0];
            }
        }

        public Assessment Assessment
        {
            get { return assessment; }
            private set { assessment = value; }
        }

        public Question SelectedQuestion
        {
            get
            {
                return ((QuestionNode)treeViewQuestionDisplay.SelectedNode).Question;
            }
        }

        public QuestionNode SelectedNode
        {
            get
            {
                return (QuestionNode)treeViewQuestionDisplay.SelectedNode;
            }
        }

        #region Toolstrip Menu Items
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:: Implement saving on closing.
            this.Close();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            //TODO:: close the main form and open the splash screen
            OpenFromFile();
            if (treeViewQuestionDisplay.Nodes.Count > 0)
                treeViewQuestionDisplay.SelectedNode = treeViewQuestionDisplay.Nodes[0];
        }
        #endregion

        #region Methods

        /// <summary>
        /// Open an Assessment from file. Does not show an OpenFileDialog.
        /// </summary>
        /// <param name="path">The specified path for the file</param>
        public void OpenFromFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (FileStream s = File.Open(path, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Assessment = (Assessment)formatter.Deserialize(s);
                    }
                    file = new FileInfo(path);
                    NotifyAssessmentOpened();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load file: \n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"Unable to find the file at: {path}\n\n Failed to open.");
            }
        }

        /// <summary>
        /// Open an Assessment from file. Displays OpenFileDialog.
        /// </summary>
        public void OpenFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = $"Assessment File (*{Util.ASSESSMENT_EXT}) | *{Util.ASSESSMENT_EXT}";
            ofd.DefaultExt = Util.ASSESSMENT_EXT.Remove(0, 1);
            ofd.InitialDirectory = DefaultPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFromFile(ofd.FileName);
            }
        }

        public void NotifyAssessmentOpened()
        {
            //Enable all ui
            panelQuestionAnswer.Enabled = true;
            panelQuestionAnswer.Visible = true;

            panelLeft.Enabled = true;
            panelLeft.Visible = true;

            panelTop.Enabled = true;
            panelTop.Visible = true;

            //Enable the open button in the menu bar, disable save.
            toolStripMenuItemOpen.Enabled = false;
            toolStripMenuItemOpen.Visible = false;
            toolStripSeparatorOpen.Visible = false;

            saveToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Visible = true;
            toolStripSeparatorSave.Visible = true;

            //Load questions into tree view
            Util.PopulateTreeView(treeViewQuestionDisplay, Assessment);
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

            //Enable the open button in the menu bar, disable save.
            toolStripMenuItemOpen.Enabled = true;
            toolStripMenuItemOpen.Visible = true;
            toolStripSeparatorOpen.Visible = true;

            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Visible = false;
            toolStripSeparatorSave.Visible = false;
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
            labelMarksAttempted.Text = $"x / {Assessment.TotalMarks} marks attempted ((y)%)";
        }

        #endregion

        private void treeViewQuestionDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Display the question text
            rtbQuestion.Rtf = SelectedQuestion?.QuestionText;

            //Update the marks display
            UpdateMarksDisplay();

            //Show the correct answer page and any answer already entered
            switch (SelectedQuestion?.AnswerType)
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

            //Show or hide the image button
            //TODO:: Show/hide the image button
        }

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

        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
