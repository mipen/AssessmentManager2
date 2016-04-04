using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AssessmentManager
{
    public partial class MainForm : Form
    {
        private Assessment assessment;
        private string fileName = "";
        private string filePath = "";
        private ColorDialog colorDialog = new ColorDialog();
        private SaveFileDialog xmlSaveFileDialog = new SaveFileDialog();
        private SaveFileDialog mainSaveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();


        public MainForm()
        {
            InitializeComponent();

            NotifyNoAssessmentOpen();

            //Initialise the xml save file dialog
            xmlSaveFileDialog.Filter = "XML Document (*.xml) | *.xml";
            xmlSaveFileDialog.DefaultExt = "xml";
            xmlSaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Initialise main save file dialog
            mainSaveFileDialog.Filter = "Examination File (*.exm) | *.exm";
            mainSaveFileDialog.DefaultExt = "exm";

            //Initialise open file dialog
            openFileDialog.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter= "Examination File (*.exm) | *.exm";
            openFileDialog.DefaultExt= "exm";
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
            fileName = "Untitled";
            xmlSaveFileDialog.FileName = fileName;
            NotifyAssessmentOpened();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAssessment();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlSaveFileDialog.FileName = fileName;
            if (xmlSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(xmlSaveFileDialog.FileName, FileMode.Create))
                {
                    var xml = new XmlSerializer(typeof(Assessment));
                    xml.Serialize(stream, Assessment);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {

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
            //Need to also hide these two because they don't get set unless there is a parent question (In method UpdateMarkAllocations)
            labelMarksSelectedQuestionParentParent.Visible = false;
            labelMarksSelectedQuestionParentParentNum.Visible = false;
            //Disable treeview
            treeViewQuestionList.Enabled = false;
            //Disable menustrip buttons
            checkForQuestionsWithoutMarksToolStripMenuItem.Enabled = false;
            makePdfOfExamToolStripMenuItem.Enabled = false;
            assessmentInformationToolStripMenuItem.Enabled = false;
            exportToXMLToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveasToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Enabled = false;
            //Reset the form text
            Text = "AssessmentDesigner";
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
            closeToolStripMenuItem.Enabled = true;
            //Change form text
            Text = fileName == "" ? "AssessmentDesigner" : "AssessmentDesigner - " + fileName;
            //Populate the treeview with the questions from the assessment
            Util.PopulateTreeView(treeViewQuestionList, Assessment);
            if (treeViewQuestionList.Nodes.Count > 0) treeViewQuestionList.SelectedNode = treeViewQuestionList.Nodes[0];
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

        private void UpdateMarkAllocations()
        {
            //TODO:: include this method when opening an existing exam
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                Question q = node.Question;
                try
                {
                    //Display the marks for the whole assessment
                    labelMarksWholeAssessmentNum.Text = Assessment.TotalMarks.ToString();
                    //Display the marks for the selected question
                    labelMarksSelectedQuestion.Text = q.Name + ":";
                    labelMarksSelectedQuestionNum.Text = q.Marks.ToString();
                    //If the question has a parent, display total marks for that question
                    if (node.Parent != null)
                    {
                        Question parentQ = ((QuestionNode)node.Parent).Question;

                        labelMarksSelectedQuestionParent.Text = parentQ.Name + ":";
                        labelMarksSelectedQuestionParentNum.Text = parentQ.TotalMarks.ToString();

                        labelMarksSelectedQuestionParent.Visible = true;
                        labelMarksSelectedQuestionParentNum.Visible = true;

                        //If there is another level of questions above the parent, display those
                        if (node.Parent.Parent != null)
                        {
                            Question parentParentQ = ((QuestionNode)node.Parent.Parent).Question;

                            labelMarksSelectedQuestionParentParent.Text = parentParentQ.Name + ":";
                            labelMarksSelectedQuestionParentParentNum.Text = parentParentQ.TotalMarks.ToString();

                            labelMarksSelectedQuestionParentParent.Visible = true;
                            labelMarksSelectedQuestionParentParentNum.Visible = true;
                        }
                        else
                        {
                            labelMarksSelectedQuestionParentParent.Visible = false;
                            labelMarksSelectedQuestionParentParentNum.Visible = false;
                        }
                    }
                    else
                    {
                        labelMarksSelectedQuestionParent.Visible = false;
                        labelMarksSelectedQuestionParentNum.Visible = false;
                    }
                }
                catch
                {
                }
            }
        }

        private void SaveToFile(string path)
        {
            //Save the file here
            if (Assessment != null)
            {
                using (FileStream s = File.Open(path, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(s, Assessment);
                }
            }
        }

        private void SaveToFile()
        {
            //Use save file dialog here
        }

        private void OpenFromFile(string path)
        {
            //Open the file here

        }

        private void OpenFromFile()
        {
            //Use open file dialog here
        }
        #endregion

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

                    //Disable change level up if already top level
                    bool levelFlag1 = false, levelFlag2 = false;
                    if (node.Level == 0)
                    {
                        contextMenuChangeLevelUp.Visible = false;
                        levelFlag1 = true;
                    }
                    else
                        contextMenuChangeLevelUp.Visible = true;
                    //TODO:: Disable change level down if there is a limit on how many levels there are

                    //Disable the separator if both are hidden
                    if (levelFlag1 && levelFlag2)
                        contextMenuSeparatorChangeLevel.Visible = false;
                    else
                        contextMenuSeparatorChangeLevel.Visible = true;

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

        private void treeViewQuestionList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            QuestionNode node = (QuestionNode)e.Node;
            if (node != null)
            {
                //Display the question's name
                labelQuestion.Text = node.Question.Name;
                //Display the question's text
                richTextBoxQuestion.Text = node.Question.QuestionText;
                //Display the marks in the numeric up/down
                numericUpDownMarksAssigner.Value = node.Question.Marks;
                //Display the marks in the mark allocations box

                //Display the question's answer type
                switch (node.Question.AnswerType)
                {
                    case AnswerType.Multi:
                        {
                            comboBoxAnswerType.SelectedItem = "Multi-choice";
                            //Display the answers in the boxes
                            textBoxMultiChoiceA.Text = node.Question.OptionA;
                            textBoxMultiChoiceB.Text = node.Question.OptionB;
                            textBoxMultiChoiceC.Text = node.Question.OptionC;
                            textBoxMultiChoiceD.Text = node.Question.OptionD;
                            richTextBoxAnswerMultiComments.Text = node.Question.Comments;
                            break;
                        }
                    case AnswerType.Single:
                        {
                            comboBoxAnswerType.SelectedItem = "Single";
                            //Display the answers
                            richTextBoxAnswerSingleAcceptable.Text = node.Question.ModelAnswer;
                            richTextBoxAnswerSingleComment.Text = node.Question.Comments;
                            break;
                        }
                    case AnswerType.Open:
                        {
                            comboBoxAnswerType.SelectedItem = "Open";
                            //Display the answer
                            richTextBoxAnswerOpen.Text = node.Question.ModelAnswer;
                            break;
                        }
                    case AnswerType.None:
                        {
                            comboBoxAnswerType.SelectedItem = "None";
                            break;
                        }
                }
                //Display the correct multi choice option
                comboBoxAnswerMultiCorrect.SelectedItem = node.Question.CorrectOption.ToString();
                //Update the mark allocations
                UpdateMarkAllocations();
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

        private void contextMenuChangeLevelUp_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null && node.Level != 0)
            {
                //Two possibilities here:
                //A node will be second level, meaning its parent does not have a parent
                //Or a node's parent will also have a parent. So do two different things based on this fact.

                //Node's parent is top level:
                if (node.Parent.Level == 0)
                {
                    int index = node.Parent.Index + 1;
                    node.Remove();
                    treeViewQuestionList.Nodes.Insert(index, node);
                }
                else
                {
                    //Node's parent has a parent here
                    QuestionNode nodeToAddTo = (QuestionNode)node.Parent.Parent;
                    try
                    {
                        int index = node.Parent.Index + 1;
                        node.Remove();
                        nodeToAddTo.Nodes.Insert(index, node);
                    }
                    catch { }
                }
                treeViewQuestionList.SelectedNode = node;
                Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
            }
        }

        private void contextMenuChangeLevelDown_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                if (node.Parent != null)
                {
                    QuestionNode parent = (QuestionNode)node.Parent;
                    int index = node.Index;
                    node.Remove();
                    QuestionNode newRootNode = new QuestionNode(new Question("unnamed"));
                    parent.Nodes.Insert(index, newRootNode);
                    newRootNode.Nodes.Add(node);
                    newRootNode.Expand();
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                }
                else
                {
                    int index = node.Index;
                    QuestionNode newRootNode = new QuestionNode(new Question("unnamed"));
                    node.Remove();
                    treeViewQuestionList.Nodes.Insert(index, newRootNode);
                    newRootNode.Nodes.Add(node);
                    newRootNode.Expand();
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                }
                treeViewQuestionList.SelectedNode = node;
            }
        }
        #endregion

        #region QuestionEditingControls
        private void comboBoxAnswerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:: If 'None' is chosen, then don't allow any marks to be assigned. Maybe set marks to 0 as well

            if (HasAssessmentOpen)
            {
                QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
                if (node != null)
                {
                    switch (comboBoxAnswerType.Text)
                    {
                        case "None":
                            {
                                node.Question.AnswerType = AnswerType.None;
                                break;
                            }
                        case "Multi-choice":
                            {
                                node.Question.AnswerType = AnswerType.Multi;
                                //Display the answers in the boxes
                                textBoxMultiChoiceA.Text = node.Question.OptionA;
                                textBoxMultiChoiceB.Text = node.Question.OptionB;
                                textBoxMultiChoiceC.Text = node.Question.OptionC;
                                textBoxMultiChoiceD.Text = node.Question.OptionD;
                                richTextBoxAnswerMultiComments.Text = node.Question.Comments;
                                break;
                            }
                        case "Single":
                            {
                                node.Question.AnswerType = AnswerType.Single;
                                //Display the answers
                                richTextBoxAnswerSingleAcceptable.Text = node.Question.ModelAnswer;
                                richTextBoxAnswerSingleComment.Text = node.Question.Comments;
                                break;
                            }
                        case "Open":
                            {
                                node.Question.AnswerType = AnswerType.Open;
                                //Display the answer
                                richTextBoxAnswerOpen.Text = node.Question.ModelAnswer;
                                break;
                            }
                    }
                }
            }
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

        private void richTextBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.QuestionText = richTextBoxQuestion.Text;
            }
        }

        private void richTextBoxAnswerOpen_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.ModelAnswer = richTextBoxAnswerOpen.Text;
            }
        }

        private void richTextBoxAnswerSingleAcceptable_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.ModelAnswer = richTextBoxAnswerSingleAcceptable.Text;
            }
        }

        private void richTextBoxAnswerSingleComment_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.Comments = richTextBoxAnswerSingleComment.Text;
            }
        }

        private void textBoxMultiChoiceA_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionA = textBoxMultiChoiceA.Text;
            }
        }

        private void textBoxMultiChoiceB_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionB = textBoxMultiChoiceB.Text;
            }
        }

        private void textBoxMultiChoiceC_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionC = textBoxMultiChoiceC.Text;
            }
        }

        private void textBoxMultiChoiceD_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionD = textBoxMultiChoiceD.Text;
            }
        }

        private void richTextBoxAnswerMultiComments_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.Comments = richTextBoxAnswerMultiComments.Text;
            }
        }

        private void comboBoxAnswerMultiCorrect_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                switch (comboBoxAnswerMultiCorrect.Text)
                {
                    case "A":
                        {
                            node.Question.CorrectOption = MultiChoiceOption.A;
                            break;
                        }
                    case "B":
                        {
                            node.Question.CorrectOption = MultiChoiceOption.B;
                            break;
                        }
                    case "C":
                        {
                            node.Question.CorrectOption = MultiChoiceOption.C;
                            break;
                        }
                    case "D":
                        {
                            node.Question.CorrectOption = MultiChoiceOption.D;
                            break;
                        }
                }
            }
        }

        private void numericUpDownMarksAssigner_ValueChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.Marks = (int)numericUpDownMarksAssigner.Value;
                UpdateMarkAllocations();
            }
        }
        #endregion

    }
}
