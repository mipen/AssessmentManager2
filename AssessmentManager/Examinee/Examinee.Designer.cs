namespace AssessmentManager
{
    partial class Examinee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examinee));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTimeBegan = new System.Windows.Forms.Label();
            this.labelBeginning = new System.Windows.Forms.Label();
            this.buttonSubmitAssessment = new System.Windows.Forms.Button();
            this.labelTimeRemainingTimer = new System.Windows.Forms.Label();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.progressBarMarksAttempted = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxUnansweredQuestions = new System.Windows.Forms.ListBox();
            this.labelUnansweredQuestions = new System.Windows.Forms.Label();
            this.labelMarksAttempted = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorSave = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorOpen = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTreeView = new System.Windows.Forms.Panel();
            this.treeViewQuestionDisplay = new System.Windows.Forms.TreeView();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.panelMarks = new System.Windows.Forms.Panel();
            this.labelSubSubQuestionMarksNum = new System.Windows.Forms.Label();
            this.labelSubSubQuestionMarks = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.labelSubQuestionMarksNum = new System.Windows.Forms.Label();
            this.labelQuestionMarksNum = new System.Windows.Forms.Label();
            this.labelSubQuestionMarks = new System.Windows.Forms.Label();
            this.labelQuestionMarks = new System.Windows.Forms.Label();
            this.panelQuestionAnswer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPrevQuestion = new System.Windows.Forms.Button();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.tableLayoutQuestionAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.panelQuestionContainer = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.btnQuestionImage = new System.Windows.Forms.Button();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.panelAnswerContainer = new System.Windows.Forms.Panel();
            this.labelAnswerText = new System.Windows.Forms.Label();
            this.tlpMultiAnswerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpOptionD = new System.Windows.Forms.TableLayoutPanel();
            this.labelOptionD = new System.Windows.Forms.Label();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.tlpOptionC = new System.Windows.Forms.TableLayoutPanel();
            this.labelOptionC = new System.Windows.Forms.Label();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.tlpOptionB = new System.Windows.Forms.TableLayoutPanel();
            this.labelOptionB = new System.Windows.Forms.Label();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.tlpOptionA = new System.Windows.Forms.TableLayoutPanel();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.labelOptionA = new System.Windows.Forms.Label();
            this.panelAnswerShortContainer = new System.Windows.Forms.Panel();
            this.textBoxAnswerShort = new System.Windows.Forms.TextBox();
            this.panelAnswerLongContainer = new System.Windows.Forms.Panel();
            this.rtbAnswerLong = new System.Windows.Forms.RichTextBox();
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTreeView.SuspendLayout();
            this.panelMarks.SuspendLayout();
            this.panelQuestionAnswer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutQuestionAnswer.SuspendLayout();
            this.panelQuestionContainer.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.panelAnswerContainer.SuspendLayout();
            this.tlpMultiAnswerContainer.SuspendLayout();
            this.tlpOptionD.SuspendLayout();
            this.tlpOptionC.SuspendLayout();
            this.tlpOptionB.SuspendLayout();
            this.tlpOptionA.SuspendLayout();
            this.panelAnswerShortContainer.SuspendLayout();
            this.panelAnswerLongContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTimeBegan);
            this.panelTop.Controls.Add(this.labelBeginning);
            this.panelTop.Controls.Add(this.buttonSubmitAssessment);
            this.panelTop.Controls.Add(this.labelTimeRemainingTimer);
            this.panelTop.Controls.Add(this.labelTimeRemaining);
            this.panelTop.Controls.Add(this.progressBarMarksAttempted);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.labelMarksAttempted);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(8, 24);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(2);
            this.panelTop.Size = new System.Drawing.Size(640, 81);
            this.panelTop.TabIndex = 0;
            // 
            // labelTimeBegan
            // 
            this.labelTimeBegan.AutoSize = true;
            this.labelTimeBegan.Location = new System.Drawing.Point(98, 59);
            this.labelTimeBegan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeBegan.Name = "labelTimeBegan";
            this.labelTimeBegan.Size = new System.Drawing.Size(49, 13);
            this.labelTimeBegan.TabIndex = 9;
            this.labelTimeBegan.Text = "00:00:00";
            // 
            // labelBeginning
            // 
            this.labelBeginning.AutoSize = true;
            this.labelBeginning.Location = new System.Drawing.Point(4, 59);
            this.labelBeginning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBeginning.Name = "labelBeginning";
            this.labelBeginning.Size = new System.Drawing.Size(66, 13);
            this.labelBeginning.TabIndex = 8;
            this.labelBeginning.Text = "Time began:";
            // 
            // buttonSubmitAssessment
            // 
            this.buttonSubmitAssessment.Location = new System.Drawing.Point(324, 39);
            this.buttonSubmitAssessment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmitAssessment.Name = "buttonSubmitAssessment";
            this.buttonSubmitAssessment.Size = new System.Drawing.Size(104, 26);
            this.buttonSubmitAssessment.TabIndex = 7;
            this.buttonSubmitAssessment.Text = "Submit assessment";
            this.buttonSubmitAssessment.UseVisualStyleBackColor = true;
            // 
            // labelTimeRemainingTimer
            // 
            this.labelTimeRemainingTimer.AutoSize = true;
            this.labelTimeRemainingTimer.Location = new System.Drawing.Point(98, 39);
            this.labelTimeRemainingTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeRemainingTimer.Name = "labelTimeRemainingTimer";
            this.labelTimeRemainingTimer.Size = new System.Drawing.Size(49, 13);
            this.labelTimeRemainingTimer.TabIndex = 6;
            this.labelTimeRemainingTimer.Text = "00:00:00";
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.Location = new System.Drawing.Point(4, 39);
            this.labelTimeRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(81, 13);
            this.labelTimeRemaining.TabIndex = 5;
            this.labelTimeRemaining.Text = "Time remaining:";
            // 
            // progressBarMarksAttempted
            // 
            this.progressBarMarksAttempted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMarksAttempted.Location = new System.Drawing.Point(174, 5);
            this.progressBarMarksAttempted.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarMarksAttempted.Name = "progressBarMarksAttempted";
            this.progressBarMarksAttempted.Size = new System.Drawing.Size(272, 19);
            this.progressBarMarksAttempted.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxUnansweredQuestions);
            this.panel2.Controls.Add(this.labelUnansweredQuestions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(450, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 77);
            this.panel2.TabIndex = 3;
            // 
            // listBoxUnansweredQuestions
            // 
            this.listBoxUnansweredQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxUnansweredQuestions.FormattingEnabled = true;
            this.listBoxUnansweredQuestions.Location = new System.Drawing.Point(0, 21);
            this.listBoxUnansweredQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUnansweredQuestions.Name = "listBoxUnansweredQuestions";
            this.listBoxUnansweredQuestions.Size = new System.Drawing.Size(188, 56);
            this.listBoxUnansweredQuestions.TabIndex = 1;
            // 
            // labelUnansweredQuestions
            // 
            this.labelUnansweredQuestions.AutoSize = true;
            this.labelUnansweredQuestions.Location = new System.Drawing.Point(2, 0);
            this.labelUnansweredQuestions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnansweredQuestions.Name = "labelUnansweredQuestions";
            this.labelUnansweredQuestions.Size = new System.Drawing.Size(187, 13);
            this.labelUnansweredQuestions.TabIndex = 0;
            this.labelUnansweredQuestions.Text = "Unanswered Questions (click to go to)";
            // 
            // labelMarksAttempted
            // 
            this.labelMarksAttempted.AutoSize = true;
            this.labelMarksAttempted.Location = new System.Drawing.Point(13, 10);
            this.labelMarksAttempted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarksAttempted.Name = "labelMarksAttempted";
            this.labelMarksAttempted.Size = new System.Drawing.Size(120, 13);
            this.labelMarksAttempted.TabIndex = 1;
            this.labelMarksAttempted.Text = "x/y marks attempted (%)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(8, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparatorSave,
            this.toolStripMenuItemOpen,
            this.toolStripSeparatorOpen,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparatorSave
            // 
            this.toolStripSeparatorSave.Name = "toolStripSeparatorSave";
            this.toolStripSeparatorSave.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Enabled = false;
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemOpen.Text = "&Open";
            this.toolStripMenuItemOpen.Visible = false;
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripSeparatorOpen
            // 
            this.toolStripSeparatorOpen.Name = "toolStripSeparatorOpen";
            this.toolStripSeparatorOpen.Size = new System.Drawing.Size(100, 6);
            this.toolStripSeparatorOpen.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelTreeView);
            this.panelLeft.Controls.Add(this.panelMarks);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(8, 105);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.MinimumSize = new System.Drawing.Size(170, 122);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(2);
            this.panelLeft.Size = new System.Drawing.Size(170, 340);
            this.panelLeft.TabIndex = 2;
            // 
            // panelTreeView
            // 
            this.panelTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTreeView.Controls.Add(this.treeViewQuestionDisplay);
            this.panelTreeView.Controls.Add(this.buttonCollapse);
            this.panelTreeView.Controls.Add(this.buttonExpand);
            this.panelTreeView.Location = new System.Drawing.Point(2, 2);
            this.panelTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.panelTreeView.MinimumSize = new System.Drawing.Size(164, 0);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Size = new System.Drawing.Size(164, 252);
            this.panelTreeView.TabIndex = 2;
            // 
            // treeViewQuestionDisplay
            // 
            this.treeViewQuestionDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewQuestionDisplay.Location = new System.Drawing.Point(0, 0);
            this.treeViewQuestionDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewQuestionDisplay.Name = "treeViewQuestionDisplay";
            this.treeViewQuestionDisplay.Size = new System.Drawing.Size(164, 216);
            this.treeViewQuestionDisplay.TabIndex = 0;
            this.treeViewQuestionDisplay.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewQuestionDisplay_AfterSelect);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollapse.Image = global::AssessmentManager.Properties.Resources.collapse_all32;
            this.buttonCollapse.Location = new System.Drawing.Point(130, 218);
            this.buttonCollapse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(32, 32);
            this.buttonCollapse.TabIndex = 2;
            this.toolTipButtons.SetToolTip(this.buttonCollapse, "Collapse all");
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExpand.Image = global::AssessmentManager.Properties.Resources.expand_all32;
            this.buttonExpand.Location = new System.Drawing.Point(2, 218);
            this.buttonExpand.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(32, 32);
            this.buttonExpand.TabIndex = 1;
            this.toolTipButtons.SetToolTip(this.buttonExpand, "Expand all");
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // panelMarks
            // 
            this.panelMarks.Controls.Add(this.labelSubSubQuestionMarksNum);
            this.panelMarks.Controls.Add(this.labelSubSubQuestionMarks);
            this.panelMarks.Controls.Add(this.panelDivider);
            this.panelMarks.Controls.Add(this.labelSubQuestionMarksNum);
            this.panelMarks.Controls.Add(this.labelQuestionMarksNum);
            this.panelMarks.Controls.Add(this.labelSubQuestionMarks);
            this.panelMarks.Controls.Add(this.labelQuestionMarks);
            this.panelMarks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMarks.Location = new System.Drawing.Point(2, 257);
            this.panelMarks.Margin = new System.Windows.Forms.Padding(2);
            this.panelMarks.MinimumSize = new System.Drawing.Size(166, 81);
            this.panelMarks.Name = "panelMarks";
            this.panelMarks.Size = new System.Drawing.Size(166, 81);
            this.panelMarks.TabIndex = 1;
            // 
            // labelSubSubQuestionMarksNum
            // 
            this.labelSubSubQuestionMarksNum.Location = new System.Drawing.Point(90, 53);
            this.labelSubSubQuestionMarksNum.Name = "labelSubSubQuestionMarksNum";
            this.labelSubSubQuestionMarksNum.Size = new System.Drawing.Size(72, 13);
            this.labelSubSubQuestionMarksNum.TabIndex = 9;
            this.labelSubSubQuestionMarksNum.Text = "x";
            this.labelSubSubQuestionMarksNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubSubQuestionMarks
            // 
            this.labelSubSubQuestionMarks.AutoSize = true;
            this.labelSubSubQuestionMarks.Location = new System.Drawing.Point(7, 53);
            this.labelSubSubQuestionMarks.Name = "labelSubSubQuestionMarks";
            this.labelSubSubQuestionMarks.Size = new System.Drawing.Size(87, 13);
            this.labelSubSubQuestionMarks.TabIndex = 8;
            this.labelSubSubQuestionMarks.Text = "sub sub question";
            this.labelSubSubQuestionMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDivider
            // 
            this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDivider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDivider.Location = new System.Drawing.Point(8, 0);
            this.panelDivider.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(151, 1);
            this.panelDivider.TabIndex = 7;
            // 
            // labelSubQuestionMarksNum
            // 
            this.labelSubQuestionMarksNum.Location = new System.Drawing.Point(90, 35);
            this.labelSubQuestionMarksNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubQuestionMarksNum.Name = "labelSubQuestionMarksNum";
            this.labelSubQuestionMarksNum.Size = new System.Drawing.Size(72, 13);
            this.labelSubQuestionMarksNum.TabIndex = 6;
            this.labelSubQuestionMarksNum.Text = "x";
            this.labelSubQuestionMarksNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQuestionMarksNum
            // 
            this.labelQuestionMarksNum.Location = new System.Drawing.Point(90, 17);
            this.labelQuestionMarksNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestionMarksNum.Name = "labelQuestionMarksNum";
            this.labelQuestionMarksNum.Size = new System.Drawing.Size(72, 13);
            this.labelQuestionMarksNum.TabIndex = 5;
            this.labelQuestionMarksNum.Text = "x";
            this.labelQuestionMarksNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubQuestionMarks
            // 
            this.labelSubQuestionMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSubQuestionMarks.AutoSize = true;
            this.labelSubQuestionMarks.Location = new System.Drawing.Point(7, 35);
            this.labelSubQuestionMarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubQuestionMarks.Name = "labelSubQuestionMarks";
            this.labelSubQuestionMarks.Size = new System.Drawing.Size(67, 13);
            this.labelSubQuestionMarks.TabIndex = 4;
            this.labelSubQuestionMarks.Text = "sub question";
            this.labelSubQuestionMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuestionMarks
            // 
            this.labelQuestionMarks.AutoSize = true;
            this.labelQuestionMarks.Location = new System.Drawing.Point(7, 17);
            this.labelQuestionMarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestionMarks.Name = "labelQuestionMarks";
            this.labelQuestionMarks.Size = new System.Drawing.Size(47, 13);
            this.labelQuestionMarks.TabIndex = 3;
            this.labelQuestionMarks.Text = "question";
            this.labelQuestionMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelQuestionAnswer
            // 
            this.panelQuestionAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestionAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestionAnswer.Controls.Add(this.tableLayoutPanel1);
            this.panelQuestionAnswer.Controls.Add(this.tableLayoutQuestionAnswer);
            this.panelQuestionAnswer.Location = new System.Drawing.Point(182, 109);
            this.panelQuestionAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestionAnswer.Name = "panelQuestionAnswer";
            this.panelQuestionAnswer.Size = new System.Drawing.Size(466, 336);
            this.panelQuestionAnswer.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPrevQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNextQuestion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 294);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonPrevQuestion
            // 
            this.buttonPrevQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevQuestion.Image = global::AssessmentManager.Properties.Resources._1457348260_ic_arrow_back_48px;
            this.buttonPrevQuestion.Location = new System.Drawing.Point(100, 4);
            this.buttonPrevQuestion.Name = "buttonPrevQuestion";
            this.buttonPrevQuestion.Size = new System.Drawing.Size(32, 32);
            this.buttonPrevQuestion.TabIndex = 0;
            this.toolTipButtons.SetToolTip(this.buttonPrevQuestion, "Previous question");
            this.buttonPrevQuestion.UseVisualStyleBackColor = true;
            this.buttonPrevQuestion.Click += new System.EventHandler(this.buttonPrevQuestion_Click);
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextQuestion.Image = global::AssessmentManager.Properties.Resources._1457348170_ic_arrow_forward_48px;
            this.buttonNextQuestion.Location = new System.Drawing.Point(332, 4);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(32, 32);
            this.buttonNextQuestion.TabIndex = 1;
            this.toolTipButtons.SetToolTip(this.buttonNextQuestion, "Next question");
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // tableLayoutQuestionAnswer
            // 
            this.tableLayoutQuestionAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutQuestionAnswer.ColumnCount = 1;
            this.tableLayoutQuestionAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutQuestionAnswer.Controls.Add(this.panelQuestionContainer, 0, 0);
            this.tableLayoutQuestionAnswer.Controls.Add(this.panelAnswerContainer, 0, 1);
            this.tableLayoutQuestionAnswer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutQuestionAnswer.Name = "tableLayoutQuestionAnswer";
            this.tableLayoutQuestionAnswer.RowCount = 2;
            this.tableLayoutQuestionAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutQuestionAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutQuestionAnswer.Size = new System.Drawing.Size(466, 291);
            this.tableLayoutQuestionAnswer.TabIndex = 0;
            // 
            // panelQuestionContainer
            // 
            this.panelQuestionContainer.Controls.Add(this.panelQuestion);
            this.panelQuestionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestionContainer.Location = new System.Drawing.Point(3, 3);
            this.panelQuestionContainer.Name = "panelQuestionContainer";
            this.panelQuestionContainer.Size = new System.Drawing.Size(460, 139);
            this.panelQuestionContainer.TabIndex = 0;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.btnQuestionImage);
            this.panelQuestion.Controls.Add(this.rtbQuestion);
            this.panelQuestion.Controls.Add(this.lblQuestionNumber);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(460, 139);
            this.panelQuestion.TabIndex = 2;
            // 
            // btnQuestionImage
            // 
            this.btnQuestionImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuestionImage.Location = new System.Drawing.Point(402, 0);
            this.btnQuestionImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuestionImage.Name = "btnQuestionImage";
            this.btnQuestionImage.Size = new System.Drawing.Size(56, 21);
            this.btnQuestionImage.TabIndex = 2;
            this.btnQuestionImage.Text = "&Image";
            this.btnQuestionImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuestionImage.UseVisualStyleBackColor = true;
            this.btnQuestionImage.Click += new System.EventHandler(this.btnQuestionImage_Click);
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.rtbQuestion.Location = new System.Drawing.Point(0, 25);
            this.rtbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.ReadOnly = true;
            this.rtbQuestion.Size = new System.Drawing.Size(460, 114);
            this.rtbQuestion.TabIndex = 1;
            this.rtbQuestion.Text = "";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuestionNumber.Location = new System.Drawing.Point(0, 0);
            this.lblQuestionNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(49, 13);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Question";
            // 
            // panelAnswerContainer
            // 
            this.panelAnswerContainer.Controls.Add(this.labelAnswerText);
            this.panelAnswerContainer.Controls.Add(this.tlpMultiAnswerContainer);
            this.panelAnswerContainer.Controls.Add(this.panelAnswerShortContainer);
            this.panelAnswerContainer.Controls.Add(this.panelAnswerLongContainer);
            this.panelAnswerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnswerContainer.Location = new System.Drawing.Point(3, 148);
            this.panelAnswerContainer.Name = "panelAnswerContainer";
            this.panelAnswerContainer.Size = new System.Drawing.Size(460, 140);
            this.panelAnswerContainer.TabIndex = 1;
            // 
            // labelAnswerText
            // 
            this.labelAnswerText.AutoSize = true;
            this.labelAnswerText.Location = new System.Drawing.Point(0, 0);
            this.labelAnswerText.Name = "labelAnswerText";
            this.labelAnswerText.Size = new System.Drawing.Size(42, 13);
            this.labelAnswerText.TabIndex = 0;
            this.labelAnswerText.Text = "Answer";
            // 
            // tlpMultiAnswerContainer
            // 
            this.tlpMultiAnswerContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMultiAnswerContainer.ColumnCount = 2;
            this.tlpMultiAnswerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMultiAnswerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMultiAnswerContainer.Controls.Add(this.tlpOptionD, 1, 1);
            this.tlpMultiAnswerContainer.Controls.Add(this.tlpOptionC, 0, 1);
            this.tlpMultiAnswerContainer.Controls.Add(this.tlpOptionB, 1, 0);
            this.tlpMultiAnswerContainer.Controls.Add(this.tlpOptionA, 0, 0);
            this.tlpMultiAnswerContainer.Location = new System.Drawing.Point(0, 16);
            this.tlpMultiAnswerContainer.Name = "tlpMultiAnswerContainer";
            this.tlpMultiAnswerContainer.RowCount = 2;
            this.tlpMultiAnswerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMultiAnswerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMultiAnswerContainer.Size = new System.Drawing.Size(460, 71);
            this.tlpMultiAnswerContainer.TabIndex = 2;
            // 
            // tlpOptionD
            // 
            this.tlpOptionD.ColumnCount = 2;
            this.tlpOptionD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOptionD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionD.Controls.Add(this.labelOptionD, 0, 0);
            this.tlpOptionD.Controls.Add(this.rbOptionD, 0, 0);
            this.tlpOptionD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionD.Location = new System.Drawing.Point(233, 38);
            this.tlpOptionD.Name = "tlpOptionD";
            this.tlpOptionD.RowCount = 1;
            this.tlpOptionD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionD.Size = new System.Drawing.Size(224, 30);
            this.tlpOptionD.TabIndex = 3;
            // 
            // labelOptionD
            // 
            this.labelOptionD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOptionD.AutoSize = true;
            this.labelOptionD.Location = new System.Drawing.Point(23, 8);
            this.labelOptionD.Name = "labelOptionD";
            this.labelOptionD.Size = new System.Drawing.Size(35, 13);
            this.labelOptionD.TabIndex = 2;
            this.labelOptionD.Text = "label1";
            // 
            // rbOptionD
            // 
            this.rbOptionD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Location = new System.Drawing.Point(3, 6);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(14, 17);
            this.rbOptionD.TabIndex = 1;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "radioButton1";
            this.rbOptionD.UseVisualStyleBackColor = true;
            this.rbOptionD.Click += new System.EventHandler(this.rbOptionD_Click);
            // 
            // tlpOptionC
            // 
            this.tlpOptionC.ColumnCount = 2;
            this.tlpOptionC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOptionC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionC.Controls.Add(this.labelOptionC, 0, 0);
            this.tlpOptionC.Controls.Add(this.rbOptionC, 0, 0);
            this.tlpOptionC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionC.Location = new System.Drawing.Point(3, 38);
            this.tlpOptionC.Name = "tlpOptionC";
            this.tlpOptionC.RowCount = 1;
            this.tlpOptionC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionC.Size = new System.Drawing.Size(224, 30);
            this.tlpOptionC.TabIndex = 2;
            // 
            // labelOptionC
            // 
            this.labelOptionC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOptionC.AutoSize = true;
            this.labelOptionC.Location = new System.Drawing.Point(23, 8);
            this.labelOptionC.Name = "labelOptionC";
            this.labelOptionC.Size = new System.Drawing.Size(35, 13);
            this.labelOptionC.TabIndex = 2;
            this.labelOptionC.Text = "label1";
            // 
            // rbOptionC
            // 
            this.rbOptionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Location = new System.Drawing.Point(3, 6);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(14, 17);
            this.rbOptionC.TabIndex = 1;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "radioButton1";
            this.rbOptionC.UseVisualStyleBackColor = true;
            this.rbOptionC.Click += new System.EventHandler(this.rbOptionC_Click);
            // 
            // tlpOptionB
            // 
            this.tlpOptionB.ColumnCount = 2;
            this.tlpOptionB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOptionB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionB.Controls.Add(this.labelOptionB, 1, 0);
            this.tlpOptionB.Controls.Add(this.rbOptionB, 0, 0);
            this.tlpOptionB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionB.Location = new System.Drawing.Point(233, 3);
            this.tlpOptionB.Name = "tlpOptionB";
            this.tlpOptionB.RowCount = 1;
            this.tlpOptionB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionB.Size = new System.Drawing.Size(224, 29);
            this.tlpOptionB.TabIndex = 1;
            // 
            // labelOptionB
            // 
            this.labelOptionB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOptionB.AutoSize = true;
            this.labelOptionB.Location = new System.Drawing.Point(23, 8);
            this.labelOptionB.Name = "labelOptionB";
            this.labelOptionB.Size = new System.Drawing.Size(35, 13);
            this.labelOptionB.TabIndex = 2;
            this.labelOptionB.Text = "label1";
            // 
            // rbOptionB
            // 
            this.rbOptionB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(3, 6);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(14, 17);
            this.rbOptionB.TabIndex = 1;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "radioButton1";
            this.rbOptionB.UseVisualStyleBackColor = true;
            this.rbOptionB.Click += new System.EventHandler(this.rbOptionB_Click);
            // 
            // tlpOptionA
            // 
            this.tlpOptionA.ColumnCount = 2;
            this.tlpOptionA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOptionA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionA.Controls.Add(this.rbOptionA, 0, 0);
            this.tlpOptionA.Controls.Add(this.labelOptionA, 1, 0);
            this.tlpOptionA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptionA.Location = new System.Drawing.Point(3, 3);
            this.tlpOptionA.Name = "tlpOptionA";
            this.tlpOptionA.RowCount = 1;
            this.tlpOptionA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionA.Size = new System.Drawing.Size(224, 29);
            this.tlpOptionA.TabIndex = 0;
            // 
            // rbOptionA
            // 
            this.rbOptionA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(3, 6);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(14, 17);
            this.rbOptionA.TabIndex = 0;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "radioButton1";
            this.rbOptionA.UseVisualStyleBackColor = true;
            this.rbOptionA.Click += new System.EventHandler(this.rbOptionA_Click);
            // 
            // labelOptionA
            // 
            this.labelOptionA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOptionA.AutoSize = true;
            this.labelOptionA.Location = new System.Drawing.Point(23, 8);
            this.labelOptionA.Name = "labelOptionA";
            this.labelOptionA.Size = new System.Drawing.Size(35, 13);
            this.labelOptionA.TabIndex = 1;
            this.labelOptionA.Text = "label1";
            // 
            // panelAnswerShortContainer
            // 
            this.panelAnswerShortContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerShortContainer.Controls.Add(this.textBoxAnswerShort);
            this.panelAnswerShortContainer.Location = new System.Drawing.Point(0, 16);
            this.panelAnswerShortContainer.Name = "panelAnswerShortContainer";
            this.panelAnswerShortContainer.Size = new System.Drawing.Size(460, 124);
            this.panelAnswerShortContainer.TabIndex = 1;
            // 
            // textBoxAnswerShort
            // 
            this.textBoxAnswerShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswerShort.Location = new System.Drawing.Point(3, 51);
            this.textBoxAnswerShort.Name = "textBoxAnswerShort";
            this.textBoxAnswerShort.Size = new System.Drawing.Size(454, 20);
            this.textBoxAnswerShort.TabIndex = 0;
            // 
            // panelAnswerLongContainer
            // 
            this.panelAnswerLongContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerLongContainer.Controls.Add(this.rtbAnswerLong);
            this.panelAnswerLongContainer.Location = new System.Drawing.Point(0, 16);
            this.panelAnswerLongContainer.Name = "panelAnswerLongContainer";
            this.panelAnswerLongContainer.Size = new System.Drawing.Size(460, 124);
            this.panelAnswerLongContainer.TabIndex = 0;
            // 
            // rtbAnswerLong
            // 
            this.rtbAnswerLong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAnswerLong.Location = new System.Drawing.Point(0, 0);
            this.rtbAnswerLong.Name = "rtbAnswerLong";
            this.rtbAnswerLong.Size = new System.Drawing.Size(460, 124);
            this.rtbAnswerLong.TabIndex = 0;
            this.rtbAnswerLong.Text = "";
            // 
            // Examinee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 453);
            this.Controls.Add(this.panelQuestionAnswer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(672, 492);
            this.Name = "Examinee";
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.Text = "Examinee";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelTreeView.ResumeLayout(false);
            this.panelMarks.ResumeLayout(false);
            this.panelMarks.PerformLayout();
            this.panelQuestionAnswer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutQuestionAnswer.ResumeLayout(false);
            this.panelQuestionContainer.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panelAnswerContainer.ResumeLayout(false);
            this.panelAnswerContainer.PerformLayout();
            this.tlpMultiAnswerContainer.ResumeLayout(false);
            this.tlpOptionD.ResumeLayout(false);
            this.tlpOptionD.PerformLayout();
            this.tlpOptionC.ResumeLayout(false);
            this.tlpOptionC.PerformLayout();
            this.tlpOptionB.ResumeLayout(false);
            this.tlpOptionB.PerformLayout();
            this.tlpOptionA.ResumeLayout(false);
            this.tlpOptionA.PerformLayout();
            this.panelAnswerShortContainer.ResumeLayout(false);
            this.panelAnswerShortContainer.PerformLayout();
            this.panelAnswerLongContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSave;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelMarksAttempted;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelSubQuestionMarks;
        private System.Windows.Forms.Label labelQuestionMarks;
        private System.Windows.Forms.Label labelSubQuestionMarksNum;
        private System.Windows.Forms.Label labelQuestionMarksNum;
        private System.Windows.Forms.Panel panelMarks;
        private System.Windows.Forms.Panel panelTreeView;
        private System.Windows.Forms.TreeView treeViewQuestionDisplay;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Panel panelQuestionAnswer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxUnansweredQuestions;
        private System.Windows.Forms.Label labelUnansweredQuestions;
        private System.Windows.Forms.Button buttonSubmitAssessment;
        private System.Windows.Forms.Label labelTimeRemainingTimer;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.ProgressBar progressBarMarksAttempted;
        private System.Windows.Forms.Label labelTimeBegan;
        private System.Windows.Forms.Label labelBeginning;
        private System.Windows.Forms.TableLayoutPanel tableLayoutQuestionAnswer;
        private System.Windows.Forms.Panel panelQuestionContainer;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Button btnQuestionImage;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Panel panelAnswerContainer;
        private System.Windows.Forms.Label labelAnswerText;
        private System.Windows.Forms.Panel panelAnswerShortContainer;
        private System.Windows.Forms.Panel panelAnswerLongContainer;
        private System.Windows.Forms.RichTextBox rtbAnswerLong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPrevQuestion;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.ToolTip toolTipButtons;
        private System.Windows.Forms.Label labelSubSubQuestionMarks;
        private System.Windows.Forms.Label labelSubSubQuestionMarksNum;
        private System.Windows.Forms.TextBox textBoxAnswerShort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorOpen;
        private System.Windows.Forms.TableLayoutPanel tlpMultiAnswerContainer;
        private System.Windows.Forms.TableLayoutPanel tlpOptionA;
        private System.Windows.Forms.TableLayoutPanel tlpOptionD;
        private System.Windows.Forms.TableLayoutPanel tlpOptionC;
        private System.Windows.Forms.TableLayoutPanel tlpOptionB;
        private System.Windows.Forms.Label labelOptionD;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Label labelOptionC;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.Label labelOptionB;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.Label labelOptionA;
    }
}