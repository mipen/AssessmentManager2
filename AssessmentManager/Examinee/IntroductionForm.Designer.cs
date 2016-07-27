namespace AssessmentManager
{
    partial class IntroductionForm
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
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.lblWeighting = new System.Windows.Forms.Label();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlUserInteract = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlOpenAssessment = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblOpenAssessment = new System.Windows.Forms.Label();
            this.pnlPractise = new System.Windows.Forms.Panel();
            this.btnNoPractice = new System.Windows.Forms.Button();
            this.btnYesPractice = new System.Windows.Forms.Button();
            this.lblPractice = new System.Windows.Forms.Label();
            this.lblDateTimeDisp = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlInformation.SuspendLayout();
            this.pnlUserInteract.SuspendLayout();
            this.pnlOpenAssessment.SuspendLayout();
            this.pnlPractise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(4, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(3, 3);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(155, 23);
            this.lblCourseCode.TabIndex = 2;
            this.lblCourseCode.Text = "xxx.xxx";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(164, 3);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(502, 47);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "professional user interface design";
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessmentName.Location = new System.Drawing.Point(3, 50);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(663, 29);
            this.lblAssessmentName.TabIndex = 4;
            this.lblAssessmentName.Text = "a super long title";
            this.lblAssessmentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeighting
            // 
            this.lblWeighting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighting.Location = new System.Drawing.Point(284, 79);
            this.lblWeighting.Name = "lblWeighting";
            this.lblWeighting.Size = new System.Drawing.Size(100, 23);
            this.lblWeighting.TabIndex = 5;
            this.lblWeighting.Text = "50%";
            this.lblWeighting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlInformation
            // 
            this.pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformation.Controls.Add(this.lblCourseName);
            this.pnlInformation.Controls.Add(this.lblAuthor);
            this.pnlInformation.Controls.Add(this.lblWeighting);
            this.pnlInformation.Controls.Add(this.lblCourseCode);
            this.pnlInformation.Controls.Add(this.lblAssessmentName);
            this.pnlInformation.Location = new System.Drawing.Point(12, 12);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(671, 110);
            this.pnlInformation.TabIndex = 6;
            // 
            // pnlUserInteract
            // 
            this.pnlUserInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInteract.Controls.Add(this.pnlLine);
            this.pnlUserInteract.Controls.Add(this.pnlPractise);
            this.pnlUserInteract.Controls.Add(this.pnlOpenAssessment);
            this.pnlUserInteract.Controls.Add(this.lblDateTimeDisp);
            this.pnlUserInteract.Controls.Add(this.lblDateTime);
            this.pnlUserInteract.Location = new System.Drawing.Point(12, 128);
            this.pnlUserInteract.Name = "pnlUserInteract";
            this.pnlUserInteract.Size = new System.Drawing.Size(671, 131);
            this.pnlUserInteract.TabIndex = 7;
            // 
            // pnlLine
            // 
            this.pnlLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLine.Location = new System.Drawing.Point(0, 20);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(641, 1);
            this.pnlLine.TabIndex = 3;
            // 
            // pnlOpenAssessment
            // 
            this.pnlOpenAssessment.Controls.Add(this.btnOpen);
            this.pnlOpenAssessment.Controls.Add(this.lblOpenAssessment);
            this.pnlOpenAssessment.Location = new System.Drawing.Point(0, 21);
            this.pnlOpenAssessment.Name = "pnlOpenAssessment";
            this.pnlOpenAssessment.Size = new System.Drawing.Size(669, 108);
            this.pnlOpenAssessment.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(581, 72);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblOpenAssessment
            // 
            this.lblOpenAssessment.AutoSize = true;
            this.lblOpenAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenAssessment.ForeColor = System.Drawing.Color.Blue;
            this.lblOpenAssessment.Location = new System.Drawing.Point(283, 72);
            this.lblOpenAssessment.Name = "lblOpenAssessment";
            this.lblOpenAssessment.Size = new System.Drawing.Size(234, 20);
            this.lblOpenAssessment.TabIndex = 0;
            this.lblOpenAssessment.Text = "Please open an assessment";
            // 
            // pnlPractise
            // 
            this.pnlPractise.Controls.Add(this.btnNoPractice);
            this.pnlPractise.Controls.Add(this.btnYesPractice);
            this.pnlPractise.Controls.Add(this.lblPractice);
            this.pnlPractise.Location = new System.Drawing.Point(0, 21);
            this.pnlPractise.Name = "pnlPractise";
            this.pnlPractise.Size = new System.Drawing.Size(669, 108);
            this.pnlPractise.TabIndex = 2;
            // 
            // btnNoPractice
            // 
            this.btnNoPractice.Location = new System.Drawing.Point(581, 82);
            this.btnNoPractice.Name = "btnNoPractice";
            this.btnNoPractice.Size = new System.Drawing.Size(75, 23);
            this.btnNoPractice.TabIndex = 2;
            this.btnNoPractice.Text = "&No";
            this.btnNoPractice.UseVisualStyleBackColor = true;
            this.btnNoPractice.Click += new System.EventHandler(this.btnNoPractice_Click);
            // 
            // btnYesPractice
            // 
            this.btnYesPractice.Location = new System.Drawing.Point(463, 82);
            this.btnYesPractice.Name = "btnYesPractice";
            this.btnYesPractice.Size = new System.Drawing.Size(75, 23);
            this.btnYesPractice.TabIndex = 1;
            this.btnYesPractice.Text = "&Yes";
            this.btnYesPractice.UseVisualStyleBackColor = true;
            this.btnYesPractice.Click += new System.EventHandler(this.btnYesPractice_Click);
            // 
            // lblPractice
            // 
            this.lblPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPractice.ForeColor = System.Drawing.Color.Blue;
            this.lblPractice.Location = new System.Drawing.Point(15, 14);
            this.lblPractice.Name = "lblPractice";
            this.lblPractice.Size = new System.Drawing.Size(641, 52);
            this.lblPractice.TabIndex = 0;
            this.lblPractice.Text = "This assessment is available for use as practice. Would you like to continue?";
            // 
            // lblDateTimeDisp
            // 
            this.lblDateTimeDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeDisp.Location = new System.Drawing.Point(121, 2);
            this.lblDateTimeDisp.Name = "lblDateTimeDisp";
            this.lblDateTimeDisp.Size = new System.Drawing.Size(545, 16);
            this.lblDateTimeDisp.TabIndex = 1;
            this.lblDateTimeDisp.Text = "current date and time";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(4, 4);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(111, 13);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Current date and time:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 269);
            this.Controls.Add(this.pnlUserInteract);
            this.Controls.Add(this.pnlInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IntroductionForm";
            this.Text = "Introduction";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlUserInteract.ResumeLayout(false);
            this.pnlUserInteract.PerformLayout();
            this.pnlOpenAssessment.ResumeLayout(false);
            this.pnlOpenAssessment.PerformLayout();
            this.pnlPractise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Label lblWeighting;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlUserInteract;
        private System.Windows.Forms.Label lblDateTimeDisp;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlLine;
        private System.Windows.Forms.Panel pnlPractise;
        private System.Windows.Forms.Button btnNoPractice;
        private System.Windows.Forms.Button btnYesPractice;
        private System.Windows.Forms.Label lblPractice;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlOpenAssessment;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblOpenAssessment;
    }
}