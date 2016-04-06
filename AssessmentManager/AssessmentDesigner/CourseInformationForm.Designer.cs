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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCourseCode = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxCourseCode1 = new System.Windows.Forms.TextBox();
            this.textBoxCourseCode2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(45, 9);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Author:";
            // 
            // labelCourseCode
            // 
            this.labelCourseCode.AutoSize = true;
            this.labelCourseCode.Location = new System.Drawing.Point(12, 42);
            this.labelCourseCode.Name = "labelCourseCode";
            this.labelCourseCode.Size = new System.Drawing.Size(74, 13);
            this.labelCourseCode.TabIndex = 1;
            this.labelCourseCode.Text = "Course Code: ";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(144, 6);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(202, 20);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxCourseCode1
            // 
            this.textBoxCourseCode1.Location = new System.Drawing.Point(144, 39);
            this.textBoxCourseCode1.Name = "textBoxCourseCode1";
            this.textBoxCourseCode1.Size = new System.Drawing.Size(62, 20);
            this.textBoxCourseCode1.TabIndex = 3;
            this.textBoxCourseCode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCourseCode_KeyPress);
            // 
            // textBoxCourseCode2
            // 
            this.textBoxCourseCode2.Location = new System.Drawing.Point(237, 39);
            this.textBoxCourseCode2.Name = "textBoxCourseCode2";
            this.textBoxCourseCode2.Size = new System.Drawing.Size(62, 20);
            this.textBoxCourseCode2.TabIndex = 4;
            this.textBoxCourseCode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCourseCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 91);
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
            this.buttonCancel.Location = new System.Drawing.Point(276, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // CourseInformationForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(363, 126);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCourseCode2);
            this.Controls.Add(this.textBoxCourseCode1);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelCourseCode);
            this.Controls.Add(this.labelAuthor);
            this.Name = "CourseInformationForm";
            this.Text = "CourseInformationForm";
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
    }
}