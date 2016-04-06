using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentManager
{
    public partial class CourseInformationForm : Form
    {
        public CourseInformationForm()
        {
            InitializeComponent();
        }

        private void textBoxCourseCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            //Stop more than three characters being entered
            if (tbox.Text.Length >= 3)
                e.Handled = true;

            //Only allow numbers to be entered
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public string Author
        {
            get
            {
                return textBoxAuthor.Text;
            }
            set
            {
                textBoxAuthor.Text = value;
            }
        }

        public string CourseCode
        {
            get
            {
                return textBoxCourseCode1.Text + "." + textBoxCourseCode2.Text;
            }
            set
            {
                string str = value;
                int index = str.IndexOf(".");
                textBoxCourseCode1.Text = value.Substring(0, index);
                textBoxCourseCode2.Text = value.Substring(index+1);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
