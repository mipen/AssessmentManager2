using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManager
{
    public partial class MainForm : Form
    {

        private ColorDialog colorDialog = new ColorDialog();

        public MainForm()
        {
            InitializeComponent();

            comboBoxAnswerType.SelectedIndex = 3;
        }

        #region Toolstrip buttons
        private void toolStripButtonColour_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void comboBoxAnswerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO:: Asign answer type to question.
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
    }
}
