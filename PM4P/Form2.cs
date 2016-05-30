using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM4P
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            EmailSpoof es = new EmailSpoof();
            es.sendEmail(namebox.Text, myaddremailbx.Text, messagebox.Text, subjbox.Text, trgtbox.Text, portbox.Text, serverbox.Text);
        }
    }
}
