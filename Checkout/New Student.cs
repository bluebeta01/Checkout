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
    public partial class New_Student : Form
    {
        public New_Student()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(id.Text != "" & name.Text != "")
            {
                try
                {
                    FileStream readstream = new FileStream("C:\\sso\\database.csv", FileMode.Open);
                    StreamReader reader = new StreamReader(readstream);
                    string file = reader.ReadToEnd();
                    reader.Close();
                    readstream.Close();
                    file += "," + id.Text + "," + name.Text;
                    FileStream writestream = new FileStream("C:\\sso\\database.csv", FileMode.Create);
                    StreamWriter writer = new StreamWriter(writestream);
                    writer.Write(file);
                    writer.Close();
                    writestream.Close();
                    MessageBox.Show("Added Student Successfully!\r\nNote: The change will not take affect until you restart the program.");
                    id.Text = "";
                    name.Text = "";
                }
                catch
                {
                    MessageBox.Show("There was an error adding the student!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill out both boxes.");
            }
        }
    }
}
