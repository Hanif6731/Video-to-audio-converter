using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace VideoConverter
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void FromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CFF = new ConvertFromFolder();
            CFF.Visible = true;
            this.Visible = false;
        }

        private void SingleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CF = new ConvertFiles();
            CF.Visible = true;
            this.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenFilesFromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
