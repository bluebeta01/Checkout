using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkout
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            foreach (string i in Directory.GetFiles("C:\\sso\\dates"))
            {
                filenamebox.Items.Add(Path.GetFileName(i));
            }
            filenamebox.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string printstring = "";
        private void accept_Click(object sender, EventArgs e)
        {
            
            List<SignOutItems.SignOutObject> obj = Serial.deserializeFile("C:\\sso\\dates\\" + filenamebox.Text).list;
            for (int i = 0; i < obj.ToArray().Length; i++)
            {
                printstring += obj[i].id + "\t\t" + obj[i].name + "\t\t" + obj[i].dateTime.ToString("hh:mm tt") + "\r\n";
            }

            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.DefaultPageSettings.Color = false;
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            printDoc.PrintPage += new PrintPageEventHandler(this.PrintReceiptPage);

            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                printDoc.Print();
            }

        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            
            int y;
            // Print receipt
            Font myFont = new Font("Times New Roman", 13, FontStyle.Regular);
            y = e.MarginBounds.Y;
            e.Graphics.DrawString(printstring, myFont, Brushes.Black, e.MarginBounds.X, y);
            this.Close();
        }
    }
}
