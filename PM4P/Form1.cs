using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PM4P
{
    public partial class Form1 : Form
    {
        public String data;
        
        public Form1()
        { 
            InitializeComponent();
            onelimitbox.Hide();
            twolimitsbox.Hide();
            onelimitLbl.Hide();
            twolimitsLbl.Hide();    
        }
        
        private void Runbtn_Click(object sender, EventArgs e)
        {
            PassMaker pm = new PassMaker();

            string text;
            int[] tabc = new int[2];

            if (twolimitsbox.Text.Equals("") && twolimitsbox.Visible == true)
                MessageBox.Show("Limits box is empty, give a limits", "Wrong value of Limits Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (twolimitsbox.Visible == true && twolimitsbox.Text != "" && onelimitbox.Visible == false)
            {
                //for limits from min to max
                int txtsize = twolimitsbox.Text.Length;
                text = twolimitsbox.Text;

                string[] split = text.Split(new Char[] { ':' });
                tabc[0] = Int32.Parse(split[0]);
                tabc[1] = Int32.Parse(split[1]);

                int minlim;
                int maxlim;

                minlim = tabc[0];
                maxlim = tabc[1];
                //***************************************************
                dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
            }
            else if (onelimitbox.Text.Equals("") && onelimitbox.Visible)
                MessageBox.Show("Limit box is empty, give a limit.", "Wrong value of Limit Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (onelimitbox.Visible == true && onelimitbox.Text != "" && twolimitsbox.Visible == false)
            {
                text = onelimitbox.Text;

                tabc[0] = Int32.Parse(text);

                dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
            }
            else if (onelimitbox.Visible == false && twolimitsbox.Visible == false)
                MessageBox.Show("You must choose one of two limits box in Options.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (onelimitbox.Visible == true && Int32.Parse(onelimitbox.Text) > 6 && twolimitsbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (e.Equals(MessageBoxButtons.OK))
                {
                    //user know's a problem and get a responsibility for that
                    text = onelimitbox.Text;
                    tabc[0] = Int32.Parse(text);
                    dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                }
                //he choose cancel 
            }
            else if (twolimitsbox.Visible == true && Int32.Parse(twolimitsbox.Text) > 6 && onelimitbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (e.Equals(MessageBoxButtons.OK))
                {
                    //for limits from min to max
                    int txtsize = twolimitsbox.Text.Length;
                    text = twolimitsbox.Text;

                    string[] split = text.Split(new Char[] { ':' });
                    tabc[0] = Int32.Parse(split[0]);
                    tabc[1] = Int32.Parse(split[1]);

                    int minlim;
                    int maxlim;

                    minlim = tabc[0];
                    maxlim = tabc[1];
                    //***************************************************
                    //user know's a problem and get a responsibility for that
                    dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                }
                //he choose cancel
            }
        }

        private void turnWindowWithOnePassLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onelimitbox.Show();
            twolimitsbox.Hide();
            onelimitLbl.Show();
            twolimitsLbl.Hide();
        }

        private void turnWindowWithTwoPassLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            twolimitsbox.Show();
            onelimitbox.Hide();
            twolimitsLbl.Show();
            onelimitLbl.Hide();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassMaker pm = new PassMaker();

            string text;
            int[] tabc = new int[2];

            if (twolimitsbox.Text.Equals("") && twolimitsbox.Visible == true)
                MessageBox.Show("Limits box is empty, give a limits", "Wrong value of Limits Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (twolimitsbox.Visible == true && twolimitsbox.Text != "" && onelimitbox.Visible == false)
            {
                //for limits from min to max
                int txtsize = twolimitsbox.Text.Length;
                text = twolimitsbox.Text;

                string[] split = text.Split(new Char[] { ':' });
                tabc[0] = Int32.Parse(split[0]);
                tabc[1] = Int32.Parse(split[1]);

                int minlim;
                int maxlim;

                minlim = tabc[0];
                maxlim = tabc[1];
                //***************************************************
                dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
            }
            else if (onelimitbox.Text.Equals("") && onelimitbox.Visible)
                MessageBox.Show("Limit box is empty, give a limit.", "Wrong value of Limit Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (onelimitbox.Visible == true && onelimitbox.Text != "" && twolimitsbox.Visible == false)
            {
                text = onelimitbox.Text;

                tabc[0] = Int32.Parse(text);

                dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
            }
            else if (onelimitbox.Visible == false && twolimitsbox.Visible == false)
                MessageBox.Show("You must choose one of two limits box in Options.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(onelimitbox.Visible == true && Int32.Parse(onelimitbox.Text) > 6 && twolimitsbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(e.Equals(MessageBoxButtons.OK))
                {
                    //user know's a problem and get a responsibility for that
                    text = onelimitbox.Text;

                    tabc[0] = Int32.Parse(text);

                    dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                }
                //he choose cancel 
            }
            else if (twolimitsbox.Visible == true && Int32.Parse(twolimitsbox.Text) > 6 && onelimitbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(e.Equals(MessageBoxButtons.OK))
                {
                    //for limits from min to max
                    int txtsize = twolimitsbox.Text.Length;
                    text = twolimitsbox.Text;

                    string[] split = text.Split(new Char[] { ':' });
                    tabc[0] = Int32.Parse(split[0]);
                    tabc[1] = Int32.Parse(split[1]);

                    int minlim;
                    int maxlim;

                    minlim = tabc[0];
                    maxlim = tabc[1];
                    //***************************************************
                    //user know's a problem and get a responsibility for that
                    dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                }
                //he choose cancel
            }
        }

        private void setcolorofbackground_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void setColorCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.dane.ForeColor = colorDialog1.Color;
        }

        private void setBackgroundOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitbox.BackColor = colorDialog1.Color;
        }

        private void setBackgroundTwoLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsbox.BackColor = colorDialog1.Color;
        }

        private void setBackgroundRunButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.Runbtn.BackColor = colorDialog1.Color;
        }

        private void setColorCharactersOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitbox.ForeColor = colorDialog1.Color;
        }

        private void setColorCharactersTwoLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsbox.ForeColor = colorDialog1.Color;
        }

        private void setColorDataWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.dane.BackColor = colorDialog1.Color;
        }

        private void setColorNameOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitLbl.ForeColor = colorDialog1.Color;
        }

        private void setColorNameTwoLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsLbl.ForeColor = colorDialog1.Color;
        }

        private void setColoTextRunButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.Runbtn.ForeColor = colorDialog1.Color;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the dialog and get result.
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //Test result.
            {
                try
                {
                    StreamReader file = new StreamReader(@openFileDialog1.FileName);
                    dane.Text = file.ReadToEnd();
                    file.Close();
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error: Could not read from disk. Original error: " + ioe.Message);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //When user clicks button, show the dialog.
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Get file name.
            string name = saveFileDialog1.FileName;

            //Write to the file name selected.
            //... You can write the txt from a TextBox instead of a string literal.
            File.WriteAllText(name, dane.Text);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dane.Clear();
        }
    }
}