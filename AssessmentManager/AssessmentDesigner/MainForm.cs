using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AssessmentManager
{
    public partial class MainForm : Form
    {
        private Assessment assessment;

        private ColorDialog colorDialog = new ColorDialog();



        public MainForm()
        {
            InitializeComponent();

            comboBoxAnswerType.SelectedIndex = 3;
            NotifyNoAssessmentOpen();
        }

        public Assessment Assessment
        {
            get { return assessment; }
            private set { assessment = value; }
        }

        public bool HasAssessmentOpen
        {
            get { return Assessment != null; }
        }

        #region Toolstrip buttons
        private void toolStripButtonColour_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region MenuStripItems

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:: If a file is already open, check for changes and ask if the user wants to save.
            //TODO:: Display a dialog which asks for the course information

            Assessment = new Assessment(DateTime.Now);
            Assessment.AddQuestion("Question 1");
            NotifyAssessmentOpened();
            //TODO:: Populate tree view with questions in new assessment (will only have one) then select the first one.
            Util.PopulateTreeView(treeViewQuestionList, Assessment);
            treeViewQuestionList.SelectedNode = treeViewQuestionList.Nodes[0];
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAssessment();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = "test.xml";
            using (var stream = new FileStream(path, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Assessment));
                xml.Serialize(stream, Assessment);
            }
        }
        #endregion

        #region TreeViewButtons
        private void buttonAddMajorQuestion_Click(object sender, EventArgs e)
        {
            treeViewQuestionList.Nodes.Add(new QuestionNode(new Question("unnamed")));
            Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
            treeViewQuestionList.Focus();
        }

        private void buttonAddSubQuestion_Click(object sender, EventArgs e)
        {
            if (treeViewQuestionList.SelectedNode != null)
            {
                QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;

                Question subQ = new Question("unnamed");

                node.Nodes.Add(new QuestionNode(subQ));
                node.Expand();
                Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
            }
            treeViewQuestionList.Focus();
        }
        #endregion

        #region Methods
        private void NotifyNoAssessmentOpen()
        {
            //Disable buttons
            panelButtons.Enabled = false;
            //Disable question editing area
            tableLayoutPanelDesignerContainer.Enabled = false;
            //Disable marks assign thingy
            numericUpDownMarksAssigner.Enabled = false;
            //Hide marks assignment information
            groupBoxMarks.Visible = false;
            //Disable treeview
            treeViewQuestionList.Enabled = false;
            //Disable menustrip buttons
            checkForQuestionsWithoutMarksToolStripMenuItem.Enabled = false;
            makePdfOfExamToolStripMenuItem.Enabled = false;
            assessmentInformationToolStripMenuItem.Enabled = false;
            exportToXMLToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveasToolStripMenuItem.Enabled = false;
        }

        private void NotifyAssessmentOpened()
        {
            //Enable buttons
            panelButtons.Enabled = true;
            //Enable question editing area
            tableLayoutPanelDesignerContainer.Enabled = true;
            //Enable marks assign thingy
            numericUpDownMarksAssigner.Enabled = true;
            //Show marks assignment information
            groupBoxMarks.Visible = true;
            //Enable treeview
            treeViewQuestionList.Enabled = true;
            //Enable menustrip buttons
            checkForQuestionsWithoutMarksToolStripMenuItem.Enabled = true;
            makePdfOfExamToolStripMenuItem.Enabled = true;
            assessmentInformationToolStripMenuItem.Enabled = true;
            exportToXMLToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            saveasToolStripMenuItem.Enabled = true;
        }

        private void CloseAssessment()
        {
            //TODO:: check for changes and prompt to save if needed. Perform proper closing action.
            Assessment = null;
            treeViewQuestionList.Nodes.Clear();
            NotifyNoAssessmentOpen();
        }
        #endregion


        private void comboBoxAnswerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:: Asign answer type to question. If there is no assessment open then don't do this.
            switch (comboBoxAnswerType.Text)
            {
                case "None":
                    {
                        panelAnswerMultiChoice.Visible = false;
                        panelAnswerOpen.Visible = false;
                        panelAnswerSingle.Visible = false;

                        break;
                    }
                case "Multi-choice":
                    {
                        panelAnswerMultiChoice.Visible = true;
                        panelAnswerOpen.Visible = false;
                        panelAnswerSingle.Visible = false;

                        break;
                    }
                case "Open":
                    {
                        panelAnswerMultiChoice.Visible = false;
                        panelAnswerOpen.Visible = true;
                        panelAnswerSingle.Visible = false;

                        break;
                    }
                case "Single":
                    {
                        panelAnswerMultiChoice.Visible = false;
                        panelAnswerOpen.Visible = false;
                        panelAnswerSingle.Visible = true;

                        break;
                    }
            }
        }

        private void treeViewQuestionList_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO:: listen for delete key pressed, try delete selected node
        }
    }
}
