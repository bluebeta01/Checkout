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
            OnRun.createDirectories();
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
    }
}
