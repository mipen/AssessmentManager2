namespace AssessmentManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForQuestionsWithoutMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePdfOfExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutAnswersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDesigner = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelDesignerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelQuestionContainer = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.toolStripQuestion = new System.Windows.Forms.ToolStrip();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignCentre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBulletList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBoxSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColour = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddImage = new System.Windows.Forms.ToolStripButton();
            this.panelQuestionNameContainer = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelAnswerAreaContainer = new System.Windows.Forms.Panel();
            this.panelAnswersContainer = new System.Windows.Forms.Panel();
            this.panelAnswerMultiChoice = new System.Windows.Forms.Panel();
            this.tableLayoutPanelAnswerMultiChoiceContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelMultiChoiceOptionsContainer = new System.Windows.Forms.Panel();
            this.labelAnswerMultiCorrect = new System.Windows.Forms.Label();
            this.comboBoxAnswerMultiCorrect = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMultiChoiceOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMultiChoiceD = new System.Windows.Forms.TableLayoutPanel();
            this.labelD = new System.Windows.Forms.Label();
            this.textBoxMultiChoiceD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMultiChoiceC = new System.Windows.Forms.TableLayoutPanel();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxMultiChoiceC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMultiChoiceB = new System.Windows.Forms.TableLayoutPanel();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxMultiChoiceB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMultiChoiceA = new System.Windows.Forms.TableLayoutPanel();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxMultiChoiceA = new System.Windows.Forms.TextBox();
            this.panelAnswerOpen = new System.Windows.Forms.Panel();
            this.richTextBoxAnswerOpen = new System.Windows.Forms.RichTextBox();
            this.panelAnswerSingle = new System.Windows.Forms.TableLayoutPanel();
            this.panelAnswerSingleAcceptableContainer = new System.Windows.Forms.Panel();
            this.richTextBoxAnswerSingleAcceptable = new System.Windows.Forms.RichTextBox();
            this.labelAnswerSingleAcceptable = new System.Windows.Forms.Label();
            this.panelAnswerTools = new System.Windows.Forms.Panel();
            this.labelAnswerType = new System.Windows.Forms.Label();
            this.comboBoxAnswerType = new System.Windows.Forms.ComboBox();
            this.labelAnswerText = new System.Windows.Forms.Label();
            this.treeViewQuestionList = new System.Windows.Forms.TreeView();
            this.contextMenuStripQuestionList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMajorQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddSubQuestion = new System.Windows.Forms.Button();
            this.buttonAddMajorQuestion = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.buttonExpandAll = new System.Windows.Forms.Button();
            this.panelMarks = new System.Windows.Forms.Panel();
            this.groupBoxMarks = new System.Windows.Forms.GroupBox();
            this.labelMarksSelectedQuestionParentParentNum = new System.Windows.Forms.Label();
            this.labelMarksSelectedQuestionParentNum = new System.Windows.Forms.Label();
            this.labelMarksSelectedQuestionNum = new System.Windows.Forms.Label();
            this.labelMarksWholeAssessmentNum = new System.Windows.Forms.Label();
            this.labelMarksWholeAssessment = new System.Windows.Forms.Label();
            this.labelMarksSelectedQuestionParentParent = new System.Windows.Forms.Label();
            this.labelMarksSelectedQuestionParent = new System.Windows.Forms.Label();
            this.labelMarksSelectedQuestion = new System.Windows.Forms.Label();
            this.numericUpDownMarksAssigner = new System.Windows.Forms.NumericUpDown();
            this.labelMarksForQuestion = new System.Windows.Forms.Label();
            this.contextMenuStripQuestionNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparatorSubQuestion = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuAddSubQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparatorInsert = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuInsertAbove = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuInsertBelow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparatorMove = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparatorChangeLevel = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuChangeLevelUp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuChangeLevelDown = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabPagePublish = new System.Windows.Forms.TabPage();
            this.tabPageMark = new System.Windows.Forms.TabPage();
            this.menuStripMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDesigner.SuspendLayout();
            this.tableLayoutPanelDesignerContainer.SuspendLayout();
            this.panelQuestionContainer.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.toolStripQuestion.SuspendLayout();
            this.panelQuestionNameContainer.SuspendLayout();
            this.panelAnswerAreaContainer.SuspendLayout();
            this.panelAnswersContainer.SuspendLayout();
            this.panelAnswerMultiChoice.SuspendLayout();
            this.tableLayoutPanelAnswerMultiChoiceContainer.SuspendLayout();
            this.panelMultiChoiceOptionsContainer.SuspendLayout();
            this.tableLayoutPanelMultiChoiceOptions.SuspendLayout();
            this.tableLayoutPanelMultiChoiceD.SuspendLayout();
            this.tableLayoutPanelMultiChoiceC.SuspendLayout();
            this.tableLayoutPanelMultiChoiceB.SuspendLayout();
            this.tableLayoutPanelMultiChoiceA.SuspendLayout();
            this.panelAnswerOpen.SuspendLayout();
            this.panelAnswerSingle.SuspendLayout();
            this.panelAnswerSingleAcceptableContainer.SuspendLayout();
            this.panelAnswerTools.SuspendLayout();
            this.contextMenuStripQuestionList.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelMarks.SuspendLayout();
            this.groupBoxMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarksAssigner)).BeginInit();
            this.contextMenuStripQuestionNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(880, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForQuestionsWithoutMarksToolStripMenuItem,
            this.makePdfOfExamToolStripMenuItem,
            this.assessmentInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToXMLToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // checkForQuestionsWithoutMarksToolStripMenuItem
            // 
            this.checkForQuestionsWithoutMarksToolStripMenuItem.Name = "checkForQuestionsWithoutMarksToolStripMenuItem";
            this.checkForQuestionsWithoutMarksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.checkForQuestionsWithoutMarksToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.checkForQuestionsWithoutMarksToolStripMenuItem.Text = "&Check for questions without marks";
            this.checkForQuestionsWithoutMarksToolStripMenuItem.Click += new System.EventHandler(this.checkForQuestionsWithoutMarksToolStripMenuItem_Click);
            // 
            // makePdfOfExamToolStripMenuItem
            // 
            this.makePdfOfExamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withAnswersToolStripMenuItem,
            this.withoutAnswersToolStripMenuItem});
            this.makePdfOfExamToolStripMenuItem.Name = "makePdfOfExamToolStripMenuItem";
            this.makePdfOfExamToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.makePdfOfExamToolStripMenuItem.Text = "Make PDF of exam";
            // 
            // withAnswersToolStripMenuItem
            // 
            this.withAnswersToolStripMenuItem.Name = "withAnswersToolStripMenuItem";
            this.withAnswersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.withAnswersToolStripMenuItem.Text = "With Answers";
            // 
            // withoutAnswersToolStripMenuItem
            // 
            this.withoutAnswersToolStripMenuItem.Name = "withoutAnswersToolStripMenuItem";
            this.withoutAnswersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.withoutAnswersToolStripMenuItem.Text = "Without Answers";
            // 
            // assessmentInformationToolStripMenuItem
            // 
            this.assessmentInformationToolStripMenuItem.Name = "assessmentInformationToolStripMenuItem";
            this.assessmentInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.assessmentInformationToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.assessmentInformationToolStripMenuItem.Text = "Assessment &Information";
            this.assessmentInformationToolStripMenuItem.Click += new System.EventHandler(this.assessmentInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(300, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.recentToolStripMenuItem.Text = "&Recent";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(300, 6);
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.exportToXMLToolStripMenuItem.Text = "Export to &XML";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.saveasToolStripMenuItem.Text = "Save &As";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(300, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailSettingsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "&Configure";
            // 
            // emailSettingsToolStripMenuItem
            // 
            this.emailSettingsToolStripMenuItem.Name = "emailSettingsToolStripMenuItem";
            this.emailSettingsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.emailSettingsToolStripMenuItem.Text = "&Email Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDesigner);
            this.tabControl1.Controls.Add(this.tabPagePublish);
            this.tabControl1.Controls.Add(this.tabPageMark);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 610);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageDesigner
            // 
            this.tabPageDesigner.Controls.Add(this.tableLayoutPanelDesignerContainer);
            this.tabPageDesigner.Controls.Add(this.treeViewQuestionList);
            this.tabPageDesigner.Controls.Add(this.panelButtons);
            this.tabPageDesigner.Controls.Add(this.panelMarks);
            this.tabPageDesigner.Location = new System.Drawing.Point(4, 22);
            this.tabPageDesigner.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDesigner.Name = "tabPageDesigner";
            this.tabPageDesigner.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDesigner.Size = new System.Drawing.Size(872, 584);
            this.tabPageDesigner.TabIndex = 0;
            this.tabPageDesigner.Text = "Designer";
            this.tabPageDesigner.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelDesignerContainer
            // 
            this.tableLayoutPanelDesignerContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDesignerContainer.ColumnCount = 1;
            this.tableLayoutPanelDesignerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDesignerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanelDesignerContainer.Controls.Add(this.panelQuestionContainer, 0, 0);
            this.tableLayoutPanelDesignerContainer.Controls.Add(this.panelAnswerAreaContainer, 0, 1);
            this.tableLayoutPanelDesignerContainer.Location = new System.Drawing.Point(174, 7);
            this.tableLayoutPanelDesignerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDesignerContainer.Name = "tableLayoutPanelDesignerContainer";
            this.tableLayoutPanelDesignerContainer.RowCount = 2;
            this.tableLayoutPanelDesignerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDesignerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDesignerContainer.Size = new System.Drawing.Size(693, 473);
            this.tableLayoutPanelDesignerContainer.TabIndex = 6;
            // 
            // panelQuestionContainer
            // 
            this.panelQuestionContainer.Controls.Add(this.panelQuestion);
            this.panelQuestionContainer.Controls.Add(this.panelQuestionNameContainer);
            this.panelQuestionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestionContainer.Location = new System.Drawing.Point(2, 2);
            this.panelQuestionContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestionContainer.Name = "panelQuestionContainer";
            this.panelQuestionContainer.Size = new System.Drawing.Size(689, 232);
            this.panelQuestionContainer.TabIndex = 0;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.richTextBoxQuestion);
            this.panelQuestion.Controls.Add(this.toolStripQuestion);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestion.Location = new System.Drawing.Point(0, 20);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Padding = new System.Windows.Forms.Padding(2);
            this.panelQuestion.Size = new System.Drawing.Size(689, 212);
            this.panelQuestion.TabIndex = 9;
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(2, 29);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(685, 181);
            this.richTextBoxQuestion.TabIndex = 1;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.SelectionChanged += new System.EventHandler(this.richTextBoxQuestion_SelectionChanged);
            this.richTextBoxQuestion.TextChanged += new System.EventHandler(this.richTextBoxQuestion_TextChanged);
            // 
            // toolStripQuestion
            // 
            this.toolStripQuestion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripQuestion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripQuestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripSeparator5,
            this.toolStripButtonAlignLeft,
            this.toolStripButtonAlignCentre,
            this.toolStripButtonAlignRight,
            this.toolStripButtonBulletList,
            this.toolStripSeparator6,
            this.toolStripComboBoxFont,
            this.toolStripComboBoxSize,
            this.toolStripSeparator8,
            this.toolStripButtonColour,
            this.toolStripSeparator7,
            this.toolStripButtonAddImage});
            this.toolStripQuestion.Location = new System.Drawing.Point(2, 2);
            this.toolStripQuestion.Name = "toolStripQuestion";
            this.toolStripQuestion.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripQuestion.Size = new System.Drawing.Size(685, 27);
            this.toolStripQuestion.TabIndex = 0;
            this.toolStripQuestion.Text = "toolStrip1";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = global::AssessmentManager.Properties.Resources.FormatBold;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonBold.Text = "Bold";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = global::AssessmentManager.Properties.Resources.FormatItalic;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonItalic.Text = "Italic";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = global::AssessmentManager.Properties.Resources.FormatUnderline;
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonUnderline.Text = "Underline";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonAlignLeft
            // 
            this.toolStripButtonAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignLeft.Image = global::AssessmentManager.Properties.Resources.AlignLeft;
            this.toolStripButtonAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignLeft.Name = "toolStripButtonAlignLeft";
            this.toolStripButtonAlignLeft.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAlignLeft.Text = "Align Left";
            this.toolStripButtonAlignLeft.Click += new System.EventHandler(this.toolStripButtonAlignLeft_Click);
            // 
            // toolStripButtonAlignCentre
            // 
            this.toolStripButtonAlignCentre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignCentre.Image = global::AssessmentManager.Properties.Resources.AlignCentre;
            this.toolStripButtonAlignCentre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignCentre.Name = "toolStripButtonAlignCentre";
            this.toolStripButtonAlignCentre.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAlignCentre.Text = "Align Right";
            this.toolStripButtonAlignCentre.Click += new System.EventHandler(this.toolStripButtonAlignCentre_Click);
            // 
            // toolStripButtonAlignRight
            // 
            this.toolStripButtonAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignRight.Image = global::AssessmentManager.Properties.Resources.AlignRight;
            this.toolStripButtonAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignRight.Name = "toolStripButtonAlignRight";
            this.toolStripButtonAlignRight.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAlignRight.Text = "Align Right";
            this.toolStripButtonAlignRight.Click += new System.EventHandler(this.toolStripButtonAlignRight_Click);
            // 
            // toolStripButtonBulletList
            // 
            this.toolStripButtonBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBulletList.Image = global::AssessmentManager.Properties.Resources.List_Bullets;
            this.toolStripButtonBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBulletList.Name = "toolStripButtonBulletList";
            this.toolStripButtonBulletList.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonBulletList.Text = "Bullet List";
            this.toolStripButtonBulletList.Click += new System.EventHandler(this.toolStripButtonBulletList_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(150, 27);
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(75, 27);
            this.toolStripComboBoxSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSize_SelectedIndexChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonColour
            // 
            this.toolStripButtonColour.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonColour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonColour.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColour.Image")));
            this.toolStripButtonColour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColour.Name = "toolStripButtonColour";
            this.toolStripButtonColour.Size = new System.Drawing.Size(23, 24);
            this.toolStripButtonColour.Text = "Font Colour";
            this.toolStripButtonColour.Click += new System.EventHandler(this.toolStripButtonColour_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonAddImage
            // 
            this.toolStripButtonAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddImage.Image")));
            this.toolStripButtonAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddImage.Name = "toolStripButtonAddImage";
            this.toolStripButtonAddImage.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddImage.Text = "Add Image";
            this.toolStripButtonAddImage.Click += new System.EventHandler(this.toolStripButtonAddImage_Click);
            // 
            // panelQuestionNameContainer
            // 
            this.panelQuestionNameContainer.Controls.Add(this.labelQuestion);
            this.panelQuestionNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestionNameContainer.Location = new System.Drawing.Point(0, 0);
            this.panelQuestionNameContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestionNameContainer.Name = "panelQuestionNameContainer";
            this.panelQuestionNameContainer.Size = new System.Drawing.Size(689, 20);
            this.panelQuestionNameContainer.TabIndex = 8;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(689, 20);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAnswerAreaContainer
            // 
            this.panelAnswerAreaContainer.Controls.Add(this.panelAnswersContainer);
            this.panelAnswerAreaContainer.Controls.Add(this.panelAnswerTools);
            this.panelAnswerAreaContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswerAreaContainer.Location = new System.Drawing.Point(2, 238);
            this.panelAnswerAreaContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswerAreaContainer.Name = "panelAnswerAreaContainer";
            this.panelAnswerAreaContainer.Size = new System.Drawing.Size(689, 233);
            this.panelAnswerAreaContainer.TabIndex = 1;
            // 
            // panelAnswersContainer
            // 
            this.panelAnswersContainer.Controls.Add(this.panelAnswerMultiChoice);
            this.panelAnswersContainer.Controls.Add(this.panelAnswerOpen);
            this.panelAnswersContainer.Controls.Add(this.panelAnswerSingle);
            this.panelAnswersContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswersContainer.Location = new System.Drawing.Point(0, 24);
            this.panelAnswersContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswersContainer.Name = "panelAnswersContainer";
            this.panelAnswersContainer.Size = new System.Drawing.Size(689, 209);
            this.panelAnswersContainer.TabIndex = 2;
            // 
            // panelAnswerMultiChoice
            // 
            this.panelAnswerMultiChoice.Controls.Add(this.tableLayoutPanelAnswerMultiChoiceContainer);
            this.panelAnswerMultiChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswerMultiChoice.Location = new System.Drawing.Point(0, 0);
            this.panelAnswerMultiChoice.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswerMultiChoice.Name = "panelAnswerMultiChoice";
            this.panelAnswerMultiChoice.Size = new System.Drawing.Size(689, 209);
            this.panelAnswerMultiChoice.TabIndex = 1;
            // 
            // tableLayoutPanelAnswerMultiChoiceContainer
            // 
            this.tableLayoutPanelAnswerMultiChoiceContainer.ColumnCount = 1;
            this.tableLayoutPanelAnswerMultiChoiceContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelAnswerMultiChoiceContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelAnswerMultiChoiceContainer.Controls.Add(this.panelMultiChoiceOptionsContainer, 0, 0);
            this.tableLayoutPanelAnswerMultiChoiceContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAnswerMultiChoiceContainer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAnswerMultiChoiceContainer.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelAnswerMultiChoiceContainer.Name = "tableLayoutPanelAnswerMultiChoiceContainer";
            this.tableLayoutPanelAnswerMultiChoiceContainer.RowCount = 1;
            this.tableLayoutPanelAnswerMultiChoiceContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAnswerMultiChoiceContainer.Size = new System.Drawing.Size(689, 209);
            this.tableLayoutPanelAnswerMultiChoiceContainer.TabIndex = 0;
            // 
            // panelMultiChoiceOptionsContainer
            // 
            this.panelMultiChoiceOptionsContainer.Controls.Add(this.labelAnswerMultiCorrect);
            this.panelMultiChoiceOptionsContainer.Controls.Add(this.comboBoxAnswerMultiCorrect);
            this.panelMultiChoiceOptionsContainer.Controls.Add(this.tableLayoutPanelMultiChoiceOptions);
            this.panelMultiChoiceOptionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMultiChoiceOptionsContainer.Location = new System.Drawing.Point(2, 2);
            this.panelMultiChoiceOptionsContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelMultiChoiceOptionsContainer.Name = "panelMultiChoiceOptionsContainer";
            this.panelMultiChoiceOptionsContainer.Size = new System.Drawing.Size(685, 205);
            this.panelMultiChoiceOptionsContainer.TabIndex = 0;
            // 
            // labelAnswerMultiCorrect
            // 
            this.labelAnswerMultiCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswerMultiCorrect.AutoSize = true;
            this.labelAnswerMultiCorrect.Location = new System.Drawing.Point(533, 126);
            this.labelAnswerMultiCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerMultiCorrect.Name = "labelAnswerMultiCorrect";
            this.labelAnswerMultiCorrect.Size = new System.Drawing.Size(82, 13);
            this.labelAnswerMultiCorrect.TabIndex = 2;
            this.labelAnswerMultiCorrect.Text = "Correct Answer:";
            // 
            // comboBoxAnswerMultiCorrect
            // 
            this.comboBoxAnswerMultiCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAnswerMultiCorrect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnswerMultiCorrect.FormattingEnabled = true;
            this.comboBoxAnswerMultiCorrect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxAnswerMultiCorrect.Location = new System.Drawing.Point(619, 124);
            this.comboBoxAnswerMultiCorrect.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnswerMultiCorrect.Name = "comboBoxAnswerMultiCorrect";
            this.comboBoxAnswerMultiCorrect.Size = new System.Drawing.Size(63, 21);
            this.comboBoxAnswerMultiCorrect.TabIndex = 1;
            this.comboBoxAnswerMultiCorrect.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnswerMultiCorrect_SelectedIndexChanged);
            // 
            // tableLayoutPanelMultiChoiceOptions
            // 
            this.tableLayoutPanelMultiChoiceOptions.ColumnCount = 2;
            this.tableLayoutPanelMultiChoiceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMultiChoiceOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMultiChoiceOptions.Controls.Add(this.tableLayoutPanelMultiChoiceD, 1, 1);
            this.tableLayoutPanelMultiChoiceOptions.Controls.Add(this.tableLayoutPanelMultiChoiceC, 0, 1);
            this.tableLayoutPanelMultiChoiceOptions.Controls.Add(this.tableLayoutPanelMultiChoiceB, 1, 0);
            this.tableLayoutPanelMultiChoiceOptions.Controls.Add(this.tableLayoutPanelMultiChoiceA, 0, 0);
            this.tableLayoutPanelMultiChoiceOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMultiChoiceOptions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMultiChoiceOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMultiChoiceOptions.Name = "tableLayoutPanelMultiChoiceOptions";
            this.tableLayoutPanelMultiChoiceOptions.RowCount = 2;
            this.tableLayoutPanelMultiChoiceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMultiChoiceOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMultiChoiceOptions.Size = new System.Drawing.Size(685, 119);
            this.tableLayoutPanelMultiChoiceOptions.TabIndex = 0;
            // 
            // tableLayoutPanelMultiChoiceD
            // 
            this.tableLayoutPanelMultiChoiceD.ColumnCount = 2;
            this.tableLayoutPanelMultiChoiceD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMultiChoiceD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceD.Controls.Add(this.labelD, 0, 0);
            this.tableLayoutPanelMultiChoiceD.Controls.Add(this.textBoxMultiChoiceD, 1, 0);
            this.tableLayoutPanelMultiChoiceD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMultiChoiceD.Location = new System.Drawing.Point(344, 61);
            this.tableLayoutPanelMultiChoiceD.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMultiChoiceD.Name = "tableLayoutPanelMultiChoiceD";
            this.tableLayoutPanelMultiChoiceD.RowCount = 1;
            this.tableLayoutPanelMultiChoiceD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceD.Size = new System.Drawing.Size(339, 56);
            this.tableLayoutPanelMultiChoiceD.TabIndex = 3;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelD.Location = new System.Drawing.Point(2, 0);
            this.labelD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(18, 56);
            this.labelD.TabIndex = 0;
            this.labelD.Text = "D:";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMultiChoiceD
            // 
            this.textBoxMultiChoiceD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiChoiceD.Location = new System.Drawing.Point(24, 18);
            this.textBoxMultiChoiceD.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMultiChoiceD.Name = "textBoxMultiChoiceD";
            this.textBoxMultiChoiceD.Size = new System.Drawing.Size(313, 20);
            this.textBoxMultiChoiceD.TabIndex = 1;
            this.textBoxMultiChoiceD.TextChanged += new System.EventHandler(this.textBoxMultiChoiceD_TextChanged);
            // 
            // tableLayoutPanelMultiChoiceC
            // 
            this.tableLayoutPanelMultiChoiceC.ColumnCount = 2;
            this.tableLayoutPanelMultiChoiceC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMultiChoiceC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceC.Controls.Add(this.labelC, 0, 0);
            this.tableLayoutPanelMultiChoiceC.Controls.Add(this.textBoxMultiChoiceC, 1, 0);
            this.tableLayoutPanelMultiChoiceC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMultiChoiceC.Location = new System.Drawing.Point(2, 61);
            this.tableLayoutPanelMultiChoiceC.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMultiChoiceC.Name = "tableLayoutPanelMultiChoiceC";
            this.tableLayoutPanelMultiChoiceC.RowCount = 1;
            this.tableLayoutPanelMultiChoiceC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceC.Size = new System.Drawing.Size(338, 56);
            this.tableLayoutPanelMultiChoiceC.TabIndex = 2;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelC.Location = new System.Drawing.Point(2, 0);
            this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(18, 56);
            this.labelC.TabIndex = 0;
            this.labelC.Text = "C:";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMultiChoiceC
            // 
            this.textBoxMultiChoiceC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiChoiceC.Location = new System.Drawing.Point(24, 18);
            this.textBoxMultiChoiceC.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMultiChoiceC.Name = "textBoxMultiChoiceC";
            this.textBoxMultiChoiceC.Size = new System.Drawing.Size(312, 20);
            this.textBoxMultiChoiceC.TabIndex = 1;
            this.textBoxMultiChoiceC.TextChanged += new System.EventHandler(this.textBoxMultiChoiceC_TextChanged);
            // 
            // tableLayoutPanelMultiChoiceB
            // 
            this.tableLayoutPanelMultiChoiceB.ColumnCount = 2;
            this.tableLayoutPanelMultiChoiceB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMultiChoiceB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceB.Controls.Add(this.labelB, 0, 0);
            this.tableLayoutPanelMultiChoiceB.Controls.Add(this.textBoxMultiChoiceB, 1, 0);
            this.tableLayoutPanelMultiChoiceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMultiChoiceB.Location = new System.Drawing.Point(344, 2);
            this.tableLayoutPanelMultiChoiceB.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMultiChoiceB.Name = "tableLayoutPanelMultiChoiceB";
            this.tableLayoutPanelMultiChoiceB.RowCount = 1;
            this.tableLayoutPanelMultiChoiceB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceB.Size = new System.Drawing.Size(339, 55);
            this.tableLayoutPanelMultiChoiceB.TabIndex = 1;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Location = new System.Drawing.Point(2, 0);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 55);
            this.labelB.TabIndex = 0;
            this.labelB.Text = "B:";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMultiChoiceB
            // 
            this.textBoxMultiChoiceB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiChoiceB.Location = new System.Drawing.Point(24, 17);
            this.textBoxMultiChoiceB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMultiChoiceB.Name = "textBoxMultiChoiceB";
            this.textBoxMultiChoiceB.Size = new System.Drawing.Size(313, 20);
            this.textBoxMultiChoiceB.TabIndex = 1;
            this.textBoxMultiChoiceB.TextChanged += new System.EventHandler(this.textBoxMultiChoiceB_TextChanged);
            // 
            // tableLayoutPanelMultiChoiceA
            // 
            this.tableLayoutPanelMultiChoiceA.ColumnCount = 2;
            this.tableLayoutPanelMultiChoiceA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelMultiChoiceA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceA.Controls.Add(this.labelA, 0, 0);
            this.tableLayoutPanelMultiChoiceA.Controls.Add(this.textBoxMultiChoiceA, 1, 0);
            this.tableLayoutPanelMultiChoiceA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMultiChoiceA.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelMultiChoiceA.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMultiChoiceA.Name = "tableLayoutPanelMultiChoiceA";
            this.tableLayoutPanelMultiChoiceA.RowCount = 1;
            this.tableLayoutPanelMultiChoiceA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMultiChoiceA.Size = new System.Drawing.Size(338, 55);
            this.tableLayoutPanelMultiChoiceA.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Location = new System.Drawing.Point(2, 0);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 55);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A:";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMultiChoiceA
            // 
            this.textBoxMultiChoiceA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMultiChoiceA.Location = new System.Drawing.Point(24, 17);
            this.textBoxMultiChoiceA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMultiChoiceA.Name = "textBoxMultiChoiceA";
            this.textBoxMultiChoiceA.Size = new System.Drawing.Size(312, 20);
            this.textBoxMultiChoiceA.TabIndex = 1;
            this.textBoxMultiChoiceA.TextChanged += new System.EventHandler(this.textBoxMultiChoiceA_TextChanged);
            // 
            // panelAnswerOpen
            // 
            this.panelAnswerOpen.Controls.Add(this.richTextBoxAnswerOpen);
            this.panelAnswerOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswerOpen.Location = new System.Drawing.Point(0, 0);
            this.panelAnswerOpen.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswerOpen.Name = "panelAnswerOpen";
            this.panelAnswerOpen.Size = new System.Drawing.Size(689, 209);
            this.panelAnswerOpen.TabIndex = 0;
            // 
            // richTextBoxAnswerOpen
            // 
            this.richTextBoxAnswerOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAnswerOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAnswerOpen.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxAnswerOpen.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAnswerOpen.Name = "richTextBoxAnswerOpen";
            this.richTextBoxAnswerOpen.Size = new System.Drawing.Size(689, 209);
            this.richTextBoxAnswerOpen.TabIndex = 0;
            this.richTextBoxAnswerOpen.Text = "";
            this.richTextBoxAnswerOpen.TextChanged += new System.EventHandler(this.richTextBoxAnswerOpen_TextChanged);
            // 
            // panelAnswerSingle
            // 
            this.panelAnswerSingle.ColumnCount = 1;
            this.panelAnswerSingle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.panelAnswerSingle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelAnswerSingle.Controls.Add(this.panelAnswerSingleAcceptableContainer, 0, 0);
            this.panelAnswerSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswerSingle.Location = new System.Drawing.Point(0, 0);
            this.panelAnswerSingle.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswerSingle.Name = "panelAnswerSingle";
            this.panelAnswerSingle.RowCount = 1;
            this.panelAnswerSingle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelAnswerSingle.Size = new System.Drawing.Size(689, 209);
            this.panelAnswerSingle.TabIndex = 1;
            // 
            // panelAnswerSingleAcceptableContainer
            // 
            this.panelAnswerSingleAcceptableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerSingleAcceptableContainer.Controls.Add(this.richTextBoxAnswerSingleAcceptable);
            this.panelAnswerSingleAcceptableContainer.Controls.Add(this.labelAnswerSingleAcceptable);
            this.panelAnswerSingleAcceptableContainer.Location = new System.Drawing.Point(2, 2);
            this.panelAnswerSingleAcceptableContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelAnswerSingleAcceptableContainer.Name = "panelAnswerSingleAcceptableContainer";
            this.panelAnswerSingleAcceptableContainer.Size = new System.Drawing.Size(685, 205);
            this.panelAnswerSingleAcceptableContainer.TabIndex = 0;
            // 
            // richTextBoxAnswerSingleAcceptable
            // 
            this.richTextBoxAnswerSingleAcceptable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAnswerSingleAcceptable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAnswerSingleAcceptable.Location = new System.Drawing.Point(111, 0);
            this.richTextBoxAnswerSingleAcceptable.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxAnswerSingleAcceptable.Name = "richTextBoxAnswerSingleAcceptable";
            this.richTextBoxAnswerSingleAcceptable.Size = new System.Drawing.Size(575, 206);
            this.richTextBoxAnswerSingleAcceptable.TabIndex = 1;
            this.richTextBoxAnswerSingleAcceptable.Text = "";
            this.richTextBoxAnswerSingleAcceptable.TextChanged += new System.EventHandler(this.richTextBoxAnswerSingleAcceptable_TextChanged);
            // 
            // labelAnswerSingleAcceptable
            // 
            this.labelAnswerSingleAcceptable.AutoSize = true;
            this.labelAnswerSingleAcceptable.Location = new System.Drawing.Point(2, 0);
            this.labelAnswerSingleAcceptable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerSingleAcceptable.Name = "labelAnswerSingleAcceptable";
            this.labelAnswerSingleAcceptable.Size = new System.Drawing.Size(107, 13);
            this.labelAnswerSingleAcceptable.TabIndex = 0;
            this.labelAnswerSingleAcceptable.Text = "Acceptable Answers:";
            // 
            // panelAnswerTools
            // 
            this.panelAnswerTools.Controls.Add(this.labelAnswerType);
            this.panelAnswerTools.Controls.Add(this.comboBoxAnswerType);
            this.panelAnswerTools.Controls.Add(this.labelAnswerText);
            this.panelAnswerTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnswerTools.Location = new System.Drawing.Point(0, 0);
            this.panelAnswerTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 5);
            this.panelAnswerTools.Name = "panelAnswerTools";
            this.panelAnswerTools.Size = new System.Drawing.Size(689, 24);
            this.panelAnswerTools.TabIndex = 1;
            // 
            // labelAnswerType
            // 
            this.labelAnswerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswerType.Location = new System.Drawing.Point(515, 2);
            this.labelAnswerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerType.Name = "labelAnswerType";
            this.labelAnswerType.Size = new System.Drawing.Size(75, 19);
            this.labelAnswerType.TabIndex = 2;
            this.labelAnswerType.Text = "Answer type:";
            this.labelAnswerType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAnswerType
            // 
            this.comboBoxAnswerType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAnswerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnswerType.FormattingEnabled = true;
            this.comboBoxAnswerType.Items.AddRange(new object[] {
            "None",
            "Multi-choice",
            "Open",
            "Single"});
            this.comboBoxAnswerType.Location = new System.Drawing.Point(595, 2);
            this.comboBoxAnswerType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAnswerType.Name = "comboBoxAnswerType";
            this.comboBoxAnswerType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAnswerType.TabIndex = 1;
            this.comboBoxAnswerType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnswerType_SelectedIndexChanged);
            // 
            // labelAnswerText
            // 
            this.labelAnswerText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswerText.Location = new System.Drawing.Point(0, 0);
            this.labelAnswerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerText.Name = "labelAnswerText";
            this.labelAnswerText.Size = new System.Drawing.Size(75, 24);
            this.labelAnswerText.TabIndex = 0;
            this.labelAnswerText.Text = "Answer:";
            this.labelAnswerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeViewQuestionList
            // 
            this.treeViewQuestionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewQuestionList.ContextMenuStrip = this.contextMenuStripQuestionList;
            this.treeViewQuestionList.Location = new System.Drawing.Point(7, 7);
            this.treeViewQuestionList.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewQuestionList.Name = "treeViewQuestionList";
            this.treeViewQuestionList.Size = new System.Drawing.Size(161, 473);
            this.treeViewQuestionList.TabIndex = 5;
            this.treeViewQuestionList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewQuestionList_AfterSelect);
            this.treeViewQuestionList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewQuestionList_KeyDown);
            this.treeViewQuestionList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewQuestionList_MouseUp);
            // 
            // contextMenuStripQuestionList
            // 
            this.contextMenuStripQuestionList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMajorQuestionToolStripMenuItem});
            this.contextMenuStripQuestionList.Name = "contextMenuStripQuestionList";
            this.contextMenuStripQuestionList.Size = new System.Drawing.Size(182, 26);
            // 
            // addMajorQuestionToolStripMenuItem
            // 
            this.addMajorQuestionToolStripMenuItem.Name = "addMajorQuestionToolStripMenuItem";
            this.addMajorQuestionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.addMajorQuestionToolStripMenuItem.Text = "Add Major Question";
            this.addMajorQuestionToolStripMenuItem.Click += new System.EventHandler(this.buttonAddMajorQuestion_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.buttonAddSubQuestion);
            this.panelButtons.Controls.Add(this.buttonAddMajorQuestion);
            this.panelButtons.Controls.Add(this.buttonMoveUp);
            this.panelButtons.Controls.Add(this.buttonMoveDown);
            this.panelButtons.Controls.Add(this.buttonCollapseAll);
            this.panelButtons.Controls.Add(this.buttonExpandAll);
            this.panelButtons.Location = new System.Drawing.Point(7, 485);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(161, 95);
            this.panelButtons.TabIndex = 4;
            // 
            // buttonAddSubQuestion
            // 
            this.buttonAddSubQuestion.Location = new System.Drawing.Point(2, 66);
            this.buttonAddSubQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSubQuestion.Name = "buttonAddSubQuestion";
            this.buttonAddSubQuestion.Size = new System.Drawing.Size(155, 24);
            this.buttonAddSubQuestion.TabIndex = 5;
            this.buttonAddSubQuestion.Text = "Add Sub-Question";
            this.buttonAddSubQuestion.UseVisualStyleBackColor = true;
            this.buttonAddSubQuestion.Click += new System.EventHandler(this.buttonAddSubQuestion_Click);
            // 
            // buttonAddMajorQuestion
            // 
            this.buttonAddMajorQuestion.Location = new System.Drawing.Point(2, 40);
            this.buttonAddMajorQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMajorQuestion.Name = "buttonAddMajorQuestion";
            this.buttonAddMajorQuestion.Size = new System.Drawing.Size(155, 24);
            this.buttonAddMajorQuestion.TabIndex = 4;
            this.buttonAddMajorQuestion.Text = "Add Major Question";
            this.buttonAddMajorQuestion.UseVisualStyleBackColor = true;
            this.buttonAddMajorQuestion.Click += new System.EventHandler(this.buttonAddMajorQuestion_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Image = global::AssessmentManager.Properties.Resources.ArrowUp32;
            this.buttonMoveUp.Location = new System.Drawing.Point(2, 2);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(35, 35);
            this.buttonMoveUp.TabIndex = 3;
            this.buttonToolTip.SetToolTip(this.buttonMoveUp, "Move selected question up");
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Image = global::AssessmentManager.Properties.Resources.ArrowDown32;
            this.buttonMoveDown.Location = new System.Drawing.Point(41, 2);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(35, 35);
            this.buttonMoveDown.TabIndex = 2;
            this.buttonToolTip.SetToolTip(this.buttonMoveDown, "Move selected question down");
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.Image = global::AssessmentManager.Properties.Resources.CollapseAll32;
            this.buttonCollapseAll.Location = new System.Drawing.Point(122, 2);
            this.buttonCollapseAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(35, 35);
            this.buttonCollapseAll.TabIndex = 1;
            this.buttonToolTip.SetToolTip(this.buttonCollapseAll, "Collapse all nodes");
            this.buttonCollapseAll.UseVisualStyleBackColor = true;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.Image = global::AssessmentManager.Properties.Resources.ExpandAll32;
            this.buttonExpandAll.Location = new System.Drawing.Point(83, 2);
            this.buttonExpandAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(35, 35);
            this.buttonExpandAll.TabIndex = 0;
            this.buttonToolTip.SetToolTip(this.buttonExpandAll, "Expand all nodes");
            this.buttonExpandAll.UseVisualStyleBackColor = true;
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // panelMarks
            // 
            this.panelMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMarks.Controls.Add(this.groupBoxMarks);
            this.panelMarks.Controls.Add(this.numericUpDownMarksAssigner);
            this.panelMarks.Controls.Add(this.labelMarksForQuestion);
            this.panelMarks.Location = new System.Drawing.Point(174, 485);
            this.panelMarks.Margin = new System.Windows.Forms.Padding(2);
            this.panelMarks.Name = "panelMarks";
            this.panelMarks.Size = new System.Drawing.Size(694, 95);
            this.panelMarks.TabIndex = 3;
            // 
            // groupBoxMarks
            // 
            this.groupBoxMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestionParentParentNum);
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestionParentNum);
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestionNum);
            this.groupBoxMarks.Controls.Add(this.labelMarksWholeAssessmentNum);
            this.groupBoxMarks.Controls.Add(this.labelMarksWholeAssessment);
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestionParentParent);
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestionParent);
            this.groupBoxMarks.Controls.Add(this.labelMarksSelectedQuestion);
            this.groupBoxMarks.Location = new System.Drawing.Point(454, 2);
            this.groupBoxMarks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMarks.Name = "groupBoxMarks";
            this.groupBoxMarks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMarks.Size = new System.Drawing.Size(230, 88);
            this.groupBoxMarks.TabIndex = 2;
            this.groupBoxMarks.TabStop = false;
            this.groupBoxMarks.Text = "Mark Allocations";
            // 
            // labelMarksSelectedQuestionParentParentNum
            // 
            this.labelMarksSelectedQuestionParentParentNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarksSelectedQuestionParentParentNum.Location = new System.Drawing.Point(160, 62);
            this.labelMarksSelectedQuestionParentParentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestionParentParentNum.Name = "labelMarksSelectedQuestionParentParentNum";
            this.labelMarksSelectedQuestionParentParentNum.Size = new System.Drawing.Size(66, 13);
            this.labelMarksSelectedQuestionParentParentNum.TabIndex = 7;
            this.labelMarksSelectedQuestionParentParentNum.Text = "0";
            this.labelMarksSelectedQuestionParentParentNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMarksSelectedQuestionParentNum
            // 
            this.labelMarksSelectedQuestionParentNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarksSelectedQuestionParentNum.Location = new System.Drawing.Point(160, 48);
            this.labelMarksSelectedQuestionParentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestionParentNum.Name = "labelMarksSelectedQuestionParentNum";
            this.labelMarksSelectedQuestionParentNum.Size = new System.Drawing.Size(66, 13);
            this.labelMarksSelectedQuestionParentNum.TabIndex = 6;
            this.labelMarksSelectedQuestionParentNum.Text = "0";
            this.labelMarksSelectedQuestionParentNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMarksSelectedQuestionNum
            // 
            this.labelMarksSelectedQuestionNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarksSelectedQuestionNum.Location = new System.Drawing.Point(157, 34);
            this.labelMarksSelectedQuestionNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestionNum.Name = "labelMarksSelectedQuestionNum";
            this.labelMarksSelectedQuestionNum.Size = new System.Drawing.Size(69, 13);
            this.labelMarksSelectedQuestionNum.TabIndex = 5;
            this.labelMarksSelectedQuestionNum.Text = "0";
            this.labelMarksSelectedQuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMarksWholeAssessmentNum
            // 
            this.labelMarksWholeAssessmentNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMarksWholeAssessmentNum.Location = new System.Drawing.Point(154, 20);
            this.labelMarksWholeAssessmentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksWholeAssessmentNum.Name = "labelMarksWholeAssessmentNum";
            this.labelMarksWholeAssessmentNum.Size = new System.Drawing.Size(72, 13);
            this.labelMarksWholeAssessmentNum.TabIndex = 4;
            this.labelMarksWholeAssessmentNum.Text = "0";
            this.labelMarksWholeAssessmentNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMarksWholeAssessment
            // 
            this.labelMarksWholeAssessment.AutoSize = true;
            this.labelMarksWholeAssessment.Location = new System.Drawing.Point(4, 20);
            this.labelMarksWholeAssessment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksWholeAssessment.Name = "labelMarksWholeAssessment";
            this.labelMarksWholeAssessment.Size = new System.Drawing.Size(100, 13);
            this.labelMarksWholeAssessment.TabIndex = 3;
            this.labelMarksWholeAssessment.Text = "Whole Assessment:";
            // 
            // labelMarksSelectedQuestionParentParent
            // 
            this.labelMarksSelectedQuestionParentParent.AutoSize = true;
            this.labelMarksSelectedQuestionParentParent.Location = new System.Drawing.Point(4, 62);
            this.labelMarksSelectedQuestionParentParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestionParentParent.Name = "labelMarksSelectedQuestionParentParent";
            this.labelMarksSelectedQuestionParentParent.Size = new System.Drawing.Size(158, 13);
            this.labelMarksSelectedQuestionParentParent.TabIndex = 2;
            this.labelMarksSelectedQuestionParentParent.Text = "Selected question parent parent";
            // 
            // labelMarksSelectedQuestionParent
            // 
            this.labelMarksSelectedQuestionParent.AutoSize = true;
            this.labelMarksSelectedQuestionParent.Location = new System.Drawing.Point(4, 48);
            this.labelMarksSelectedQuestionParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestionParent.Name = "labelMarksSelectedQuestionParent";
            this.labelMarksSelectedQuestionParent.Size = new System.Drawing.Size(125, 13);
            this.labelMarksSelectedQuestionParent.TabIndex = 1;
            this.labelMarksSelectedQuestionParent.Text = "Selected question parent";
            // 
            // labelMarksSelectedQuestion
            // 
            this.labelMarksSelectedQuestion.AutoSize = true;
            this.labelMarksSelectedQuestion.Location = new System.Drawing.Point(4, 34);
            this.labelMarksSelectedQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksSelectedQuestion.Name = "labelMarksSelectedQuestion";
            this.labelMarksSelectedQuestion.Size = new System.Drawing.Size(92, 13);
            this.labelMarksSelectedQuestion.TabIndex = 0;
            this.labelMarksSelectedQuestion.Text = "Selected question";
            // 
            // numericUpDownMarksAssigner
            // 
            this.numericUpDownMarksAssigner.Location = new System.Drawing.Point(128, 34);
            this.numericUpDownMarksAssigner.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMarksAssigner.Name = "numericUpDownMarksAssigner";
            this.numericUpDownMarksAssigner.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownMarksAssigner.TabIndex = 1;
            this.numericUpDownMarksAssigner.ValueChanged += new System.EventHandler(this.numericUpDownMarksAssigner_ValueChanged);
            // 
            // labelMarksForQuestion
            // 
            this.labelMarksForQuestion.AutoSize = true;
            this.labelMarksForQuestion.Location = new System.Drawing.Point(8, 36);
            this.labelMarksForQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksForQuestion.Name = "labelMarksForQuestion";
            this.labelMarksForQuestion.Size = new System.Drawing.Size(96, 13);
            this.labelMarksForQuestion.TabIndex = 0;
            this.labelMarksForQuestion.Text = "Marks for Question";
            // 
            // contextMenuStripQuestionNode
            // 
            this.contextMenuStripQuestionNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuDelete,
            this.contextMenuSeparatorSubQuestion,
            this.contextMenuAddSubQuestion,
            this.contextMenuSeparatorInsert,
            this.contextMenuInsertAbove,
            this.contextMenuInsertBelow,
            this.contextMenuSeparatorMove,
            this.contextMenuMoveUp,
            this.contextMenuMoveDown,
            this.contextMenuSeparatorChangeLevel,
            this.contextMenuChangeLevelUp,
            this.contextMenuChangeLevelDown});
            this.contextMenuStripQuestionNode.Name = "contextMenuStripQuestionNode";
            this.contextMenuStripQuestionNode.Size = new System.Drawing.Size(192, 204);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(191, 22);
            this.contextMenuDelete.Text = "&Delete";
            this.contextMenuDelete.Click += new System.EventHandler(this.contextMenuDelete_Click);
            // 
            // contextMenuSeparatorSubQuestion
            // 
            this.contextMenuSeparatorSubQuestion.Name = "contextMenuSeparatorSubQuestion";
            this.contextMenuSeparatorSubQuestion.Size = new System.Drawing.Size(188, 6);
            // 
            // contextMenuAddSubQuestion
            // 
            this.contextMenuAddSubQuestion.Name = "contextMenuAddSubQuestion";
            this.contextMenuAddSubQuestion.Size = new System.Drawing.Size(191, 22);
            this.contextMenuAddSubQuestion.Text = "Add &Sub Question";
            this.contextMenuAddSubQuestion.Click += new System.EventHandler(this.contextMenuAddSubQuestion_Click);
            // 
            // contextMenuSeparatorInsert
            // 
            this.contextMenuSeparatorInsert.Name = "contextMenuSeparatorInsert";
            this.contextMenuSeparatorInsert.Size = new System.Drawing.Size(188, 6);
            // 
            // contextMenuInsertAbove
            // 
            this.contextMenuInsertAbove.Name = "contextMenuInsertAbove";
            this.contextMenuInsertAbove.Size = new System.Drawing.Size(191, 22);
            this.contextMenuInsertAbove.Text = "Insert Question &Above";
            this.contextMenuInsertAbove.Click += new System.EventHandler(this.contextMenuInsertAbove_Click);
            // 
            // contextMenuInsertBelow
            // 
            this.contextMenuInsertBelow.Name = "contextMenuInsertBelow";
            this.contextMenuInsertBelow.Size = new System.Drawing.Size(191, 22);
            this.contextMenuInsertBelow.Text = "Insert Question &Below";
            this.contextMenuInsertBelow.Click += new System.EventHandler(this.contextMenuInsertBelow_Click);
            // 
            // contextMenuSeparatorMove
            // 
            this.contextMenuSeparatorMove.Name = "contextMenuSeparatorMove";
            this.contextMenuSeparatorMove.Size = new System.Drawing.Size(188, 6);
            // 
            // contextMenuMoveUp
            // 
            this.contextMenuMoveUp.Name = "contextMenuMoveUp";
            this.contextMenuMoveUp.Size = new System.Drawing.Size(191, 22);
            this.contextMenuMoveUp.Text = "Move &Up";
            this.contextMenuMoveUp.Click += new System.EventHandler(this.contextMenuMoveUp_Click);
            // 
            // contextMenuMoveDown
            // 
            this.contextMenuMoveDown.Name = "contextMenuMoveDown";
            this.contextMenuMoveDown.Size = new System.Drawing.Size(191, 22);
            this.contextMenuMoveDown.Text = "Move &Down";
            this.contextMenuMoveDown.Click += new System.EventHandler(this.contextMenuMoveDown_Click);
            // 
            // contextMenuSeparatorChangeLevel
            // 
            this.contextMenuSeparatorChangeLevel.Name = "contextMenuSeparatorChangeLevel";
            this.contextMenuSeparatorChangeLevel.Size = new System.Drawing.Size(188, 6);
            // 
            // contextMenuChangeLevelUp
            // 
            this.contextMenuChangeLevelUp.Name = "contextMenuChangeLevelUp";
            this.contextMenuChangeLevelUp.Size = new System.Drawing.Size(191, 22);
            this.contextMenuChangeLevelUp.Text = "Change Level Up";
            this.contextMenuChangeLevelUp.Click += new System.EventHandler(this.contextMenuChangeLevelUp_Click);
            // 
            // contextMenuChangeLevelDown
            // 
            this.contextMenuChangeLevelDown.Name = "contextMenuChangeLevelDown";
            this.contextMenuChangeLevelDown.Size = new System.Drawing.Size(191, 22);
            this.contextMenuChangeLevelDown.Text = "Change Level Down";
            this.contextMenuChangeLevelDown.Click += new System.EventHandler(this.contextMenuChangeLevelDown_Click);
            // 
            // tabPagePublish
            // 
            this.tabPagePublish.Location = new System.Drawing.Point(4, 22);
            this.tabPagePublish.Name = "tabPagePublish";
            this.tabPagePublish.Size = new System.Drawing.Size(872, 584);
            this.tabPagePublish.TabIndex = 1;
            this.tabPagePublish.Text = "Publish";
            this.tabPagePublish.UseVisualStyleBackColor = true;
            // 
            // tabPageMark
            // 
            this.tabPageMark.Location = new System.Drawing.Point(4, 22);
            this.tabPageMark.Name = "tabPageMark";
            this.tabPageMark.Size = new System.Drawing.Size(872, 584);
            this.tabPageMark.TabIndex = 2;
            this.tabPageMark.Text = "Mark";
            this.tabPageMark.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(754, 576);
            this.Name = "MainForm";
            this.Text = "Assessment Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDesigner.ResumeLayout(false);
            this.tableLayoutPanelDesignerContainer.ResumeLayout(false);
            this.panelQuestionContainer.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.toolStripQuestion.ResumeLayout(false);
            this.toolStripQuestion.PerformLayout();
            this.panelQuestionNameContainer.ResumeLayout(false);
            this.panelAnswerAreaContainer.ResumeLayout(false);
            this.panelAnswersContainer.ResumeLayout(false);
            this.panelAnswerMultiChoice.ResumeLayout(false);
            this.tableLayoutPanelAnswerMultiChoiceContainer.ResumeLayout(false);
            this.panelMultiChoiceOptionsContainer.ResumeLayout(false);
            this.panelMultiChoiceOptionsContainer.PerformLayout();
            this.tableLayoutPanelMultiChoiceOptions.ResumeLayout(false);
            this.tableLayoutPanelMultiChoiceD.ResumeLayout(false);
            this.tableLayoutPanelMultiChoiceD.PerformLayout();
            this.tableLayoutPanelMultiChoiceC.ResumeLayout(false);
            this.tableLayoutPanelMultiChoiceC.PerformLayout();
            this.tableLayoutPanelMultiChoiceB.ResumeLayout(false);
            this.tableLayoutPanelMultiChoiceB.PerformLayout();
            this.tableLayoutPanelMultiChoiceA.ResumeLayout(false);
            this.tableLayoutPanelMultiChoiceA.PerformLayout();
            this.panelAnswerOpen.ResumeLayout(false);
            this.panelAnswerSingle.ResumeLayout(false);
            this.panelAnswerSingleAcceptableContainer.ResumeLayout(false);
            this.panelAnswerSingleAcceptableContainer.PerformLayout();
            this.panelAnswerTools.ResumeLayout(false);
            this.contextMenuStripQuestionList.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelMarks.ResumeLayout(false);
            this.panelMarks.PerformLayout();
            this.groupBoxMarks.ResumeLayout(false);
            this.groupBoxMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMarksAssigner)).EndInit();
            this.contextMenuStripQuestionNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDesigner;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMarks;
        private System.Windows.Forms.ToolStripMenuItem checkForQuestionsWithoutMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePdfOfExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withAnswersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutAnswersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assessmentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button buttonAddSubQuestion;
        private System.Windows.Forms.Button buttonAddMajorQuestion;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.Button buttonExpandAll;
        private System.Windows.Forms.TreeView treeViewQuestionList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesignerContainer;
        private System.Windows.Forms.Panel panelQuestionContainer;
        private System.Windows.Forms.Panel panelAnswerAreaContainer;
        private System.Windows.Forms.Panel panelQuestionNameContainer;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.ToolStrip toolStripQuestion;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignCentre;
        private System.Windows.Forms.ToolStripButton toolStripButtonAlignRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonBulletList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonColour;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddImage;
        private System.Windows.Forms.Panel panelAnswerTools;
        private System.Windows.Forms.Label labelAnswerType;
        private System.Windows.Forms.ComboBox comboBoxAnswerType;
        private System.Windows.Forms.Label labelAnswerText;
        private System.Windows.Forms.Panel panelAnswersContainer;
        private System.Windows.Forms.TableLayoutPanel panelAnswerSingle;
        private System.Windows.Forms.Panel panelAnswerSingleAcceptableContainer;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerSingleAcceptable;
        private System.Windows.Forms.Label labelAnswerSingleAcceptable;
        private System.Windows.Forms.Panel panelAnswerOpen;
        private System.Windows.Forms.RichTextBox richTextBoxAnswerOpen;
        private System.Windows.Forms.Panel panelAnswerMultiChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAnswerMultiChoiceContainer;
        private System.Windows.Forms.Panel panelMultiChoiceOptionsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMultiChoiceOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMultiChoiceD;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textBoxMultiChoiceD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMultiChoiceC;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxMultiChoiceC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMultiChoiceB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxMultiChoiceB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMultiChoiceA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxMultiChoiceA;
        private System.Windows.Forms.ComboBox comboBoxAnswerMultiCorrect;
        private System.Windows.Forms.Label labelAnswerMultiCorrect;
        private System.Windows.Forms.NumericUpDown numericUpDownMarksAssigner;
        private System.Windows.Forms.Label labelMarksForQuestion;
        private System.Windows.Forms.GroupBox groupBoxMarks;
        private System.Windows.Forms.Label labelMarksSelectedQuestion;
        private System.Windows.Forms.Label labelMarksSelectedQuestionParentParentNum;
        private System.Windows.Forms.Label labelMarksSelectedQuestionParentNum;
        private System.Windows.Forms.Label labelMarksSelectedQuestionNum;
        private System.Windows.Forms.Label labelMarksWholeAssessmentNum;
        private System.Windows.Forms.Label labelMarksWholeAssessment;
        private System.Windows.Forms.Label labelMarksSelectedQuestionParentParent;
        private System.Windows.Forms.Label labelMarksSelectedQuestionParent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuestionNode;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDelete;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparatorInsert;
        private System.Windows.Forms.ToolStripMenuItem contextMenuInsertAbove;
        private System.Windows.Forms.ToolStripMenuItem contextMenuInsertBelow;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparatorMove;
        private System.Windows.Forms.ToolStripMenuItem contextMenuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem contextMenuMoveDown;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparatorSubQuestion;
        private System.Windows.Forms.ToolStripMenuItem contextMenuAddSubQuestion;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparatorChangeLevel;
        private System.Windows.Forms.ToolStripMenuItem contextMenuChangeLevelUp;
        private System.Windows.Forms.ToolStripMenuItem contextMenuChangeLevelDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolTip buttonToolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuestionList;
        private System.Windows.Forms.ToolStripMenuItem addMajorQuestionToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPagePublish;
        private System.Windows.Forms.TabPage tabPageMark;
    }
}