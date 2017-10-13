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
using System.Drawing.Printing;

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
            OnRun.loadPreviousCheckouts();
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

                lastid.Text = inputbox.Text + "\t\t" + Csvtools.ReferenceDatabase.lookupName(inputbox.Text);

                Session.signOutObjectList.Add(new SignOutItems.SignOutObject(inputbox.Text, Csvtools.ReferenceDatabase.lookupName(inputbox.Text), now));

                Serial.serializeFile();
                inputbox.Text = "";
            }
        }

        private void addSingleStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:\\sso\\database.csv"))
            {
                New_Student studentform = new New_Student();
                studentform.Show();
            }
            else
            {
                MessageBox.Show("You have to add a database before you can add students indiviually.");
            }
        }

        private void searchForStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void viewFullRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullRecordSelect form = new FullRecordSelect();
            form.Show();
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm form = new PrintForm();
            form.Show();
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created and maintained by Logan Klumpp.\nThis program is free and opensource.\nThe full C# source code can be found on github.\nklumpplogan@gmail.com\nGitHub Username: Bluebeta01");
        }
    }
}
