using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.SignOutItems
{
    [Serializable]
    class SignOutObject
    {
        public string id, name;
        public DateTime dateTime;

        public SignOutObject(string id, string name, DateTime dateTime)
        {
            this.id = id;
            this.name = name;
            this.dateTime = dateTime;
        }
    }
}
