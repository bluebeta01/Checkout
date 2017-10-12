using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Checkout
{
    class Serial
    {
        public static void serializeFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\sso\\dates\\" + DateTime.Now.ToString("MMMM dd, yyyy"), FileMode.Create, FileAccess.Write, FileShare.None);
            SerialObj obj = new SerialObj();
            obj.list = Session.signOutObjectList;
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public static SerialObj deserializeFile(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            SerialObj obj = (SerialObj)formatter.Deserialize(stream);
            stream.Close();
            return obj;
        }
    }
}
