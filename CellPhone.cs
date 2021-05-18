using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephens_Dialer
{
     class CellPhone : Phone
    {
        public CellPhone(string CompanyName, string PhoneNumber, int DialType) : base(CompanyName, PhoneNumber, DialType)
        { }

        public override string Dial()
        {
            return "Company" + base.Company + "is being contacted at +1" + base.PhoneNumber;
        }

    }
}
