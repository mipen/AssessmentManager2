namespace ExamManager
{
    partial class Examiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examiner));
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTreeView = new System.Windows.Forms.Panel();
            this.treeViewQuestionDisplay = new System.Windows.Forms.TreeView();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.panelMarks = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSubQuestionMarks = new System.Windows.Forms.Label();
            this.labelQuestionMarks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelQuestionAnswer = new System.Windows.Forms.Panel();
            this.panelAnswerLong = new System.Windows.Forms.Panel();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.panelNextPrevButtons = new System.Windows.Forms.Panel();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.buttonPreviousQuestion = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.buttonShowQuestionImage = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTreeView.SuspendLayout();
            this.panelMarks.SuspendLayout();
            this.panelQuestionAnswer.SuspendLayout();
            this.panelAnswerLong.SuspendLayout();
            this.panelNextPrevButtons.SuspendLayout();
            this.panelQuestion.SuspendLayout();
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
            this.panelTop.Location = new System.Drawing.Point(10, 28);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(3);
            this.panelTop.Size = new System.Drawing.Size(855, 100);
            this.panelTop.TabIndex = 0;
            // 
            // labelTimeBegan
            // 
            this.labelTimeBegan.AutoSize = true;
            this.labelTimeBegan.Location = new System.Drawing.Point(131, 73);
            this.labelTimeBegan.Name = "labelTimeBegan";
            this.labelTimeBegan.Size = new System.Drawing.Size(64, 17);
            this.labelTimeBegan.TabIndex = 9;
            this.labelTimeBegan.Text = "00:00:00";
            // 
            // labelBeginning
            // 
            this.labelBeginning.AutoSize = true;
            this.labelBeginning.Location = new System.Drawing.Point(6, 73);
            this.labelBeginning.Name = "labelBeginning";
            this.labelBeginning.Size = new System.Drawing.Size(87, 17);
            this.labelBeginning.TabIndex = 8;
            this.labelBeginning.Text = "Time began:";
            // 
            // buttonSubmitAssessment
            // 
            this.buttonSubmitAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmitAssessment.Location = new System.Drawing.Point(457, 48);
            this.buttonSubmitAssessment.Name = "buttonSubmitAssessment";
            this.buttonSubmitAssessment.Size = new System.Drawing.Size(139, 32);
            this.buttonSubmitAssessment.TabIndex = 7;
            this.buttonSubmitAssessment.Text = "Submit assessment";
            this.buttonSubmitAssessment.UseVisualStyleBackColor = true;
            // 
            // labelTimeRemainingTimer
            // 
            this.labelTimeRemainingTimer.AutoSize = true;
            this.labelTimeRemainingTimer.Location = new System.Drawing.Point(131, 48);
            this.labelTimeRemainingTimer.Name = "labelTimeRemainingTimer";
            this.labelTimeRemainingTimer.Size = new System.Drawing.Size(64, 17);
            this.labelTimeRemainingTimer.TabIndex = 6;
            this.labelTimeRemainingTimer.Text = "00:00:00";
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.Location = new System.Drawing.Point(6, 48);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(109, 17);
            this.labelTimeRemaining.TabIndex = 5;
            this.labelTimeRemaining.Text = "Time remaining:";
            // 
            // progressBarMarksAttempted
            // 
            this.progressBarMarksAttempted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarMarksAttempted.Location = new System.Drawing.Point(213, 6);
            this.progressBarMarksAttempted.Name = "progressBarMarksAttempted";
            this.progressBarMarksAttempted.Size = new System.Drawing.Size(383, 23);
            this.progressBarMarksAttempted.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxUnansweredQuestions);
            this.panel2.Controls.Add(this.labelUnansweredQuestions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(602, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 94);
            this.panel2.TabIndex = 3;
            // 
            // listBoxUnansweredQuestions
            // 
            this.listBoxUnansweredQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxUnansweredQuestions.FormattingEnabled = true;
            this.listBoxUnansweredQuestions.ItemHeight = 16;
            this.listBoxUnansweredQuestions.Location = new System.Drawing.Point(0, 26);
            this.listBoxUnansweredQuestions.Name = "listBoxUnansweredQuestions";
            this.listBoxUnansweredQuestions.Size = new System.Drawing.Size(250, 68);
            this.listBoxUnansweredQuestions.TabIndex = 1;
            // 
            // labelUnansweredQuestions
            // 
            this.labelUnansweredQuestions.AutoSize = true;
            this.labelUnansweredQuestions.Location = new System.Drawing.Point(3, 0);
            this.labelUnansweredQuestions.Name = "labelUnansweredQuestions";
            this.labelUnansweredQuestions.Size = new System.Drawing.Size(248, 17);
            this.labelUnansweredQuestions.TabIndex = 0;
            this.labelUnansweredQuestions.Text = "Unanswered Questions (click to go to)";
            // 
            // labelMarksAttempted
            // 
            this.labelMarksAttempted.AutoSize = true;
            this.labelMarksAttempted.Location = new System.Drawing.Point(17, 12);
            this.labelMarksAttempted.Name = "labelMarksAttempted";
            this.labelMarksAttempted.Size = new System.Drawing.Size(160, 17);
            this.labelMarksAttempted.TabIndex = 1;
            this.labelMarksAttempted.Text = "x/y marks attempted (%)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelTreeView);
            this.panelLeft.Controls.Add(this.panelMarks);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(10, 128);
            this.panelLeft.MinimumSize = new System.Drawing.Size(227, 150);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft.Size = new System.Drawing.Size(227, 419);
            this.panelLeft.TabIndex = 2;
            // 
            // panelTreeView
            // 
            this.panelTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTreeView.Controls.Add(this.treeViewQuestionDisplay);
            this.panelTreeView.Controls.Add(this.buttonCollapse);
            this.panelTreeView.Controls.Add(this.buttonExpand);
            this.panelTreeView.Location = new System.Drawing.Point(3, 3);
            this.panelTreeView.MinimumSize = new System.Drawing.Size(219, 0);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Size = new System.Drawing.Size(219, 309);
            this.panelTreeView.TabIndex = 2;
            // 
            // treeViewQuestionDisplay
            // 
            this.treeViewQuestionDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewQuestionDisplay.Location = new System.Drawing.Point(0, 0);
            this.treeViewQuestionDisplay.Name = "treeViewQuestionDisplay";
            this.treeViewQuestionDisplay.Size = new System.Drawing.Size(217, 276);
            this.treeViewQuestionDisplay.TabIndex = 0;
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCollapse.Location = new System.Drawing.Point(118, 280);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(100, 28);
            this.buttonCollapse.TabIndex = 2;
            this.buttonCollapse.Text = "&Collapse all";
            this.buttonCollapse.UseVisualStyleBackColor = true;
            // 
            // buttonExpand
            // 
            this.buttonExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExpand.Location = new System.Drawing.Point(3, 280);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(100, 28);
            this.buttonExpand.TabIndex = 1;
            this.buttonExpand.Text = "E&xpand all";
            this.buttonExpand.UseVisualStyleBackColor = true;
            // 
            // panelMarks
            // 
            this.panelMarks.Controls.Add(this.panel5);
            this.panelMarks.Controls.Add(this.labelSubQuestionMarks);
            this.panelMarks.Controls.Add(this.labelQuestionMarks);
            this.panelMarks.Controls.Add(this.label4);
            this.panelMarks.Controls.Add(this.label3);
            this.panelMarks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMarks.Location = new System.Drawing.Point(3, 316);
            this.panelMarks.MinimumSize = new System.Drawing.Size(221, 100);
            this.panelMarks.Name = "panelMarks";
            this.panelMarks.Size = new System.Drawing.Size(221, 100);
            this.panelMarks.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 1);
            this.panel5.TabIndex = 7;
            // 
            // labelSubQuestionMarks
            // 
            this.labelSubQuestionMarks.AutoSize = true;
            this.labelSubQuestionMarks.Location = new System.Drawing.Point(160, 62);
            this.labelSubQuestionMarks.Name = "labelSubQuestionMarks";
            this.labelSubQuestionMarks.Size = new System.Drawing.Size(14, 17);
            this.labelSubQuestionMarks.TabIndex = 6;
            this.labelSubQuestionMarks.Text = "x";
            // 
            // labelQuestionMarks
            // 
            this.labelQuestionMarks.AutoSize = true;
            this.labelQuestionMarks.Location = new System.Drawing.Point(160, 22);
            this.labelQuestionMarks.Name = "labelQuestionMarks";
            this.labelQuestionMarks.Size = new System.Drawing.Size(14, 17);
            this.labelQuestionMarks.TabIndex = 5;
            this.labelQuestionMarks.Text = "x";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sub-questions marks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Question marks:";
            // 
            // panelQuestionAnswer
            // 
            this.panelQuestionAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestionAnswer.Controls.Add(this.panelAnswerLong);
            this.panelQuestionAnswer.Controls.Add(this.panelNextPrevButtons);
            this.panelQuestionAnswer.Controls.Add(this.panelQuestion);
            this.panelQuestionAnswer.Location = new System.Drawing.Point(243, 134);
            this.panelQuestionAnswer.Name = "panelQuestionAnswer";
            this.panelQuestionAnswer.Padding = new System.Windows.Forms.Padding(5);
            this.panelQuestionAnswer.Size = new System.Drawing.Size(622, 413);
            this.panelQuestionAnswer.TabIndex = 3;
            // 
            // panelAnswerLong
            // 
            this.panelAnswerLong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnswerLong.Controls.Add(this.richTextBoxAnswer);
            this.panelAnswerLong.Controls.Add(this.labelAnswer);
            this.panelAnswerLong.Location = new System.Drawing.Point(5, 160);
            this.panelAnswerLong.Name = "panelAnswerLong";
            this.panelAnswerLong.Size = new System.Drawing.Size(612, 208);
            this.panelAnswerLong.TabIndex = 2;
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxAnswer.Location = new System.Drawing.Point(0, 16);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(612, 192);
            this.richTextBoxAnswer.TabIndex = 1;
            this.richTextBoxAnswer.Text = "";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnswer.Location = new System.Drawing.Point(0, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(54, 17);
            this.labelAnswer.TabIndex = 0;
            this.labelAnswer.Text = "Answer";
            // 
            // panelNextPrevButtons
            // 
            this.panelNextPrevButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNextPrevButtons.Controls.Add(this.buttonNextQuestion);
            this.panelNextPrevButtons.Controls.Add(this.buttonPreviousQuestion);
            this.panelNextPrevButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNextPrevButtons.Location = new System.Drawing.Point(5, 372);
            this.panelNextPrevButtons.Name = "panelNextPrevButtons";
            this.panelNextPrevButtons.Padding = new System.Windows.Forms.Padding(3);
            this.panelNextPrevButtons.Size = new System.Drawing.Size(612, 36);
            this.panelNextPrevButtons.TabIndex = 1;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextQuestion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNextQuestion.BackgroundImage")));
            this.buttonNextQuestion.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextQuestion.Image")));
            this.buttonNextQuestion.Location = new System.Drawing.Point(503, 1);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(32, 32);
            this.buttonNextQuestion.TabIndex = 1;
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousQuestion
            // 
            this.buttonPreviousQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPreviousQuestion.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousQuestion.Image")));
            this.buttonPreviousQuestion.Location = new System.Drawing.Point(75, 1);
            this.buttonPreviousQuestion.Name = "buttonPreviousQuestion";
            this.buttonPreviousQuestion.Size = new System.Drawing.Size(32, 32);
            this.buttonPreviousQuestion.TabIndex = 0;
            this.buttonPreviousQuestion.UseVisualStyleBackColor = true;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.buttonShowQuestionImage);
            this.panelQuestion.Controls.Add(this.richTextBox1);
            this.panelQuestion.Controls.Add(this.labelQuestionNumber);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion.Location = new System.Drawing.Point(5, 5);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(612, 149);
            this.panelQuestion.TabIndex = 0;
            // 
            // buttonShowQuestionImage
            // 
            this.buttonShowQuestionImage.Location = new System.Drawing.Point(534, 3);
            this.buttonShowQuestionImage.Name = "buttonShowQuestionImage";
            this.buttonShowQuestionImage.Size = new System.Drawing.Size(75, 23);
            this.buttonShowQuestionImage.TabIndex = 2;
            this.buttonShowQuestionImage.Text = "Image";
            this.buttonShowQuestionImage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(612, 119);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestionNumber.Location = new System.Drawing.Point(0, 0);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(65, 17);
            this.labelQuestionNumber.TabIndex = 0;
            this.labelQuestionNumber.Text = "Question";
            // 
            // Examiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 557);
            this.Controls.Add(this.panelQuestionAnswer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(529, 434);
            this.Name = "Examiner";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "ExamTaker";
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
            this.panelAnswerLong.ResumeLayout(false);
            this.panelAnswerLong.PerformLayout();
            this.panelNextPrevButtons.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label labelMarksAttempted;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSubQuestionMarks;
        private System.Windows.Forms.Label labelQuestionMarks;
        private System.Windows.Forms.Panel panelMarks;
        private System.Windows.Forms.Panel panelTreeView;
        private System.Windows.Forms.TreeView treeViewQuestionDisplay;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelQuestionAnswer;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Panel panelNextPrevButtons;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Button buttonPreviousQuestion;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelAnswerLong;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxUnansweredQuestions;
        private System.Windows.Forms.Label labelUnansweredQuestions;
        private System.Windows.Forms.Button buttonSubmitAssessment;
        private System.Windows.Forms.Label labelTimeRemainingTimer;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.ProgressBar progressBarMarksAttempted;
        private System.Windows.Forms.Label labelTimeBegan;
        private System.Windows.Forms.Label labelBeginning;
        private System.Windows.Forms.Button buttonShowQuestionImage;
    }
}