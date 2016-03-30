namespace ExamManager
{
    partial class questiontemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questiontemp));
            this.panelQuestionNameContainer = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
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
            this.toolStripButtonColour = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddImage = new System.Windows.Forms.ToolStripButton();
            this.panelQuestionNameContainer.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.toolStripQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestionNameContainer
            // 
            this.panelQuestionNameContainer.Controls.Add(this.labelQuestion);
            this.panelQuestionNameContainer.Location = new System.Drawing.Point(38, 59);
            this.panelQuestionNameContainer.Name = "panelQuestionNameContainer";
            this.panelQuestionNameContainer.Size = new System.Drawing.Size(862, 24);
            this.panelQuestionNameContainer.TabIndex = 7;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(0, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(862, 24);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestion.Controls.Add(this.richTextBoxQuestion);
            this.panelQuestion.Controls.Add(this.toolStripQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(80, 149);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.panelQuestion.Size = new System.Drawing.Size(862, 312);
            this.panelQuestion.TabIndex = 8;
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(3, 31);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(856, 278);
            this.richTextBoxQuestion.TabIndex = 1;
            this.richTextBoxQuestion.Text = "";
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
            this.toolStripButtonColour,
            this.toolStripSeparator7,
            this.toolStripButtonAddImage});
            this.toolStripQuestion.Location = new System.Drawing.Point(3, 3);
            this.toolStripQuestion.Name = "toolStripQuestion";
            this.toolStripQuestion.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripQuestion.Size = new System.Drawing.Size(856, 28);
            this.toolStripQuestion.TabIndex = 0;
            this.toolStripQuestion.Text = "toolStrip1";
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(24, 25);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBold.Image = global::ExamManager.Properties.Resources.FormatBold;
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonBold.Text = "Bold";
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonItalic.Image = global::ExamManager.Properties.Resources.FormatItalic;
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonItalic.Text = "Italic";
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUnderline.Image = global::ExamManager.Properties.Resources.FormatUnderline;
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonUnderline.Text = "Underline";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonAlignLeft
            // 
            this.toolStripButtonAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignLeft.Image = global::ExamManager.Properties.Resources.AlignLeft;
            this.toolStripButtonAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignLeft.Name = "toolStripButtonAlignLeft";
            this.toolStripButtonAlignLeft.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonAlignLeft.Text = "Align Left";
            // 
            // toolStripButtonAlignCentre
            // 
            this.toolStripButtonAlignCentre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignCentre.Image = global::ExamManager.Properties.Resources.AlignCentre;
            this.toolStripButtonAlignCentre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignCentre.Name = "toolStripButtonAlignCentre";
            this.toolStripButtonAlignCentre.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonAlignCentre.Text = "Align Right";
            // 
            // toolStripButtonAlignRight
            // 
            this.toolStripButtonAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAlignRight.Image = global::ExamManager.Properties.Resources.AlignRight;
            this.toolStripButtonAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAlignRight.Name = "toolStripButtonAlignRight";
            this.toolStripButtonAlignRight.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonAlignRight.Text = "Align Right";
            // 
            // toolStripButtonBulletList
            // 
            this.toolStripButtonBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBulletList.Image = global::ExamManager.Properties.Resources.List_Bullets;
            this.toolStripButtonBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBulletList.Name = "toolStripButtonBulletList";
            this.toolStripButtonBulletList.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonBulletList.Text = "Bullet List";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripComboBoxSize
            // 
            this.toolStripComboBoxSize.Name = "toolStripComboBoxSize";
            this.toolStripComboBoxSize.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripButtonColour
            // 
            this.toolStripButtonColour.BackColor = System.Drawing.Color.Black;
            this.toolStripButtonColour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButtonColour.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColour.Image")));
            this.toolStripButtonColour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColour.Name = "toolStripButtonColour";
            this.toolStripButtonColour.Size = new System.Drawing.Size(23, 25);
            this.toolStripButtonColour.Text = "Font Colour";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButtonAddImage
            // 
            this.toolStripButtonAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddImage.Image")));
            this.toolStripButtonAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddImage.Name = "toolStripButtonAddImage";
            this.toolStripButtonAddImage.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonAddImage.Text = "Add Image";
            // 
            // questiontemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 711);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelQuestionNameContainer);
            this.Name = "questiontemp";
            this.Text = "questiontemp";
            this.panelQuestionNameContainer.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.toolStripQuestion.ResumeLayout(false);
            this.toolStripQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}