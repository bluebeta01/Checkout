using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Checkout
{
    class OnRun
    {
        public static void createDirectories()
        {
            Directory.CreateDirectory("C:\\sso");
            Directory.CreateDirectory("C:\\sso\\dates");
        }
    }
}
