
namespace NewClocky
{
    partial class frmClock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rbLong = new System.Windows.Forms.RadioButton();
            this.rbShort = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTime.Name = "lblTime";
            this.lblTime.DoubleClick += new System.EventHandler(this.lblTime_DoubleClick);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rbLong);
            this.grpBox.Controls.Add(this.rbShort);
            resources.ApplyResources(this.grpBox, "grpBox");
            this.grpBox.Name = "grpBox";
            this.grpBox.TabStop = false;
            // 
            // rbLong
            // 
            resources.ApplyResources(this.rbLong, "rbLong");
            this.rbLong.Name = "rbLong";
            this.rbLong.TabStop = true;
            this.rbLong.UseVisualStyleBackColor = true;
            // 
            // rbShort
            // 
            resources.ApplyResources(this.rbShort, "rbShort");
            this.rbShort.Name = "rbShort";
            this.rbShort.TabStop = true;
            this.rbShort.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHide
            // 
            resources.ApplyResources(this.btnHide, "btnHide");
            this.btnHide.Name = "btnHide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            resources.ApplyResources(this.cbPosition, "cbPosition");
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmClock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmClock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClock_FormClosed);
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rbLong;
        private System.Windows.Forms.RadioButton rbShort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}

