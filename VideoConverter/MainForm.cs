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
        //private static MainForm mf;
        private settingsForm sf;
        private bool sfInitialized = false;
        public MainForm Mf
        {
            get { return this; }
        }

        public MainForm()
        {
            InitializeComponent();
             //sf= new settingsForm();
            //this.Visible = true;
            this.Theme = Program.apptheme;
            this.Style = Program.appStyle;

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

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!sfInitialized)
            sf = new settingsForm();
            sf.Visible = true;
            this.Visible = false;
            //this.st
        }
    }
}
