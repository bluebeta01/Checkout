using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csvtools
{
    public class ReferenceDatabase
    {
        public static Dictionary<string, string> referenceDict = new Dictionary<string, string>();

        public static void loadDefaultDatabase()
        {
            try
            {
                referenceDict = Csvloader.loadCsv("C:\\sso\\database.csv");
            }
            catch
            {

            }
        }

        public static string lookupName(string id)
        {
            string outvalue = "";
            referenceDict.TryGetValue(id, out outvalue);
            return outvalue;
        }
    }
}
