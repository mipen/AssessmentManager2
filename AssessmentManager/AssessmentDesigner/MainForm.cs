using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static AssessmentManager.CONSTANTS;

namespace AssessmentManager
{
    public partial class MainForm : Form
    {
        private Assessment assessment;
        private FileInfo file;
        private ColorDialog colorDialog = new ColorDialog();
        private SaveFileDialog xmlSaveFileDialog = new SaveFileDialog();
        private SaveFileDialog mainSaveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private CourseManager CourseManager = new CourseManager();

        private string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public const int MaxNumSubQuestionLevels = 3;

        private bool designerChangesMade = false;

        public MainForm()
        {
            InitializeComponent();

            NotifyAssessmentClosed();

            //Initialise the xml save file dialog
            xmlSaveFileDialog.Filter = XML_FILTER;
            xmlSaveFileDialog.DefaultExt = XML_EXT.Remove(0, 1);
            xmlSaveFileDialog.InitialDirectory = DESKTOP_PATH;

            //Initialise main save file dialog
            mainSaveFileDialog.Filter = ASSESSMENT_FILTER;
            mainSaveFileDialog.DefaultExt = ASSESSMENT_EXT.Remove(0, 1);

            //Initialise open file dialog
            openFileDialog.InitialDirectory = DESKTOP_PATH;
            openFileDialog.Filter = ASSESSMENT_FILTER;
            openFileDialog.DefaultExt = ASSESSMENT_EXT.Remove(0, 1);

            //Initialise the recent files menu
            UpdateRecentFiles();

            //Initialise the font combo boxes
            InitialiseFontComboBoxes();

            //Do the initialisation for the course tab
            InitialiseCourseTab();
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

        #region Designer

        public bool DesignerChangesMade
        {
            get
            {
                return HasAssessmentOpen && designerChangesMade;
            }
            set
            {
                designerChangesMade = value;
            }
        }

        #region Toolstrip buttons
        private void toolStripButtonColour_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripButtonColour.BackColor = colorDialog.Color;
                richTextBoxQuestion.SelectionColor = colorDialog.Color;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.Paste();
        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;

            if (richTextBoxQuestion.SelectionFont.Style.HasFlag(FontStyle.Bold))
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style & ~FontStyle.Bold;
            }
            else
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style | FontStyle.Bold;
            }
            richTextBoxQuestion.SelectionFont = new Font(richTextBoxQuestion.SelectionFont, newStyle);
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;

            if (richTextBoxQuestion.SelectionFont.Style.HasFlag(FontStyle.Italic))
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style & ~FontStyle.Italic;
            }
            else
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style | FontStyle.Italic;
            }
            richTextBoxQuestion.SelectionFont = new Font(richTextBoxQuestion.SelectionFont, newStyle);
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;

            if (richTextBoxQuestion.SelectionFont.Style.HasFlag(FontStyle.Underline))
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style & ~FontStyle.Underline;
            }
            else
            {
                newStyle = richTextBoxQuestion.SelectionFont.Style | FontStyle.Underline;
            }
            richTextBoxQuestion.SelectionFont = new Font(richTextBoxQuestion.SelectionFont, newStyle);
        }

        private void toolStripButtonAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonAlignCentre_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonAlignRight_Click(object sender, EventArgs e)
        {
            richTextBoxQuestion.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButtonBulletList_Click(object sender, EventArgs e)
        {
            //TODO:: this
            MessageBox.Show("Not yet done");
        }

        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBoxQuestion.SelectionFont = new Font(toolStripComboBoxFont.Text, richTextBoxQuestion.SelectionFont.Size, richTextBoxQuestion.SelectionFont.Style);
            }
            catch
            {
            }
        }

        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBoxQuestion.SelectionFont = new Font(richTextBoxQuestion.SelectionFont.Name, float.Parse(toolStripComboBoxSize.Text), richTextBoxQuestion.SelectionFont.Style);
            }
            catch
            {
            }
        }
        #endregion

        #region MenuStripItems

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseAssessment() == DialogResult.OK)
            {
                //TODO:: Prompt to do initial save here
                AssessmentInformationForm aif = new AssessmentInformationForm();
                aif.StartPosition = FormStartPosition.CenterParent;
                if (aif.ShowDialog() == DialogResult.OK)
                {
                    Assessment = new Assessment();
                    Assessment.AddQuestion("Question 1");
                    AssessmentInformationForm.PopulateAssessmentInformation(Assessment, aif);
                    //Prompt the user to do an initial save here. This is to set up the path and allow for autosaving
                    MessageBox.Show("Please do an initial save. This will allow the program to perform autosaves.", "Initial save");
                    if (SaveToFile() == DialogResult.OK)
                    {
                        NotifyAssessmentOpened();
                        designerChangesMade = true;
                    }
                    else
                    {
                        Assessment = null;
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAssessment();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasAssessmentOpen && xmlSaveFileDialog.ShowDialog() == DialogResult.OK)
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
            if (HasAssessmentOpen)
            {
                if (file == null)
                {
                    mainSaveFileDialog.InitialDirectory = DefaultPath;
                    SaveToFile();
                }
                else
                {
                    SaveToFile(file.FullName);
                }
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasAssessmentOpen)
            {
                SaveToFile();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseAssessment() == DialogResult.OK)
            {
                OpenFromFile();
            }
        }

        private void checkForQuestionsWithoutMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasAssessmentOpen)
            {
                List<Question> list = Assessment.CheckMissingMarks();
                if (list.Count > 0)
                {
                    list.Sort((a, b) => a.Name.CompareTo(b.Name));

                    string questions = "";
                    foreach (var q in list)
                        questions += q.Name + "\n";

                    MessageBox.Show("These questions do not have any marks assigned: \n\n" + questions, "Unassigned marks");
                }
            }
        }

        private void assessmentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HasAssessmentOpen)
            {
                AssessmentInformationForm aif = AssessmentInformationForm.FromAssessment(Assessment);
                if (aif.ShowDialog() == DialogResult.OK)
                {
                    AssessmentInformationForm.PopulateAssessmentInformation(Assessment, aif);
                    DesignerChangesMade = true;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseAssessment() == DialogResult.OK)
                Close();
        }

        #endregion

        #region TreeViewButtons
        private void buttonAddMajorQuestion_Click(object sender, EventArgs e)
        {
            QuestionNode node = new QuestionNode(new Question("unnamed"));
            treeViewQuestionList.Nodes.Add(node);
            Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
            designerChangesMade = true;
            treeViewQuestionList.SelectedNode = node;
            treeViewQuestionList.Focus();
        }

        private void buttonAddSubQuestion_Click(object sender, EventArgs e)
        {
            if (treeViewQuestionList.SelectedNode != null)
            {
                QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;

                //Check the node is able to have sub nodes(sub questions)
                if (node.Level >= MaxNumSubQuestionLevels - 1)
                {
                    treeViewQuestionList.Focus();
                    return;
                }

                Question subQ = new Question("unnamed");

                node.Nodes.Add(new QuestionNode(subQ));
                node.Expand();
                Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                designerChangesMade = true;
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
                    designerChangesMade = true;
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
                    designerChangesMade = true;
                }
                catch { }
            }
            treeViewQuestionList.Focus();
        }
        #endregion

        #region Methods
        private void NotifyAssessmentClosed()
        {
            //Disable buttons
            panelButtons.Enabled = false;
            //Disable question editing area
            tableLayoutPanelDesignerContainer.Enabled = false;
            //Clear the question text
            richTextBoxQuestion.Text = "";
            //Clear the question name
            labelQuestion.Text = "";
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
            //Reset the fileinfo
            file = null;
            //Reset the form text
            UpdateFormText();
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
            UpdateFormText();
            //Populate the treeview with the questions from the assessment
            Util.PopulateTreeView(treeViewQuestionList, Assessment);
            if (treeViewQuestionList.Nodes.Count > 0) treeViewQuestionList.SelectedNode = treeViewQuestionList.Nodes[0];
            //No changes will have been made yet
            designerChangesMade = false;
        }

        private void InitialiseFontComboBoxes()
        {
            for (int i = 8; i <= 75; i++)
            {
                toolStripComboBoxSize.Items.Add(i.ToString());
            }

            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (var f in fonts.Families)
            {
                toolStripComboBoxFont.Items.Add(f.Name);
            }
        }

        /// <summary>
        /// Closes the open assessment.
        /// </summary>
        /// <returns>Returns DialogResult.Cancel if the user cancels saving and closing the document. Returns DialogResult.OK if it closes the document.</returns>
        private DialogResult CloseAssessment()
        {
            if (DesignerChangesMade)
            {
                DialogResult result = MessageBox.Show("Changes have been made to this Assessment. Closing it now will cause those changes to be lost. Would you like to save before closing?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (file == null)
                    {
                        if (SaveToFile() == DialogResult.Cancel)
                            return DialogResult.Cancel;
                    }
                    else
                    {
                        SaveToFile(file.FullName);
                    }
                }
                else if (result == DialogResult.Cancel)
                    return DialogResult.Cancel;
            }
            Assessment = null;
            treeViewQuestionList.Nodes.Clear();
            NotifyAssessmentClosed();
            return DialogResult.OK;
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
                    //labelMarksSelectedQuestionNum.Text = q.Marks.ToString();
                    labelMarksSelectedQuestionNum.Text = q.Marks.ToString() + $" ({q.TotalMarks.ToString()} total)";

                    //If the question has a parent, display total marks for that question
                    if (node.Parent != null)
                    {
                        Question parentQ = ((QuestionNode)node.Parent).Question;

                        labelMarksSelectedQuestionParent.Text = parentQ.Name + ":";
                        //labelMarksSelectedQuestionParentNum.Text = parentQ.TotalMarks.ToString();
                        labelMarksSelectedQuestionParentNum.Text = parentQ.Marks.ToString() + $" ({parentQ.TotalMarks.ToString()} total)";

                        labelMarksSelectedQuestionParent.Visible = true;
                        labelMarksSelectedQuestionParentNum.Visible = true;

                        //If there is another level of questions above the parent, display those
                        if (node.Parent.Parent != null)
                        {
                            Question parentParentQ = ((QuestionNode)node.Parent.Parent).Question;

                            labelMarksSelectedQuestionParentParent.Text = parentParentQ.Name + ":";
                            //labelMarksSelectedQuestionParentParentNum.Text = parentParentQ.TotalMarks.ToString();
                            labelMarksSelectedQuestionParentParentNum.Text = parentParentQ.Marks.ToString() + $" ({parentParentQ.TotalMarks.ToString()} total)";

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
                        //Disable parent marks text boxes if there is no parent
                        labelMarksSelectedQuestionParent.Visible = false;
                        labelMarksSelectedQuestionParentNum.Visible = false;

                        //Also disable the parent parent text
                        labelMarksSelectedQuestionParentParent.Visible = false;
                        labelMarksSelectedQuestionParentParentNum.Visible = false;
                    }
                }
                catch
                {
                }
            }
        }

        private void UpdateFormText()
        {
            Text = file == null ? "Assessment Designer" : "Assessment Designer - " + file.Name;
        }

        private void UpdateRecentFiles()
        {
            recentToolStripMenuItem.DropDownItems.Clear();
            foreach (var path in Settings.Instance.RecentFiles)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = path;
                item.Tag = path;
                item.Size = new Size(100, 22);
                item.Click += (sender, e) =>
                {
                    if (DesignerChangesMade)
                    {
                        DialogResult result = MessageBox.Show("There are unsaved changes. Do you wish to save before opening a new file?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            if (file == null)
                            {
                                if (SaveToFile() == DialogResult.Cancel)
                                    return;
                            }
                            else
                                SaveToFile(file.FullName);
                        }
                        else if (result == DialogResult.Cancel)
                            return;
                    }
                    OpenFromFile(item.Tag.ToString());
                };
                recentToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        /// <summary>
        /// Save the currently open Assessment to file. Does not display SaveFileDialog, but instead is given the path to save to.
        /// </summary>
        /// <param name="path">The specified path to save the Assessment to.</param>
        private void SaveToFile(string path)
        {
            //Save the file here
            if (HasAssessmentOpen)
            {
                try
                {
                    using (FileStream s = File.Open(path, FileMode.Create, FileAccess.Write))
                    {
                        Assessment.Published = false;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(s, Assessment);
                    }
                    file = new FileInfo(path);
                    designerChangesMade = false;
                    UpdateFormText();
                    Settings.Instance.AddRecentFile(path);
                    UpdateRecentFiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save: \n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Save the currently open Assessment to file. Displays the SaveFileDialog
        /// </summary>
        private DialogResult SaveToFile()
        {
            if (HasAssessmentOpen)
            {
                DialogResult result = mainSaveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SaveToFile(mainSaveFileDialog.FileName);
                }
                return result;
            }
            return DialogResult.Cancel;
        }

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
                    Settings.Instance.AddRecentFile(path);
                    UpdateRecentFiles();
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFromFile(openFileDialog.FileName);
            }
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


                    //Disable add sub question if question is at max level
                    bool subQuestionFlag = false;
                    if (node.Level >= MaxNumSubQuestionLevels - 1)
                    {
                        contextMenuAddSubQuestion.Visible = false;
                        subQuestionFlag = true;
                    }
                    else
                        contextMenuAddSubQuestion.Visible = true;
                    //Disable the separator
                    if (subQuestionFlag)
                        contextMenuSeparatorSubQuestion.Visible = false;
                    else
                        contextMenuSeparatorSubQuestion.Visible = true;

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
                richTextBoxQuestion.Rtf = node.Question.QuestionText;
                //Hide the marks assigner if the quesiton doesn't have an answer
                if (node.Question.AnswerType == AnswerType.None)
                {
                    labelMarksForQuestion.Visible = false;
                    numericUpDownMarksAssigner.Visible = false;
                }
                else
                {
                    labelMarksForQuestion.Visible = true;
                    numericUpDownMarksAssigner.Visible = true;
                    //Display the marks in the numeric up/down
                    numericUpDownMarksAssigner.Value = node.Question.Marks;
                }
                //Update the mark allocations
                UpdateMarkAllocations();

                //Update the font combo boxes
                toolStripComboBoxFont.SelectedItem = richTextBoxQuestion.SelectionFont.Name;
                toolStripComboBoxSize.SelectedItem = ((int)richTextBoxQuestion.SelectionFont.Size).ToString();
                //Update the colour button
                toolStripButtonColour.BackColor = richTextBoxQuestion.SelectionColor;

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
                            break;
                        }
                    case AnswerType.Single:
                        {
                            comboBoxAnswerType.SelectedItem = "Single";
                            //Display the answers
                            richTextBoxAnswerSingleAcceptable.Text = node.Question.ModelAnswer;
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
                //Disable the subquestion button if the question cannot have any more subquestions
                if (node.Level >= MaxNumSubQuestionLevels - 1)
                    buttonAddSubQuestion.Enabled = false;
                else
                    buttonAddSubQuestion.Enabled = true;
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
                if (node.Parent != null)
                {
                    node.Parent.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                }
                else
                {
                    treeViewQuestionList.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                    Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                }
                treeViewQuestionList.SelectedNode = null;
                treeViewQuestionList.SelectedNode = node;
            }
            treeViewQuestionList.Focus();
        }

        private void contextMenuInsertBelow_Click(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                int indexToInsertTo = node.Index + 1;
                if (indexToInsertTo < 0) indexToInsertTo = 0;
                if (node.Parent == null)
                {
                    if (!node.CanMoveDown) buttonAddMajorQuestion_Click(sender, e);
                    else
                    {
                        treeViewQuestionList.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                        Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                    }
                }
                else
                {
                    if (!node.CanMoveDown)
                    {
                        node.Parent.Nodes.Add(new QuestionNode(new Question("unnamed")));
                        Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                    }
                    else
                    {
                        node.Parent.Nodes.Insert(indexToInsertTo, new QuestionNode(new Question("unnamed")));
                        Util.RebuildAssessmentQuestionList(Assessment, treeViewQuestionList);
                    }
                }
                treeViewQuestionList.SelectedNode = null;
                treeViewQuestionList.SelectedNode = node;
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
                                //Hide the marks assigner
                                labelMarksForQuestion.Visible = false;
                                numericUpDownMarksAssigner.Visible = false;
                                UpdateMarkAllocations();
                                //Hide answer label
                                labelAnswerText.Visible = false;
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
                                //Show the marks assigner
                                labelMarksForQuestion.Visible = true;
                                numericUpDownMarksAssigner.Visible = true;
                                UpdateMarkAllocations();
                                //Show answer label
                                labelAnswerText.Visible = true;
                                break;
                            }
                        case "Single":
                            {
                                node.Question.AnswerType = AnswerType.Single;
                                //Display the answers
                                richTextBoxAnswerSingleAcceptable.Text = node.Question.ModelAnswer;
                                //Show the marks assigner
                                labelMarksForQuestion.Visible = true;
                                numericUpDownMarksAssigner.Visible = true;
                                UpdateMarkAllocations();
                                //Show answer label
                                labelAnswerText.Visible = true;
                                break;
                            }
                        case "Open":
                            {
                                node.Question.AnswerType = AnswerType.Open;
                                //Display the answer
                                richTextBoxAnswerOpen.Text = node.Question.ModelAnswer;
                                //Show the marks assigner
                                labelMarksForQuestion.Visible = true;
                                numericUpDownMarksAssigner.Visible = true;
                                UpdateMarkAllocations();
                                //Show answer label
                                labelAnswerText.Visible = true;
                                break;
                            }
                    }
                    designerChangesMade = true;
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
                node.Question.QuestionText = richTextBoxQuestion.Rtf;
                designerChangesMade = true;
            }
        }

        private void richTextBoxQuestion_SelectionChanged(object sender, EventArgs e)
        {
            //Set the values of the font combo boxes to the selected font
            toolStripComboBoxFont.SelectedItem = richTextBoxQuestion.SelectionFont.Name;
            toolStripComboBoxSize.SelectedItem = ((int)richTextBoxQuestion.SelectionFont.Size).ToString();
            toolStripButtonColour.BackColor = richTextBoxQuestion.SelectionColor;
        }

        private void richTextBoxAnswerOpen_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.ModelAnswer = richTextBoxAnswerOpen.Text;
                designerChangesMade = true;
            }
        }

        private void richTextBoxAnswerSingleAcceptable_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.ModelAnswer = richTextBoxAnswerSingleAcceptable.Text;
                designerChangesMade = true;
            }
        }

        private void textBoxMultiChoiceA_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionA = textBoxMultiChoiceA.Text;
                designerChangesMade = true;
            }
        }

        private void textBoxMultiChoiceB_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionB = textBoxMultiChoiceB.Text;
                designerChangesMade = true;
            }
        }

        private void textBoxMultiChoiceC_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionC = textBoxMultiChoiceC.Text;
                designerChangesMade = true;
            }
        }

        private void textBoxMultiChoiceD_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionD = textBoxMultiChoiceD.Text;
                designerChangesMade = true;
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
                designerChangesMade = true;
            }
        }

        private void numericUpDownMarksAssigner_ValueChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.Marks = (int)numericUpDownMarksAssigner.Value;
                designerChangesMade = true;
                UpdateMarkAllocations();
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DesignerChangesMade)
            {
                DialogResult result = MessageBox.Show("Changes have been made to this Assessment. Closing it now will cause those changes to be lost. Would you like to save before closing?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (file == null)
                    {
                        if (SaveToFile() == DialogResult.Cancel)
                            e.Cancel = true;
                    }
                    else
                        SaveToFile(file.FullName);
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
            Settings.Instance.Save();
        }

        private void toolStripButtonAddImage_Click(object sender, EventArgs e)
        {
            QuestionNode qn = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (qn != null)
            {
                Question q = qn.Question;
                ImageSelector i;

                if (q.Image != null)
                {
                    i = new ImageSelector(q.Name, q.Image);
                }
                else
                {
                    i = new ImageSelector(q.Name);
                }

                if (i.ShowDialog() == DialogResult.OK)
                {
                    q.Image = i.Image;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Hotkey for next/prev question in designer tab
            if (tabControlMain.SelectedTab.Name == "tabPageDesigner")
            {
                if (e.KeyCode == Keys.F4)
                {
                    QuestionNode node = treeViewQuestionList.SelectedNode as QuestionNode;
                    if (node != null)
                    {
                        treeViewQuestionList.SelectedNode = node.PrevVisibleNode;
                    }
                    treeViewQuestionList.Focus();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.F5)
                {
                    QuestionNode node = treeViewQuestionList.SelectedNode as QuestionNode;
                    if (node != null)
                    {
                        treeViewQuestionList.SelectedNode = node.PrevVisibleNode;
                    }
                    treeViewQuestionList.Focus();
                    e.Handled = true;
                }
            }
        }

        #endregion

        #region CourseManagerTab

        #region Methods

        private void InitialiseCourseTab()
        {
            //course and assessment session panels initially disabled and cannot be viewed
            pnlAssessmentView.Visible = false;
            pnlAssessmentView.Enabled = false;
            pnlCourseView.Visible = false;
            pnlCourseView.Enabled = false;
            //Initialise the course manager
            CourseManager.Initialise(tvCourses);

        }

        #endregion

        #region Events

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            NewCourseForm ncf = new NewCourseForm();
            ncf.StartPosition = FormStartPosition.CenterParent;
            if(ncf.ShowDialog()==DialogResult.OK)
            {
                CourseManager.RegisterNewCourse(ncf.GetCourse);
            }
        }

        private void tbCourseSearch_TextChanged(object sender, EventArgs e)
        {
            if (!tbCourseSearch.Text.NullOrEmpty())
            {
                CourseManager.RebuildTreeView(tbCourseSearch.Text);
            }
            else
                CourseManager.RebuildTreeView();
        }

        private void tvCourses_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node is CourseNode)
            {
                CourseNode node = e.Node as CourseNode;
                Course course = node.Course;
                CourseInformation info = course.CourseInfo;
                //Show the course panel and hide the session panel
                pnlCourseView.Visible = true;
                pnlCourseView.Enabled = true;
                pnlAssessmentView.Visible = false;
                pnlAssessmentView.Enabled = false;

                //Show the course information
                tbCourseName.Text = info.CourseName;
                tbCourseCode1.Text = info.CourseCodeSeparated[0];
                tbCourseCode2.Text = info.CourseCodeSeparated[1];
                nudCourseYear.Value = int.Parse(info.Year);
                cbCourseSemester.SelectedItem = info.Semester;

                //Show all the students
                dgvCourseStudents.Rows.Clear();
                foreach (Student s in course.Students)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCourseStudents);
                    row.Cells[0].Value = s.UserName;
                    row.Cells[1].Value = s.LastName;
                    row.Cells[2].Value = s.FirstName;
                    row.Cells[3].Value = s.StudentNumber;
                    dgvCourseStudents.Rows.Add(row);
                }
            }
            else if(e.Node is AssessmentSessionNode)
            {
                AssessmentSessionNode node = e.Node as AssessmentSessionNode;
                //TODO:: Session related stuff here
                //Show the session panel and hide course panel
            }
        }

        private void btnImportStudents_Click(object sender, EventArgs e)
        {
            //TODO:: Import student data from another course
        }

        private void btnApplyCourseChanges_Click(object sender, EventArgs e)
        {
            //TODO::
        }

        #endregion

        #endregion

    }
}
