using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void buttonExpandAll_Click(object sender, EventArgs e)
        {
            treeViewQuestionList.ExpandAll();
            treeViewQuestionList.Focus();
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            treeViewQuestionList.CollapseAll();
            treeViewQuestionList.Focus();
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null && node.CanMoveUp)
            {
                try
                {
                    int indexToInsertTo = node.Index - 1;
                    if (indexToInsertTo < 0) indexToInsertTo = 0;
                    TreeNodeCollection collection = node.Parent != null ? node.Parent.Nodes : node.TreeView.Nodes;
                    node.Remove();
                    collection.Insert(indexToInsertTo, node);
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                    treeViewQuestionList.SelectedNode = node;
                }
                catch { }
            }
            treeViewQuestionList.Focus();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null && node.CanMoveDown)
            {
                try
                {
                    int indexToInsertTo = node.Index + 1;
                    TreeNodeCollection collection = node.Parent != null ? node.Parent.Nodes : node.TreeView.Nodes;
                    node.Remove();
                    collection.Insert(indexToInsertTo, node);
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                    treeViewQuestionList.SelectedNode = node;
                }
                catch { }
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

        private bool DeleteNode(QuestionNode node)
        {
            if (node != null && MessageBox.Show("Are you sure you want to delete this question?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    node.Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                return true;
            }
            return false;
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

        #region TreeView Events
        private void treeViewQuestionList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //This opens the context menu for the node the user right-clicked.
                //Get the point where the user clicked
                Point p = new Point(e.X, e.Y);

                //Get the node that the user clicked
                QuestionNode node = (QuestionNode)treeViewQuestionList.GetNodeAt(p);
                if (node != null)
                {
                    //Select the node
                    treeViewQuestionList.SelectedNode = node;

                    //Configure the context menu for the given node

                    //Disable the move up if it is at the top
                    bool flag1 = false, flag2 = false;
                    if (!node.CanMoveUp)
                    {
                        contextMenuMoveUp.Visible = false;
                        flag1 = true;
                    }
                    else
                    {
                        contextMenuMoveUp.Visible = true;
                    }
                    //Disable move down if it is at the bottom
                    if (!node.CanMoveDown)
                    {
                        contextMenuMoveDown.Visible = false;
                        flag2 = true;
                    }
                    else
                    {
                        contextMenuMoveDown.Visible = true;
                    }
                    //Disable the separator if both move up and move down are disabled
                    if (flag1 && flag2)
                    {
                        contextMenuSeparatorMove.Visible = false;
                    }
                    else
                        contextMenuSeparatorMove.Visible = true;

                    //Show the contextmenu
                    contextMenuStripQuestionNode.Show(treeViewQuestionList, p);
                }
            }
        }

        private void treeViewQuestionList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
                if (node != null)
                {
                    DeleteNode(node);
                }
            }
        }
        #endregion

        #region ContextMenu Events
        private void contextMenuDelete_Click(object sender, EventArgs e)
        {
            DeleteNode((QuestionNode)treeViewQuestionList.SelectedNode);
        }

        private void contextMenuInsertAbove_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                int indexToInsertTo = node.Index - 1;
                if (indexToInsertTo < 0) indexToInsertTo = 0;

                treeViewQuestionList.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);

            }
            treeViewQuestionList.Focus();
        }

        private void contextMenuInsertBelow_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                if (!node.CanMoveDown) buttonAddMajorQuestion_Click(sender, e);
                else
                {
                    int indexToInsertTo = node.Index + 1;
                    if (indexToInsertTo < 0) indexToInsertTo = 0;

                    treeViewQuestionList.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                }
            }
            treeViewQuestionList.Focus();
        }

        private void contextMenuMoveUp_Click(object sender, EventArgs e)
        {
            buttonMoveUp_Click(sender, e);
        }

        private void contextMenuMoveDown_Click(object sender, EventArgs e)
        {
            buttonMoveDown_Click(sender, e);
        }

        private void contextMenuAddSubQuestion_Click(object sender, EventArgs e)
        {
            buttonAddSubQuestion_Click(sender, e);
        }
        #endregion

    }
}
