namespace PM4P
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Runbtn = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnWindowWithOnePassLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnWindowWithTwoPassLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setcolorofbackground = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorDataWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColoTextRunButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundRunButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorNameOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersOneLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBackgroundTwoLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorNameTwoLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setColorCharactersTwoLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twolimitsbox = new System.Windows.Forms.TextBox();
            this.onelimitbox = new System.Windows.Forms.TextBox();
            this.onelimitLbl = new System.Windows.Forms.Label();
            this.twolimitsLbl = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Runbtn
            // 
            this.Runbtn.Location = new System.Drawing.Point(678, 31);
            this.Runbtn.Name = "Runbtn";
            this.Runbtn.Size = new System.Drawing.Size(92, 39);
            this.Runbtn.TabIndex = 0;
            this.Runbtn.Text = "Run";
            this.Runbtn.UseVisualStyleBackColor = true;
            this.Runbtn.Click += new System.EventHandler(this.Runbtn_Click);
            // 
            // dane
            // 
            this.dane.Location = new System.Drawing.Point(12, 76);
            this.dane.Multiline = true;
            this.dane.Name = "dane";
            this.dane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dane.Size = new System.Drawing.Size(758, 467);
            this.dane.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnWindowWithOnePassLimitToolStripMenuItem,
            this.turnWindowWithTwoPassLimitsToolStripMenuItem,
            this.runToolStripMenuItem,
            this.setColorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // turnWindowWithOnePassLimitToolStripMenuItem
            // 
            this.turnWindowWithOnePassLimitToolStripMenuItem.Name = "turnWindowWithOnePassLimitToolStripMenuItem";
            this.turnWindowWithOnePassLimitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.turnWindowWithOnePassLimitToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.turnWindowWithOnePassLimitToolStripMenuItem.Text = "Turn on Window with one pass limit";
            this.turnWindowWithOnePassLimitToolStripMenuItem.Click += new System.EventHandler(this.turnWindowWithOnePassLimitToolStripMenuItem_Click);
            // 
            // turnWindowWithTwoPassLimitsToolStripMenuItem
            // 
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Name = "turnWindowWithTwoPassLimitsToolStripMenuItem";
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Text = "Turn on Window with two pass limits";
            this.turnWindowWithTwoPassLimitsToolStripMenuItem.Click += new System.EventHandler(this.turnWindowWithTwoPassLimitsToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.runToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setcolorofbackground,
            this.setColorDataWindowToolStripMenuItem,
            this.setColorCharactersToolStripMenuItem,
            this.setColoTextRunButtonToolStripMenuItem,
            this.setBackgroundRunButtonToolStripMenuItem,
            this.setBackgroundOneLimitToolStripMenuItem,
            this.setColorNameOneLimitToolStripMenuItem,
            this.setColorCharactersOneLimitToolStripMenuItem,
            this.setBackgroundTwoLimitsToolStripMenuItem,
            this.setColorNameTwoLimitToolStripMenuItem,
            this.setColorCharactersTwoLimitsToolStripMenuItem});
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(416, 26);
            this.setColorToolStripMenuItem.Text = "Set Color";
            // 
            // setcolorofbackground
            // 
            this.setcolorofbackground.Name = "setcolorofbackground";
            this.setcolorofbackground.Size = new System.Drawing.Size(305, 26);
            this.setcolorofbackground.Text = "Set Color Background";
            this.setcolorofbackground.Click += new System.EventHandler(this.setcolorofbackground_Click);
            // 
            // setColorDataWindowToolStripMenuItem
            // 
            this.setColorDataWindowToolStripMenuItem.Name = "setColorDataWindowToolStripMenuItem";
            this.setColorDataWindowToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorDataWindowToolStripMenuItem.Text = "Set Color Data Window";
            this.setColorDataWindowToolStripMenuItem.Click += new System.EventHandler(this.setColorDataWindowToolStripMenuItem_Click);
            // 
            // setColorCharactersToolStripMenuItem
            // 
            this.setColorCharactersToolStripMenuItem.Name = "setColorCharactersToolStripMenuItem";
            this.setColorCharactersToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersToolStripMenuItem.Text = "Set Color Characters";
            this.setColorCharactersToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersToolStripMenuItem_Click);
            // 
            // setColoTextRunButtonToolStripMenuItem
            // 
            this.setColoTextRunButtonToolStripMenuItem.Name = "setColoTextRunButtonToolStripMenuItem";
            this.setColoTextRunButtonToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColoTextRunButtonToolStripMenuItem.Text = "Set Color Text \"Run\" Button";
            this.setColoTextRunButtonToolStripMenuItem.Click += new System.EventHandler(this.setColoTextRunButtonToolStripMenuItem_Click);
            // 
            // setBackgroundRunButtonToolStripMenuItem
            // 
            this.setBackgroundRunButtonToolStripMenuItem.Name = "setBackgroundRunButtonToolStripMenuItem";
            this.setBackgroundRunButtonToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundRunButtonToolStripMenuItem.Text = "Set Background \"Run\" Button";
            this.setBackgroundRunButtonToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundRunButtonToolStripMenuItem_Click);
            // 
            // setBackgroundOneLimitToolStripMenuItem
            // 
            this.setBackgroundOneLimitToolStripMenuItem.Name = "setBackgroundOneLimitToolStripMenuItem";
            this.setBackgroundOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundOneLimitToolStripMenuItem.Text = "Set Background One Limit";
            this.setBackgroundOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundOneLimitToolStripMenuItem_Click);
            // 
            // setColorNameOneLimitToolStripMenuItem
            // 
            this.setColorNameOneLimitToolStripMenuItem.Name = "setColorNameOneLimitToolStripMenuItem";
            this.setColorNameOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorNameOneLimitToolStripMenuItem.Text = "Set Color Name One Limit";
            this.setColorNameOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorNameOneLimitToolStripMenuItem_Click);
            // 
            // setColorCharactersOneLimitToolStripMenuItem
            // 
            this.setColorCharactersOneLimitToolStripMenuItem.Name = "setColorCharactersOneLimitToolStripMenuItem";
            this.setColorCharactersOneLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersOneLimitToolStripMenuItem.Text = "Set Color Characters \"One Limit\"";
            this.setColorCharactersOneLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersOneLimitToolStripMenuItem_Click);
            // 
            // setBackgroundTwoLimitsToolStripMenuItem
            // 
            this.setBackgroundTwoLimitsToolStripMenuItem.Name = "setBackgroundTwoLimitsToolStripMenuItem";
            this.setBackgroundTwoLimitsToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setBackgroundTwoLimitsToolStripMenuItem.Text = "Set Background Two Limits";
            this.setBackgroundTwoLimitsToolStripMenuItem.Click += new System.EventHandler(this.setBackgroundTwoLimitsToolStripMenuItem_Click);
            // 
            // setColorNameTwoLimitToolStripMenuItem
            // 
            this.setColorNameTwoLimitToolStripMenuItem.Name = "setColorNameTwoLimitToolStripMenuItem";
            this.setColorNameTwoLimitToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorNameTwoLimitToolStripMenuItem.Text = "Set Color Name Two Limit";
            this.setColorNameTwoLimitToolStripMenuItem.Click += new System.EventHandler(this.setColorNameTwoLimitToolStripMenuItem_Click);
            // 
            // setColorCharactersTwoLimitsToolStripMenuItem
            // 
            this.setColorCharactersTwoLimitsToolStripMenuItem.Name = "setColorCharactersTwoLimitsToolStripMenuItem";
            this.setColorCharactersTwoLimitsToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.setColorCharactersTwoLimitsToolStripMenuItem.Text = "Set Color Characters \"Two Limits\"";
            this.setColorCharactersTwoLimitsToolStripMenuItem.Click += new System.EventHandler(this.setColorCharactersTwoLimitsToolStripMenuItem_Click);
            // 
            // twolimitsbox
            // 
            this.twolimitsbox.Location = new System.Drawing.Point(572, 31);
            this.twolimitsbox.MaxLength = 30000;
            this.twolimitsbox.Name = "twolimitsbox";
            this.twolimitsbox.Size = new System.Drawing.Size(100, 22);
            this.twolimitsbox.TabIndex = 3;
            // 
            // onelimitbox
            // 
            this.onelimitbox.Location = new System.Drawing.Point(466, 31);
            this.onelimitbox.Name = "onelimitbox";
            this.onelimitbox.Size = new System.Drawing.Size(100, 22);
            this.onelimitbox.TabIndex = 4;
            // 
            // onelimitLbl
            // 
            this.onelimitLbl.AutoSize = true;
            this.onelimitLbl.Location = new System.Drawing.Point(388, 31);
            this.onelimitLbl.Name = "onelimitLbl";
            this.onelimitLbl.Size = new System.Drawing.Size(72, 17);
            this.onelimitLbl.TabIndex = 5;
            this.onelimitLbl.Text = "One Limit:";
            // 
            // twolimitsLbl
            // 
            this.twolimitsLbl.AutoSize = true;
            this.twolimitsLbl.Location = new System.Drawing.Point(488, 31);
            this.twolimitsLbl.Name = "twolimitsLbl";
            this.twolimitsLbl.Size = new System.Drawing.Size(78, 17);
            this.twolimitsLbl.TabIndex = 6;
            this.twolimitsLbl.Text = "Two Limits:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(678, 549);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 578);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.twolimitsLbl);
            this.Controls.Add(this.onelimitLbl);
            this.Controls.Add(this.onelimitbox);
            this.Controls.Add(this.twolimitsbox);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.Runbtn);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PM4P";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Runbtn;
        private System.Windows.Forms.TextBox dane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnWindowWithOnePassLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnWindowWithTwoPassLimitsToolStripMenuItem;
        private System.Windows.Forms.TextBox twolimitsbox;
        private System.Windows.Forms.TextBox onelimitbox;
        private System.Windows.Forms.Label onelimitLbl;
        private System.Windows.Forms.Label twolimitsLbl;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setcolorofbackground;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundTwoLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBackgroundRunButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorCharactersTwoLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorDataWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorNameOneLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColorNameTwoLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setColoTextRunButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

