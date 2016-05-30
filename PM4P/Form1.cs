using PM4P.Properties;
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

            Linklbl.Hide();
            LinktxtBox.Hide();

            URLTargettxtbox.Hide();
            targetlbl.Hide();

            IPlbl.Hide();
            iptxtbox.Hide();
            portlbl.Hide();
            porttextbox.Hide();
            pathfilelbl.Hide();
            pathfiletxtbox.Hide();

            URLtxtbox2.Hide();
            URLtrgtlbl.Hide();

            IPSYNATTtxtbox.Hide();
            IPSYNATTlbl.Hide();
            PORTSYNATTlbl.Hide();
            PORTSYNATTtxtbox.Hide();

            lbllinkcp.Hide();
            txtbxcplink.Hide();
        }
        
        //obsługa zdarzeń z przycisku Run
        private void Runbtn_Click(object sender, EventArgs e)
        {
            PassMaker pm = new PassMaker();
            DataFromWeb dfw = new DataFromWeb();

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
                //dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                pm.getparam2(maxlim, minlim, dane.Text.Length, dane.Text);
                pm.runfunction2();
                dane.Text = pm.retvalue2();
            }
            else if (onelimitbox.Text.Equals("") && onelimitbox.Visible)
                MessageBox.Show("Limit box is empty, give a limit.", "Wrong value of Limit Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (onelimitbox.Visible == true && onelimitbox.Text != "" && twolimitsbox.Visible == false)
            {
                text = onelimitbox.Text;

                tabc[0] = Int32.Parse(text);

                //dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                pm.getparam(tabc[0], dane.Text.Length, dane.Text);
                pm.runfunction();
                dane.Text = pm.retvalue();
            }
            else if (onelimitbox.Visible == true && Int32.Parse(onelimitbox.Text) > 6 && twolimitsbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (e.Equals(MessageBoxButtons.OK))
                {
                    //user know's a problem and get a responsibility for that
                    text = onelimitbox.Text;
                    tabc[0] = Int32.Parse(text);
                    //dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                    pm.getparam(tabc[0], dane.Text.Length, dane.Text);
                    pm.runfunction();
                    pm.retvalue();
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
                    //dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                    pm.getparam2(maxlim, minlim, dane.Text.Length, dane.Text);
                    pm.runfunction2();
                    dane.Text = pm.retvalue2();
                }
                //he choose cancel
            }
            else if (Linklbl.Visible == true)
                dane.Text = dfw.HSD(LinktxtBox.Text);
            else if (Linklbl.Visible == true && Linklbl.Text.Equals(""))
                MessageBox.Show("The box is empty or bad value! Please try again.", "Bad Value or empty!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(URLTargettxtbox.Visible == true && URLTargettxtbox.Text != "")
            {
                DosDDos dds = new DosDDos();
                string target = URLTargettxtbox.Text;

                dds.getparam(dane.Text, URLTargettxtbox.Text);
                dane.Text += dds.runfunction();
            }
            else if(iptxtbox.Visible == true && iptxtbox.Text != "" && porttextbox.Text != "" && pathfiletxtbox.Text != "")
            {

                DoSUDP dudp = new DoSUDP();
                dudp.getparam(pathfiletxtbox.Text, iptxtbox.Text, Int32.Parse(porttextbox.Text), dane.Text);
                dane.Text += dudp.runfunction();
            }
            else if(URLtxtbox2.Visible == true && URLtxtbox2.Text != "")
            {
                DDoS2 dds = new DDoS2();
                dds.getparam(dane.Text, URLtxtbox2.Text);
                dane.Text += dds.runfunction();
            }
            else if(IPSYNATTtxtbox.Visible == true && IPSYNATTtxtbox.Text != "" && PORTSYNATTtxtbox.Visible == true && PORTSYNATTtxtbox.Text != "")
            {
                DoS3 ds = new DoS3();

                ds.getparam(IPSYNATTtxtbox.Text, Int32.Parse(PORTSYNATTtxtbox.Text), dane.Text);
                dane.Text += ds.runfunction();
            }
            else if(lbllinkcp.Visible == true && txtbxcplink.Visible == true && txtbxcplink.Text != "")
            {
                CPWS cpws = new CPWS();

                dane.Text = cpws.copywebsite(txtbxcplink.Text);

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

        //obsługa zdarzeń z przycisku run w menu kontekstowym i skrócie
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassMaker pm = new PassMaker();
            DataFromWeb dfw = new DataFromWeb();

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
                //dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                pm.getparam2(maxlim, minlim, dane.Text.Length, dane.Text);
                pm.runfunction2();
                dane.Text = pm.retvalue2();
            }
            else if (onelimitbox.Text.Equals("") && onelimitbox.Visible)
                MessageBox.Show("Limit box is empty, give a limit.", "Wrong value of Limit Box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (onelimitbox.Visible == true && onelimitbox.Text != "" && twolimitsbox.Visible == false)
            {
                text = onelimitbox.Text;

                tabc[0] = Int32.Parse(text);

                //dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                pm.getparam(tabc[0], dane.Text.Length, dane.Text);
                pm.runfunction();
                dane.Text = pm.retvalue();
            }
            /*else if ((onelimitbox.Visible == false && twolimitsbox.Visible == false) || LinktxtBox.Visible == false)
                MessageBox.Show("You must choose one of two limits boxes in Options or link box.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            else if (onelimitbox.Visible == true && Int32.Parse(onelimitbox.Text) > 6 && twolimitsbox.Visible == false)
            {
                MessageBox.Show("Limit box is high and will get a lot of memory!!!", "High value of limit!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (e.Equals(MessageBoxButtons.OK))
                {
                    //user know's a problem and get a responsibility for that
                    text = onelimitbox.Text;

                    tabc[0] = Int32.Parse(text);

                    //dane.Text = pm.MakingPassword(tabc[0], dane.Text.Length, dane.Text);
                    pm.getparam(tabc[0], dane.Text.Length, dane.Text);
                    pm.runfunction();
                    dane.Text = pm.retvalue();
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
                    //dane.Text = pm.MakingPassword2(maxlim, minlim, dane.Text.Length, dane.Text);    //maxlim - max limit, minlim - min limit, dane.Text.Length - ilość znaków
                    pm.getparam2(maxlim, minlim, dane.Text.Length, dane.Text);
                    pm.runfunction2();
                    dane.Text = pm.retvalue2();
                }
                //he choose cancel
            }
            else if (Linklbl.Visible == true)
                dane.Text = dfw.HSD(LinktxtBox.Text);
            else if (Linklbl.Visible == true && Linklbl.Text.Equals(""))
                MessageBox.Show("The box value is empty or has bad value! Please try again.", "Bad value or empty box!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (URLTargettxtbox.Visible == true && URLTargettxtbox.Text != "")
            {
                DosDDos dds = new DosDDos();
                string target = URLTargettxtbox.Text;

                dds.getparam(dane.Text, URLTargettxtbox.Text);
                dane.Text += dds.runfunction();
            }
            else if (iptxtbox.Visible == true && iptxtbox.Text != "" && porttextbox.Text != "" && pathfiletxtbox.Text != "")
            {
                DoSUDP dudp = new DoSUDP();
                dudp.getparam(pathfiletxtbox.Text, iptxtbox.Text, Int32.Parse(porttextbox.Text), dane.Text);
                dane.Text += dudp.runfunction();
            }
            else if (URLtxtbox2.Visible == true && URLtxtbox2.Text != "")
            {
                DDoS2 dds = new DDoS2();
                
                dds.getparam(dane.Text, URLtxtbox2.Text);
                dane.Text += dds.runfunction();
            }
            else if(IPSYNATTtxtbox.Visible == true && IPSYNATTtxtbox.Text != "" && PORTSYNATTtxtbox.Visible == true && PORTSYNATTtxtbox.Text != "")
            {
                DoS3 ds = new DoS3();

                ds.getparam(IPSYNATTtxtbox.Text, Int32.Parse(PORTSYNATTtxtbox.Text), dane.Text);
                dane.Text += ds.runfunction();
            }
            else if(lbllinkcp.Visible == true && txtbxcplink.Visible == true && txtbxcplink.Text != "")
            {
                CPWS cpws = new CPWS();

                dane.Text = cpws.copywebsite(txtbxcplink.Text);
            }
        }

        //cześć odpowiedzialna z ustawienia kolorów
        private System.Drawing.Color col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11;
        private void setcolorofbackground_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            col1 = this.BackColor;
        }

        private void setColorCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.dane.ForeColor = colorDialog1.Color;
            col2 = this.dane.ForeColor;
        }

        private void setBackgroundOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitbox.BackColor = colorDialog1.Color;
            col3 = this.onelimitbox.BackColor;
        }

        private void setBackgroundTwoLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsbox.BackColor = colorDialog1.Color;
            col4 = this.twolimitsbox.BackColor;
        }

        private void setBackgroundRunButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.Runbtn.BackColor = colorDialog1.Color;
            col5 = this.Runbtn.BackColor;
        }

        private void setColorCharactersOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitbox.ForeColor = colorDialog1.Color;
            col6 = this.onelimitbox.ForeColor;
        }

        private void setColorCharactersTwoLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsbox.ForeColor = colorDialog1.Color;
            col7 = this.twolimitsbox.ForeColor;
        }

        private void setColorDataWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.dane.BackColor = colorDialog1.Color;
            col8 = this.dane.BackColor;
        }

        private void setColorNameOneLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.onelimitLbl.ForeColor = colorDialog1.Color;
            col9 = this.onelimitLbl.ForeColor;
        }

        private void setColorNameTwoLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.twolimitsLbl.ForeColor = colorDialog1.Color;
            col10 = this.twolimitsLbl.ForeColor;
        }

        private void setColoTextRunButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.Runbtn.ForeColor = colorDialog1.Color;
            col11 = this.Runbtn.ForeColor;
        }

        //obsługa pliku
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

        //wyczyszczenie okna
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dane.Clear();
        }

        //załadowanie okna z określonymi ustawieniami
        private void Form1_Load(object sender, EventArgs e)
        {
            //new colors of ours form
            this.BackColor = Settings.Default.BackgroundColor;
            dane.ForeColor = Settings.Default.ColorCharacters;
            onelimitbox.BackColor = Settings.Default.BackgroundOneLimit;
            twolimitsbox.BackColor = Settings.Default.BackgroundTwoLimits;
            Runbtn.BackColor = Settings.Default.BackgroundRunButton;
            onelimitbox.ForeColor = Settings.Default.ColorCharactersOneLimit;
            twolimitsbox.ForeColor = Settings.Default.ColorCharactersTwoLimits;
            dane.BackColor = Settings.Default.ColorDataWindow;
            onelimitLbl.ForeColor = Settings.Default.ColorNameOneLimit;
            twolimitsLbl.ForeColor = Settings.Default.ColorNameTwoLimits;
            Runbtn.ForeColor = Settings.Default.ColorTextRunButton;
        }

        //zachowanie sesji w celu zapisania ustawień
        private void saveSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings of color every control of program
            Settings.Default["BackgroundColor"] = col1;
            Settings.Default["ColorCharacters"] = col2;
            Settings.Default["BackgroundOneLimit"] = col3;
            Settings.Default["BackgroundTwoLimits"] = col4;
            Settings.Default["BackgroundRunButton"] = col5;
            Settings.Default["ColorCharactersOneLimit"] = col6;
            Settings.Default["ColorCharactersTwoLimits"] = col7;
            Settings.Default["ColorDataWindow"] = col8;
            Settings.Default["ColorNameOneLimit"] = col9;
            Settings.Default["ColorNameTwoLimits"] = col10;
            Settings.Default["ColorTextRunButton"] = col11;

            //save settings
            Settings.Default.Save();
        }

        //pobranie danych z strony www
        private void takingDataFromWebSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linklbl.Show();
            LinktxtBox.Show();
        }

        //funkcje od kodowania znaków
        private void uTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataUTF8(dane.Text);
        }

        private void windows1251ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataFromCyrilictoUTF8(dane.Text);
        }

        private void windows1252ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataWestUTF8(dane.Text);
        }

        private void windows1253ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataGreekUTF8(dane.Text);
        }

        private void windows1254ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataTurkishUTF8(dane.Text);
        }

        private void windows1255ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataHebrewUTF8(dane.Text);
        }

        private void windows1256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataArabicUTF8(dane.Text);
        }

        private void windows1257ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncodingData ed = new EncodingData();
            dane.Text = ed.EncodeDataBalticUTF8(dane.Text);
        }

        //funkcje odpowiedzialne za ataki DoS
        private void doSSYNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPSYNATTlbl.Show();
            IPSYNATTtxtbox.Show();
            PORTSYNATTtxtbox.Show();
            PORTSYNATTlbl.Show();

            //***************************Hide part
            URLTargettxtbox.Hide();
            targetlbl.Hide();
            IPlbl.Hide();
            portlbl.Hide();
            porttextbox.Hide();
            pathfilelbl.Hide();
            pathfiletxtbox.Hide();
            URLtxtbox2.Hide();
            URLtrgtlbl.Hide();
        }

        private void doSByURIIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLTargettxtbox.Show();
            targetlbl.Show();

            //**********************Hide part
            IPlbl.Hide();
            portlbl.Hide();
            porttextbox.Hide();
            pathfilelbl.Hide();
            pathfiletxtbox.Hide();


            URLtxtbox2.Hide();
            URLtrgtlbl.Hide();

            IPSYNATTlbl.Hide();
            IPSYNATTtxtbox.Hide();
            PORTSYNATTlbl.Hide();
            PORTSYNATTtxtbox.Hide();
        }

        private void doSUDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPlbl.Show();
            iptxtbox.Show();
            portlbl.Show();
            porttextbox.Show();
            pathfilelbl.Show();
            pathfiletxtbox.Show();

            //******************Hide part
            URLTargettxtbox.Hide();
            targetlbl.Hide();

            URLtxtbox2.Hide();
            URLtrgtlbl.Hide();

            IPSYNATTlbl.Hide();
            IPSYNATTtxtbox.Hide();
            PORTSYNATTlbl.Hide();
            PORTSYNATTtxtbox.Hide();
        }

        private void doSByHTTPReqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            URLtxtbox2.Show();
            URLtrgtlbl.Show();

            //*********************Hide part
            URLTargettxtbox.Hide();
            targetlbl.Hide();

            IPlbl.Hide();
            iptxtbox.Hide();
            portlbl.Hide();
            porttextbox.Hide();
            pathfilelbl.Hide();
            pathfiletxtbox.Hide();

            IPSYNATTlbl.Hide();
            IPSYNATTtxtbox.Hide();
            PORTSYNATTlbl.Hide();
            PORTSYNATTtxtbox.Hide();
        }

        private void webSpoofingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbllinkcp.Show();
            txtbxcplink.Show();

            //*********************Hide part
            URLtrgtlbl.Hide();
            URLtxtbox2.Hide();
            URLTargettxtbox.Hide();
            targetlbl.Hide();

            IPlbl.Hide();
            iptxtbox.Hide();
            portlbl.Hide();
            porttextbox.Hide();
            pathfilelbl.Hide();
            pathfiletxtbox.Hide();

            IPSYNATTlbl.Hide();
            IPSYNATTtxtbox.Hide();
            PORTSYNATTlbl.Hide();
            PORTSYNATTtxtbox.Hide();
        }

        private void emailSpoofingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}