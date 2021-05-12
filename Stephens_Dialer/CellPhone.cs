using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephens_Dialer
{
    internal class CellPhone : Phone
    {
        public CellPhone(int phonenumber, string companyname, string phonetype) : base(phonenumber, companyname, phonetype)
        {
        }
    }
}
