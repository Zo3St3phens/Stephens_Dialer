using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephens_Dialer
{
    class Phone
    {
        private int _phonenumber;
        private string _companyname;
        private string _phonetype;

        public Phone()
        {
        }

        public Phone(int phonenumber, string companyname,string phonetype)
        {
            _phonenumber = phonenumber;
            _companyname = companyname;
            _phonetype = phonetype;

        }
       public string Dial()
        {
            return "Dialing phone number...";
        }

      
    }
}
