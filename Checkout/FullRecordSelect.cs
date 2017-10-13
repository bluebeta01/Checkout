using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout
{
    public partial class FullRecordSelect : Form
    {
        public FullRecordSelect()
        {
            InitializeComponent();
        }

        private void filenamebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(filenamebox.Text != "")
            {
                string returnvalue = "";
                List<SignOutItems.SignOutObject> obj = Serial.deserializeFile("C:\\sso\\dates\\" + filenamebox.Text).list;
                for(int i = 0; i < obj.ToArray().Length; i++)
                {
                    returnvalue += obj[i].id + "\t" + obj[i].name + "\t\t" + obj[i].dateTime.ToString("hh:mm tt") + "\r\n";
                }
                FullRecord form = new FullRecord();
                form.Show();
                form.populateBox(returnvalue);
                this.Close();
            }
        }

        private void FullRecordSelect_Load(object sender, EventArgs e)
        {
            foreach (string i in Directory.GetFiles("C:\\sso\\dates"))
            {
                filenamebox.Items.Add(Path.GetFileName(i));
            }
            filenamebox.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}
