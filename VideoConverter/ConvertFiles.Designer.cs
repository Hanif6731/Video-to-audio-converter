namespace VideoConverter
{
    partial class ConvertFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertFiles));
            this.listVideo = new System.Windows.Forms.ListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.txtAudio = new System.Windows.Forms.TextBox();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.listAudio = new System.Windows.Forms.ListBox();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbProgress = new MetroFramework.Controls.MetroProgressBar();
            this.pbTotalProgress = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVideo
            // 
            this.listVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVideo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVideo.FormattingEnabled = true;
            this.listVideo.ItemHeight = 19;
            this.listVideo.Location = new System.Drawing.Point(79, 3);
            this.listVideo.Name = "listVideo";
            this.listVideo.Size = new System.Drawing.Size(602, 79);
            this.listVideo.TabIndex = 1;
            this.listVideo.Visible = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(403, 83);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(91, 31);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(403, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 31);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Enabled = false;
            this.btnDestination.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestination.Location = new System.Drawing.Point(403, 43);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(91, 31);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "Save To";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // txtAudio
            // 
            this.txtAudio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAudio.Location = new System.Drawing.Point(3, 43);
            this.txtAudio.Name = "txtAudio";
            this.txtAudio.ReadOnly = true;
            this.txtAudio.Size = new System.Drawing.Size(394, 26);
            this.txtAudio.TabIndex = 1;
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.Location = new System.Drawing.Point(3, 80);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(75, 15);
            this.lblCurrentFile.TabIndex = 6;
            this.lblCurrentFile.Text = "Converting: ";
            this.lblCurrentFile.Visible = false;
            // 
            // listAudio
            // 
            this.listAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAudio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAudio.FormattingEnabled = true;
            this.listAudio.ItemHeight = 19;
            this.listAudio.Location = new System.Drawing.Point(79, 248);
            this.listAudio.Name = "listAudio";
            this.listAudio.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listAudio.Size = new System.Drawing.Size(602, 79);
            this.listAudio.TabIndex = 2;
            this.listAudio.Visible = false;
            // 
            // txtVideo
            // 
            this.txtVideo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVideo.Location = new System.Drawing.Point(3, 3);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.ReadOnly = true;
            this.txtVideo.Size = new System.Drawing.Size(394, 26);
            this.txtVideo.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(760, 370);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listVideo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listAudio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbProgress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbTotalProgress, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnConvert, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDestination, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAudio, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrentFile, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(79, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pbProgress
            // 
            this.pbProgress.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.pbProgress.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.pbProgress.HideProgressText = false;
            this.pbProgress.Location = new System.Drawing.Point(79, 208);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(602, 27);
            this.pbProgress.TabIndex = 7;
            this.pbProgress.Visible = false;
            // 
            // pbTotalProgress
            // 
            this.pbTotalProgress.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.pbTotalProgress.FontWeight = MetroFramework.MetroProgressBarWeight.Regular;
            this.pbTotalProgress.HideProgressText = false;
            this.pbTotalProgress.Location = new System.Drawing.Point(79, 333);
            this.pbTotalProgress.Name = "pbTotalProgress";
            this.pbTotalProgress.Size = new System.Drawing.Size(602, 27);
            this.pbTotalProgress.TabIndex = 8;
            this.pbTotalProgress.Visible = false;
            // 
            // ConvertFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertFiles";
            this.Text = "ConvertSingleFile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConvertSingleFile_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listVideo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TextBox txtAudio;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ListBox listAudio;
        private System.Windows.Forms.TextBox txtVideo;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroProgressBar pbProgress;
        private MetroFramework.Controls.MetroProgressBar pbTotalProgress;
    }
}