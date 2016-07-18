using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Count() > 0)
            {
                //TODO:: Implement splash screen
                //Application.Run(new EntryForm(args[0]));

                //Test
                Application.Run(new Examinee(args[0]));
            }
            else
            {
                Application.Run(new Examinee());
            }
        }
    }
}
