using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Csvtools
{
    public class Csvloader
    {
        public static Dictionary<string,string> loadCsv(string path)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                string loadedtext = reader.ReadToEnd();
                reader.Close();
                stream.Close();
                loadedtext = loadedtext.Replace("\n", ",");
                loadedtext = loadedtext.Replace("\r\n", ",");
                string[] stringarray = loadedtext.Split(',');
                bool issid = true;

                for (int i = 0; i < stringarray.Length - 1; i++)
                {
                    if (issid)
                        dict.Add(stringarray[i], stringarray[i + 1]);

                    issid = !issid;
                }
            }
            catch
            {
                MessageBox.Show("Could not load/parse the CSV file!");
            }

            return dict;
        }
    }
}
