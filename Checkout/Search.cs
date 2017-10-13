using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Checkout
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            foreach(string i in Directory.GetFiles("C:\\sso\\dates"))
            {
                filenamebox.Items.Add(Path.GetFileName(i));
            }

            filenamebox.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(filenamebox.Text != "" && id.Text != "")
            {
                string times = "";
                SerialObj obj = Serial.deserializeFile("C:\\sso\\dates\\" + filenamebox.Text);
                foreach (SignOutItems.SignOutObject item in obj.list)
                {
                    if (item.id == id.Text)
                    {
                        times += item.dateTime.ToString("hh:mm tt") + ", ";
                    }
                }

                if (times == "")
                {
                    MessageBox.Show("No records were found for that student.\n\nNOTE: If the student entered their name instead of scanning their ID, they may not show up in the search. If you allow students to enter their name, this result may be erroneous and you will need to view the Full Record.");
                }
                else
                {
                    MessageBox.Show("That student ID was scanned at the following time(s):\n\n" + times + "\n\nNOTE: If the student entered their name instead of scanning their ID, they may not show up in the search. If you allow students to enter their name, this result may be erroneous and you will need to view the Full Record.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value");
            }
        }
    }
}
