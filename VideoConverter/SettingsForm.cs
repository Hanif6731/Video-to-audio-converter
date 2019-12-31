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
    public partial class settingsForm : MainForm
    {
        public settingsForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            back();
        }
        private void back()
        {
            new MainForm().Visible = true;
            this.Dispose();
        }

        private void DarkBtn_Click(object sender, EventArgs e)
        {
            Program.apptheme = MetroThemeStyle.Dark;
            this.Theme = Program.apptheme;
            back();

        }

        private void LightBtn_Click(object sender, EventArgs e)
        {
            Program.apptheme = MetroThemeStyle.Light;
            this.Theme = Program.apptheme;
            back();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Black);
        }

        private void whiteBtn_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.White);
        }

        private void SilverBtn_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Silver);
        }

        private void BlueBtn_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Blue);
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Green);
        }

        private void btnLime_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Lime);
        }

        private void btnTeal_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Teal);
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Orange);
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Brown);
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Pink);
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Magenta);
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Purple);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Red);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            style(MetroColorStyle.Yellow);
        }

        private void style(MetroColorStyle col)
        {
            Program.appStyle = col;
            this.Style = Program.appStyle;
            back();
        }
    }
}
