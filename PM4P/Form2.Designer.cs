namespace PM4P
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.messagebox = new System.Windows.Forms.TextBox();
            this.myaddremaillbl = new System.Windows.Forms.Label();
            this.myaddremailbx = new System.Windows.Forms.TextBox();
            this.trgtemailaddrlbl = new System.Windows.Forms.Label();
            this.mylblname = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.sublbl = new System.Windows.Forms.Label();
            this.subjbox = new System.Windows.Forms.TextBox();
            this.trgtbox = new System.Windows.Forms.TextBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.portlbl = new System.Windows.Forms.Label();
            this.portbox = new System.Windows.Forms.TextBox();
            this.serverlbl = new System.Windows.Forms.Label();
            this.serverbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(2, 1);
            this.messagebox.Multiline = true;
            this.messagebox.Name = "messagebox";
            this.messagebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagebox.Size = new System.Drawing.Size(414, 330);
            this.messagebox.TabIndex = 0;
            // 
            // myaddremaillbl
            // 
            this.myaddremaillbl.AutoSize = true;
            this.myaddremaillbl.Location = new System.Drawing.Point(422, 40);
            this.myaddremaillbl.Name = "myaddremaillbl";
            this.myaddremaillbl.Size = new System.Drawing.Size(112, 17);
            this.myaddremaillbl.TabIndex = 1;
            this.myaddremaillbl.Text = "Your email addr:";
            // 
            // myaddremailbx
            // 
            this.myaddremailbx.Location = new System.Drawing.Point(540, 37);
            this.myaddremailbx.Name = "myaddremailbx";
            this.myaddremailbx.Size = new System.Drawing.Size(208, 22);
            this.myaddremailbx.TabIndex = 2;
            // 
            // trgtemailaddrlbl
            // 
            this.trgtemailaddrlbl.AutoSize = true;
            this.trgtemailaddrlbl.Location = new System.Drawing.Point(422, 111);
            this.trgtemailaddrlbl.Name = "trgtemailaddrlbl";
            this.trgtemailaddrlbl.Size = new System.Drawing.Size(124, 17);
            this.trgtemailaddrlbl.TabIndex = 3;
            this.trgtemailaddrlbl.Text = "Target email addr:";
            // 
            // mylblname
            // 
            this.mylblname.AutoSize = true;
            this.mylblname.Location = new System.Drawing.Point(422, 9);
            this.mylblname.Name = "mylblname";
            this.mylblname.Size = new System.Drawing.Size(81, 17);
            this.mylblname.TabIndex = 4;
            this.mylblname.Text = "Your name:";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(509, 6);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(239, 22);
            this.namebox.TabIndex = 5;
            // 
            // sublbl
            // 
            this.sublbl.AutoSize = true;
            this.sublbl.Location = new System.Drawing.Point(422, 72);
            this.sublbl.Name = "sublbl";
            this.sublbl.Size = new System.Drawing.Size(120, 17);
            this.sublbl.TabIndex = 6;
            this.sublbl.Text = "Message Subject:";
            // 
            // subjbox
            // 
            this.subjbox.Location = new System.Drawing.Point(540, 69);
            this.subjbox.Name = "subjbox";
            this.subjbox.Size = new System.Drawing.Size(208, 22);
            this.subjbox.TabIndex = 7;
            // 
            // trgtbox
            // 
            this.trgtbox.Location = new System.Drawing.Point(552, 108);
            this.trgtbox.Name = "trgtbox";
            this.trgtbox.Size = new System.Drawing.Size(196, 22);
            this.trgtbox.TabIndex = 8;
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(425, 204);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(109, 51);
            this.Sendbtn.TabIndex = 9;
            this.Sendbtn.Text = "Send";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // portlbl
            // 
            this.portlbl.AutoSize = true;
            this.portlbl.Location = new System.Drawing.Point(422, 140);
            this.portlbl.Name = "portlbl";
            this.portlbl.Size = new System.Drawing.Size(38, 17);
            this.portlbl.TabIndex = 10;
            this.portlbl.Text = "Port:";
            // 
            // portbox
            // 
            this.portbox.Location = new System.Drawing.Point(466, 137);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(94, 22);
            this.portbox.TabIndex = 11;
            // 
            // serverlbl
            // 
            this.serverlbl.AutoSize = true;
            this.serverlbl.Location = new System.Drawing.Point(422, 174);
            this.serverlbl.Name = "serverlbl";
            this.serverlbl.Size = new System.Drawing.Size(54, 17);
            this.serverlbl.TabIndex = 12;
            this.serverlbl.Text = "Server:";
            // 
            // serverbox
            // 
            this.serverbox.Location = new System.Drawing.Point(482, 171);
            this.serverbox.Name = "serverbox";
            this.serverbox.Size = new System.Drawing.Size(266, 22);
            this.serverbox.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 332);
            this.Controls.Add(this.serverbox);
            this.Controls.Add(this.serverlbl);
            this.Controls.Add(this.portbox);
            this.Controls.Add(this.portlbl);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.trgtbox);
            this.Controls.Add(this.subjbox);
            this.Controls.Add(this.sublbl);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.mylblname);
            this.Controls.Add(this.trgtemailaddrlbl);
            this.Controls.Add(this.myaddremailbx);
            this.Controls.Add(this.myaddremaillbl);
            this.Controls.Add(this.messagebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Email Spoof";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagebox;
        private System.Windows.Forms.Label myaddremaillbl;
        private System.Windows.Forms.TextBox myaddremailbx;
        private System.Windows.Forms.Label trgtemailaddrlbl;
        private System.Windows.Forms.Label mylblname;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label sublbl;
        private System.Windows.Forms.TextBox subjbox;
        private System.Windows.Forms.TextBox trgtbox;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Label portlbl;
        private System.Windows.Forms.TextBox portbox;
        private System.Windows.Forms.Label serverlbl;
        private System.Windows.Forms.TextBox serverbox;
    }
}