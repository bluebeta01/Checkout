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
    public partial class NewDatabaseForm : Form
    {
        public NewDatabaseForm()
        {
            InitializeComponent();
        }

        private void NewDatabaseForm_Load(object sender, EventArgs e)
        {

        }

        private string path;

        public void populateText(string filedir, Dictionary<string,string> dict)
        {
            string text = "";
            path = filedir;

            foreach(KeyValuePair<string,string> entry in dict)
            {
                text += entry.Key;
                text += "     ";
                text += entry.Value;
                text += "\r\n";
            }

            textBox1.Text = text;
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If the table does not appear to be formatted correctly, this is most likely because it was not formatted correctly in Microsoft Excel. Please refer to the documentation and check the formatting");
            this.Close();
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("C:\\sso\\database.csv"))
                    File.Delete("C:\\sso\\database.csv");
                File.Copy(path, "C:\\sso\\database.csv");
                MessageBox.Show("Database added successfully!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Could not add database! Please make sure the file you are trying to add is not in use or still open in Excel.");
                this.Close();
            }
        }
    }
}
