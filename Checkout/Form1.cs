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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputbox.KeyDown += new KeyEventHandler(tb_KeyDown);
            OnRun.createDirectories();
            OnRun.tryLoadDatabase();
        }

        private void addNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Multiselect = false;
            diag.Filter = "CSV File | *.csv";
            diag.ShowDialog();
            


            if(diag.FileName != "")
            {
                NewDatabaseForm form = new NewDatabaseForm();
                form.populateText(diag.FileName, Csvtools.Csvloader.loadCsv(diag.FileName));
                form.Show();
            }

        }

        
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DateTime now = DateTime.Now;
                outputbox.Text += inputbox.Text;
                outputbox.Text += "\t" + Csvtools.ReferenceDatabase.lookupName(inputbox.Text);
                outputbox.Text += "\t\t" + now.ToString("HH:mm tt") + "\r\n";

                inputbox.Text = "";


                Session.signOutObjectList.Add(new SignOutItems.SignOutObject(inputbox.Text, Csvtools.ReferenceDatabase.lookupName(inputbox.Text), now));
            }
        }
    }
}
