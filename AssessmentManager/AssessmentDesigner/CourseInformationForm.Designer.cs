namespace AssessmentManager
{
    partial class CourseInformationForm
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCourseCode = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxCourseCode1 = new System.Windows.Forms.TextBox();
            this.textBoxCourseCode2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.tbAssessmentName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblAssessmentWeighting = new System.Windows.Forms.Label();
            this.nudAssessmentWeighting = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAssessmentWeighting)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(82, 99);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Author:";
            this.toolTip1.SetToolTip(this.labelAuthor, "The name of the author");
            // 
            // labelCourseCode
            // 
            this.labelCourseCode.AutoSize = true;
            this.labelCourseCode.Location = new System.Drawing.Point(49, 41);
            this.labelCourseCode.Name = "labelCourseCode";
            this.labelCourseCode.Size = new System.Drawing.Size(74, 13);
            this.labelCourseCode.TabIndex = 1;
            this.labelCourseCode.Text = "Course Code: ";
            this.toolTip1.SetToolTip(this.labelCourseCode, "The course code that this assessment is for");
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(133, 96);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(218, 20);
            this.textBoxAuthor.TabIndex = 5;
            // 
            // textBoxCourseCode1
            // 
            this.textBoxCourseCode1.Location = new System.Drawing.Point(133, 38);
            this.textBoxCourseCode1.Name = "textBoxCourseCode1";
            this.textBoxCourseCode1.Size = new System.Drawing.Size(62, 20);
            this.textBoxCourseCode1.TabIndex = 2;
            this.textBoxCourseCode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCourseCode_KeyPress);
            // 
            // textBoxCourseCode2
            // 
            this.textBoxCourseCode2.Location = new System.Drawing.Point(227, 38);
            this.textBoxCourseCode2.Name = "textBoxCourseCode2";
            this.textBoxCourseCode2.Size = new System.Drawing.Size(62, 20);
            this.textBoxCourseCode2.TabIndex = 3;
            this.textBoxCourseCode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCourseCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 158);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(276, 158);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(49, 12);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(74, 13);
            this.lblCourseName.TabIndex = 8;
            this.lblCourseName.Text = "Course Name:";
            this.toolTip1.SetToolTip(this.lblCourseName, "The name of the course that this assessment is for");
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(26, 70);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(97, 13);
            this.lblAssessmentName.TabIndex = 9;
            this.lblAssessmentName.Text = "Assessment Name:";
            this.toolTip1.SetToolTip(this.lblAssessmentName, "The name of the assessment. \\nIe: Test 1");
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(133, 9);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(218, 20);
            this.tbCourseName.TabIndex = 1;
            // 
            // tbAssessmentName
            // 
            this.tbAssessmentName.Location = new System.Drawing.Point(133, 67);
            this.tbAssessmentName.Name = "tbAssessmentName";
            this.tbAssessmentName.Size = new System.Drawing.Size(218, 20);
            this.tbAssessmentName.TabIndex = 4;
            // 
            // lblAssessmentWeighting
            // 
            this.lblAssessmentWeighting.AutoSize = true;
            this.lblAssessmentWeighting.Location = new System.Drawing.Point(6, 128);
            this.lblAssessmentWeighting.Name = "lblAssessmentWeighting";
            this.lblAssessmentWeighting.Size = new System.Drawing.Size(117, 13);
            this.lblAssessmentWeighting.TabIndex = 10;
            this.lblAssessmentWeighting.Text = "Assessment Weighting:";
            this.toolTip1.SetToolTip(this.lblAssessmentWeighting, "The weighting for the assessment (in %)");
            // 
            // nudAssessmentWeighting
            // 
            this.nudAssessmentWeighting.Location = new System.Drawing.Point(133, 126);
            this.nudAssessmentWeighting.Name = "nudAssessmentWeighting";
            this.nudAssessmentWeighting.Size = new System.Drawing.Size(48, 20);
            this.nudAssessmentWeighting.TabIndex = 11;
            // 
            // CourseInformationForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(363, 195);
            this.Controls.Add(this.nudAssessmentWeighting);
            this.Controls.Add(this.lblAssessmentWeighting);
            this.Controls.Add(this.tbAssessmentName);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCourseCode2);
            this.Controls.Add(this.textBoxCourseCode1);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelCourseCode);
            this.Controls.Add(this.labelAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CourseInformationForm";
            this.Text = "Course Information";
            ((System.ComponentModel.ISupportInitialize)(this.nudAssessmentWeighting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCourseCode;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxCourseCode1;
        private System.Windows.Forms.TextBox textBoxCourseCode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.TextBox tbAssessmentName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblAssessmentWeighting;
        private System.Windows.Forms.NumericUpDown nudAssessmentWeighting;
    }
}