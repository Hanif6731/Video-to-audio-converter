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
using NReco;
using NReco.VideoInfo;
using NReco.VideoConverter;

namespace VideoConverter
{
    public partial class ConvertFiles : MetroForm
    {
        string[] videoFormats = { "mp4", "3gp", "wmv", "mkv", "avi", "flv", "webm" };
        List<string> VideoFormat = new List<string>();
        List<string> input = new List<string>();
        int totalSeconds = 0;
        int totalItem = 0;
        int processedItem = 0;
        public ConvertFiles()
        {
            InitializeComponent();
            this.VideoFormat.AddRange(videoFormats);
        }

        private void ConvertSingleFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            listVideo.Items.Clear();
            this.input.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(ofd.FileName) == false)
            {
                
                string[] files = ofd.FileNames;
                foreach (string file in files)
                {
                    string[] fileformat = file.Split('.');
                    if (VideoFormat.Contains(fileformat[fileformat.Length - 1].ToLower()))
                    {
                        string[] absFile = file.Split('\\');
                        listVideo.Items.Add(absFile[absFile.Length - 1]);
                        this.input.Add(file);
                    }
                }
                this.txtVideo.Text = files[0].Substring(0,files[0].LastIndexOf('\\')+1);
                this.listVideo.Visible = true;
                this.btnDestination.Enabled = true;
            }
        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK && string.IsNullOrEmpty(fbd.SelectedPath) == false)
            {
                this.txtAudio.Text = fbd.SelectedPath;
                this.btnConvert.Enabled = true;

            }
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            this.btnBrowse.Enabled = false;
            this.btnConvert.Enabled = false;
            this.btnDestination.Enabled = false;
            this.listAudio.Items.Clear();
            int i = 0;
            this.lblCurrentFile.Visible = true;
            this.pbProgress.Visible = true;
            this.listAudio.Visible = true;
            this.pbTotalProgress.Visible = true;
            this.pbProgress.Maximum = 100;
            this.pbTotalProgress.Maximum = 100;
            this.totalItem = this.listVideo.Items.Count;
            this.pbTotalProgress.Value = 0;
            this.processedItem = 0;
            foreach (string file in this.input)
            {
                try
                {
                    this.pbProgress.Value = 0;
                    this.processedItem = i + 1;
                    this.listVideo.SetSelected(i, true);
                    string outputFile = this.listVideo.SelectedItem.ToString();
                    outputFile = outputFile.Substring(0, outputFile.LastIndexOf('.'));
                    this.lblCurrentFile.Text = "Converting: " + file;
                    var ConvertToAudio = new NReco.VideoConverter.FFMpegConverter();
                    var ffprobe = new NReco.VideoInfo.FFProbe();
                    MediaInfo videoInfo = ffprobe.GetMediaInfo(file);
                    this.totalSeconds = videoInfo.Duration.Milliseconds;
                    ConvertToAudio.ConvertProgress += new EventHandler<ConvertProgressEventArgs>(this.UpdateProgress);
                    ConvertToAudio.ConvertMedia(file, this.txtAudio.Text + "\\" + outputFile + ".mp3", "mp3");
                    this.listAudio.Items.Add(this.txtAudio.Text + "\\" + outputFile + ".mp3");
                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i++;
                }


            }
            this.lblCurrentFile.Text = "Completed";
            this.btnBrowse.Enabled = true;
            this.btnConvert.Enabled = true;
            this.btnDestination.Enabled = true;
        }

        private void UpdateProgress(object sender, ConvertProgressEventArgs e)
        {

            this.pbProgress.Value = (int)Math.Ceiling((e.Processed.Milliseconds / (double)this.totalSeconds) * 100); //Or whatever calculation you want
            this.pbTotalProgress.Value = (int)Math.Ceiling((this.processedItem / (double)totalItem) * 100);
        }
    }
}
