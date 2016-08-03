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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroductionForm));
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.lblWeighting = new System.Windows.Forms.Label();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlUserInteract = new System.Windows.Forms.Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.pnlPractise = new System.Windows.Forms.Panel();
            this.btnNoPractice = new System.Windows.Forms.Button();
            this.btnYesPractice = new System.Windows.Forms.Button();
            this.lblPractice = new System.Windows.Forms.Label();
            this.pnlOpenAssessment = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblOpenAssessment = new System.Windows.Forms.Label();
            this.lblDateTimeDisp = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlContinueAssessment = new System.Windows.Forms.Panel();
            this.lblContinueAssessment = new System.Windows.Forms.Label();
            this.lblTimeStarted = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.lblFinishingTime = new System.Windows.Forms.Label();
            this.lblContinueDescription = new System.Windows.Forms.Label();
            this.btnContinueYes = new System.Windows.Forms.Button();
            this.btnContinueNo = new System.Windows.Forms.Button();
            this.pnlAssessmentFinished = new System.Windows.Forms.Panel();
            this.lblAssessmentFinished = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFinishedTimeStarted = new System.Windows.Forms.Label();
            this.lblFinishedTimeFinished = new System.Windows.Forms.Label();
            this.pnlInformation.SuspendLayout();
            this.pnlUserInteract.SuspendLayout();
            this.pnlPractise.SuspendLayout();
            this.pnlOpenAssessment.SuspendLayout();
            this.pnlContinueAssessment.SuspendLayout();
            this.pnlAssessmentFinished.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(4, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(84, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author: Unkown";
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(3, 3);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(155, 23);
            this.lblCourseCode.TabIndex = 2;
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCourseName
            // 
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(164, 3);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(502, 47);
            this.lblCourseName.TabIndex = 3;
            this.lblCourseName.Text = "Unkown Course";
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessmentName.Location = new System.Drawing.Point(3, 50);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(663, 29);
            this.lblAssessmentName.TabIndex = 4;
            this.lblAssessmentName.Text = "Assessment";
            this.lblAssessmentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeighting
            // 
            this.lblWeighting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighting.Location = new System.Drawing.Point(284, 79);
            this.lblWeighting.Name = "lblWeighting";
            this.lblWeighting.Size = new System.Drawing.Size(100, 23);
            this.lblWeighting.TabIndex = 5;
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
            this.pnlUserInteract.Controls.Add(this.pnlAssessmentFinished);
            this.pnlUserInteract.Controls.Add(this.pnlContinueAssessment);
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
            this.pnlLine.Location = new System.Drawing.Point(15, 20);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(641, 1);
            this.pnlLine.TabIndex = 3;
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
            // pnlContinueAssessment
            // 
            this.pnlContinueAssessment.Controls.Add(this.btnContinueNo);
            this.pnlContinueAssessment.Controls.Add(this.btnContinueYes);
            this.pnlContinueAssessment.Controls.Add(this.lblContinueDescription);
            this.pnlContinueAssessment.Controls.Add(this.lblFinishingTime);
            this.pnlContinueAssessment.Controls.Add(this.pnlLine2);
            this.pnlContinueAssessment.Controls.Add(this.lblTimeStarted);
            this.pnlContinueAssessment.Controls.Add(this.lblContinueAssessment);
            this.pnlContinueAssessment.Location = new System.Drawing.Point(0, 21);
            this.pnlContinueAssessment.Name = "pnlContinueAssessment";
            this.pnlContinueAssessment.Size = new System.Drawing.Size(669, 108);
            this.pnlContinueAssessment.TabIndex = 3;
            // 
            // lblContinueAssessment
            // 
            this.lblContinueAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinueAssessment.Location = new System.Drawing.Point(0, 0);
            this.lblContinueAssessment.Name = "lblContinueAssessment";
            this.lblContinueAssessment.Size = new System.Drawing.Size(669, 23);
            this.lblContinueAssessment.TabIndex = 0;
            this.lblContinueAssessment.Text = "Assessment still available. Would you like to continue?";
            this.lblContinueAssessment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeStarted
            // 
            this.lblTimeStarted.AutoSize = true;
            this.lblTimeStarted.Location = new System.Drawing.Point(15, 37);
            this.lblTimeStarted.Name = "lblTimeStarted";
            this.lblTimeStarted.Size = new System.Drawing.Size(61, 13);
            this.lblTimeStarted.TabIndex = 1;
            this.lblTimeStarted.Text = "time started";
            // 
            // pnlLine2
            // 
            this.pnlLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLine2.Location = new System.Drawing.Point(114, 22);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(441, 1);
            this.pnlLine2.TabIndex = 4;
            // 
            // lblFinishingTime
            // 
            this.lblFinishingTime.AutoSize = true;
            this.lblFinishingTime.Location = new System.Drawing.Point(15, 66);
            this.lblFinishingTime.Name = "lblFinishingTime";
            this.lblFinishingTime.Size = new System.Drawing.Size(67, 13);
            this.lblFinishingTime.TabIndex = 5;
            this.lblFinishingTime.Text = "finishing time";
            // 
            // lblContinueDescription
            // 
            this.lblContinueDescription.Location = new System.Drawing.Point(276, 32);
            this.lblContinueDescription.Name = "lblContinueDescription";
            this.lblContinueDescription.Size = new System.Drawing.Size(203, 73);
            this.lblContinueDescription.TabIndex = 6;
            this.lblContinueDescription.Text = "This assessment has already been started, but there is still time remaining to co" +
    "ntinue with it. Press the \'Yes\' button to continue taking this assessment.";
            // 
            // btnContinueYes
            // 
            this.btnContinueYes.Location = new System.Drawing.Point(480, 72);
            this.btnContinueYes.Name = "btnContinueYes";
            this.btnContinueYes.Size = new System.Drawing.Size(75, 23);
            this.btnContinueYes.TabIndex = 7;
            this.btnContinueYes.Text = "&Yes";
            this.btnContinueYes.UseVisualStyleBackColor = true;
            this.btnContinueYes.Click += new System.EventHandler(this.btnContinueYes_Click);
            // 
            // btnContinueNo
            // 
            this.btnContinueNo.Location = new System.Drawing.Point(581, 72);
            this.btnContinueNo.Name = "btnContinueNo";
            this.btnContinueNo.Size = new System.Drawing.Size(75, 23);
            this.btnContinueNo.TabIndex = 8;
            this.btnContinueNo.Text = "&No";
            this.btnContinueNo.UseVisualStyleBackColor = true;
            this.btnContinueNo.Click += new System.EventHandler(this.btnContinueNo_Click);
            // 
            // pnlAssessmentFinished
            // 
            this.pnlAssessmentFinished.Controls.Add(this.lblFinishedTimeFinished);
            this.pnlAssessmentFinished.Controls.Add(this.lblFinishedTimeStarted);
            this.pnlAssessmentFinished.Controls.Add(this.btnClose);
            this.pnlAssessmentFinished.Controls.Add(this.lblAssessmentFinished);
            this.pnlAssessmentFinished.Location = new System.Drawing.Point(0, 21);
            this.pnlAssessmentFinished.Name = "pnlAssessmentFinished";
            this.pnlAssessmentFinished.Size = new System.Drawing.Size(669, 108);
            this.pnlAssessmentFinished.TabIndex = 9;
            // 
            // lblAssessmentFinished
            // 
            this.lblAssessmentFinished.AutoSize = true;
            this.lblAssessmentFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssessmentFinished.Location = new System.Drawing.Point(16, 18);
            this.lblAssessmentFinished.Name = "lblAssessmentFinished";
            this.lblAssessmentFinished.Size = new System.Drawing.Size(509, 18);
            this.lblAssessmentFinished.TabIndex = 0;
            this.lblAssessmentFinished.Text = "This assessment has now finished. Thank you for using Examinee.";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFinishedTimeStarted
            // 
            this.lblFinishedTimeStarted.AutoSize = true;
            this.lblFinishedTimeStarted.Location = new System.Drawing.Point(37, 50);
            this.lblFinishedTimeStarted.Name = "lblFinishedTimeStarted";
            this.lblFinishedTimeStarted.Size = new System.Drawing.Size(61, 13);
            this.lblFinishedTimeStarted.TabIndex = 2;
            this.lblFinishedTimeStarted.Text = "started time";
            // 
            // lblFinishedTimeFinished
            // 
            this.lblFinishedTimeFinished.AutoSize = true;
            this.lblFinishedTimeFinished.Location = new System.Drawing.Point(37, 77);
            this.lblFinishedTimeFinished.Name = "lblFinishedTimeFinished";
            this.lblFinishedTimeFinished.Size = new System.Drawing.Size(65, 13);
            this.lblFinishedTimeFinished.TabIndex = 3;
            this.lblFinishedTimeFinished.Text = "finished time";
            // 
            // IntroductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 269);
            this.Controls.Add(this.pnlUserInteract);
            this.Controls.Add(this.pnlInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IntroductionForm";
            this.Text = "Examinee";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlUserInteract.ResumeLayout(false);
            this.pnlUserInteract.PerformLayout();
            this.pnlPractise.ResumeLayout(false);
            this.pnlOpenAssessment.ResumeLayout(false);
            this.pnlOpenAssessment.PerformLayout();
            this.pnlContinueAssessment.ResumeLayout(false);
            this.pnlContinueAssessment.PerformLayout();
            this.pnlAssessmentFinished.ResumeLayout(false);
            this.pnlAssessmentFinished.PerformLayout();
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
        private System.Windows.Forms.Panel pnlContinueAssessment;
        private System.Windows.Forms.Button btnContinueNo;
        private System.Windows.Forms.Button btnContinueYes;
        private System.Windows.Forms.Label lblContinueDescription;
        private System.Windows.Forms.Label lblFinishingTime;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Label lblTimeStarted;
        private System.Windows.Forms.Label lblContinueAssessment;
        private System.Windows.Forms.Panel pnlAssessmentFinished;
        private System.Windows.Forms.Label lblAssessmentFinished;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFinishedTimeFinished;
        private System.Windows.Forms.Label lblFinishedTimeStarted;
    }
}