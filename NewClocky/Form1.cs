using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClocky
{
    public partial class frmClock : Form
    {
        private enum SetMode
        {
            Save, Load
        }
        public frmClock()
        {
            InitializeComponent();
        }
        private void frmClock_Load(object sender, EventArgs e)
        {
            //rbLong.Checked = true;
            Settings(SetMode.Load);
            cbPosition.Items.Add("Center Screen");
            cbPosition.Items.Add("Top Right");
            cbPosition.Items.Add("Bottom Right");
        }
        #region Interface
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHide_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("En de fold button werkt ook.... nu de rest nog");
            this.Height = 110;
            this.Width = 210;
        }
        private void lblTime_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Dubbelclick werkt iig");
            this.Height = 200;
            this.Width = 440;
        }
        #endregion
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            ShowTime();
            //lblTime.Text = DateTime.Now.ToLongTimeString();
        }
        private void ShowTime()
        {
            if (rbLong.Checked)
            {
                lblTime.Text = DateTime.Now.ToLongTimeString() + "/n" + DateTime.Now.ToLongDateString();
            }
            else
            {
                lblTime.Text = DateTime.Now.ToShortTimeString();
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Text = lblTime.Text;
            }
            else
            {
                this.Text = Application.ProductName;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPosition.SelectedIndex)
            {
                case 0:
                    this.CenterToScreen();
                    this.Focus();
                    break;
                case 1:
                    this.Top = 0;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                    this.Focus();
                    break;
                case 2:
                    this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                    this.Focus();
                    break;
            }
        }
        private void Settings(SetMode mode)
        {
            switch (mode)
            {
                case SetMode.Save:
                    Properties.Settings.Default.xPos = this.Left;
                    Properties.Settings.Default.yPos = this.Top;
                    Properties.Settings.Default.tFormat = this.rbLong.Checked;
                    Properties.Settings.Default.hHeight = this.Height;
                    Properties.Settings.Default.wWidth = this.Width;
                    Properties.Settings.Default.Save();
                    break;
                case SetMode.Load:
                    this.Left = Properties.Settings.Default.xPos;
                    this.Top = Properties.Settings.Default.yPos;
                    this.Width = Properties.Settings.Default.wWidth;
                    this.Height = Properties.Settings.Default.hHeight;
                    this.rbLong.Checked = Properties.Settings.Default.tFormat;
                    break;
            }

        }
        private void frmClock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings(SetMode.Save);
        }
    }
}
