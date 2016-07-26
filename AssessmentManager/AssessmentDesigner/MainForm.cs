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

        public const string AssessmentExtension = ".exm";
        public const string XMLExtension = ".xml";
        private string DefaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public const int MaxNumSubQuestionLevels = 3;

        private bool changesMade = false;

        public MainForm()
        {
            InitializeComponent();

            NotifyAssessmentClosed();

            //Initialise the xml save file dialog
            xmlSaveFileDialog.Filter = $"XML Document (*{XMLExtension}) | *{XMLExtension}";
            xmlSaveFileDialog.DefaultExt = XMLExtension.Remove(0, 1);
            xmlSaveFileDialog.InitialDirectory = DefaultPath;

            //Initialise main save file dialog
            mainSaveFileDialog.Filter = $"Assessment File (*{AssessmentExtension}) | *{AssessmentExtension}";
            mainSaveFileDialog.DefaultExt = AssessmentExtension.Remove(0, 1);

            //Initialise open file dialog
            openFileDialog.InitialDirectory = DefaultPath;
            openFileDialog.Filter = $"Assessment File (*{AssessmentExtension}) | *{AssessmentExtension}";
            openFileDialog.DefaultExt = AssessmentExtension.Remove(0, 1);

            //Initialise the recent files menu
            UpdateRecentFiles();

            //Initialise the font combo boxes
            InitialiseFontComboBoxes();
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

        public bool ChangesMade
        {
            get
            {
                return HasAssessmentOpen && changesMade;
            }
            set
            {
                changesMade = value;
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
            Font bFont = new Font(richTextBoxQuestion.Font, FontStyle.Bold);
            Font rFont = new Font(richTextBoxQuestion.Font, FontStyle.Regular);

            if (richTextBoxQuestion.SelectionFont.Bold)
            {
                richTextBoxQuestion.SelectionFont = rFont;
            }
            else
                richTextBoxQuestion.SelectionFont = bFont;
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            Font iFont = new Font(richTextBoxQuestion.Font, FontStyle.Italic);
            Font rFont = new Font(richTextBoxQuestion.Font, FontStyle.Regular);

            if (richTextBoxQuestion.SelectionFont.Italic)
                richTextBoxQuestion.SelectionFont = rFont;
            else
                richTextBoxQuestion.SelectionFont = iFont;
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            Font uFont = new Font(richTextBoxQuestion.Font, FontStyle.Underline);
            Font rFont = new Font(richTextBoxQuestion.Font, FontStyle.Regular);

            if (richTextBoxQuestion.SelectionFont.Underline)
                richTextBoxQuestion.SelectionFont = rFont;
            else
                richTextBoxQuestion.SelectionFont = uFont;
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
            //TODO:: If a file is already open, check for changes and ask if the user wants to save.
            //TODO:: Display a dialog which asks for the course information

            Assessment = new Assessment(DateTime.Now);
            Assessment.AddQuestion("Question 1");
            NotifyAssessmentOpened();
            changesMade = true;
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
            if (ChangesMade)
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
            OpenFromFile();
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
                CourseInformationForm cif = new CourseInformationForm();
                if (Assessment.Course.CourseCode != "" && Assessment.Course.CourseCode != null)
                {
                    cif.CourseCode = Assessment.Course.CourseCode;
                }
                cif.Author = Assessment.Course.Author;
                if (cif.ShowDialog() == DialogResult.OK)
                {
                    Assessment.Course.Author = cif.Author;
                    Assessment.Course.CourseCode = cif.CourseCode;
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
            changesMade = true;
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
                changesMade = true;
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
                    changesMade = true;
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
                    changesMade = true;
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
            changesMade = false;
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
            if (ChangesMade)
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
                    if (ChangesMade)
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
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(s, Assessment);
                    }
                    file = new FileInfo(path);
                    changesMade = false;
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
                    changesMade = true;
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
                changesMade = true;
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
                changesMade = true;
            }
        }

        private void richTextBoxAnswerSingleAcceptable_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.ModelAnswer = richTextBoxAnswerSingleAcceptable.Text;
                changesMade = true;
            }
        }

        private void textBoxMultiChoiceA_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionA = textBoxMultiChoiceA.Text;
                changesMade = true;
            }
        }

        private void textBoxMultiChoiceB_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionB = textBoxMultiChoiceB.Text;
                changesMade = true;
            }
        }

        private void textBoxMultiChoiceC_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionC = textBoxMultiChoiceC.Text;
                changesMade = true;
            }
        }

        private void textBoxMultiChoiceD_TextChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.OptionD = textBoxMultiChoiceD.Text;
                changesMade = true;
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
                changesMade = true;
            }
        }

        private void numericUpDownMarksAssigner_ValueChanged(object sender, EventArgs e)
        {
            QuestionNode node = (QuestionNode)treeViewQuestionList.SelectedNode;
            if (node != null)
            {
                node.Question.Marks = (int)numericUpDownMarksAssigner.Value;
                changesMade = true;
                UpdateMarkAllocations();
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesMade)
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
            if(qn!= null)
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
    }
}
