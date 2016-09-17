using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VControlWClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += new EventHandler(OnProcessExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            VCServer server = new VCServer(4044, form);
            server.startServer();
            Application.Run(form);
        }
        static void OnProcessExit(object sender, EventArgs e)
        {
            MessageBox.Show("stuff");
        }
    }
}
