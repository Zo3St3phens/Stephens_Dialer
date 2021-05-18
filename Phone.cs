using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stephens_Dialer
{
    class Phone
    {
        private string _company;
        private string _phone;
        private int _phonetype;

        public string Company { 
            get { return _company; }
        }

        public string PhoneNumber
        {
            get { return _phone; }
        }


        public int PhoneType
        {
            get { return _phonetype; }
        }



        public Phone(string CompanyName, string PhoneNumber, int DialType)
        {
            _company = CompanyName;
            _phone = PhoneNumber;
            _phonetype = DialType;
        }
        public virtual string Dial()
        {
            return   _company + " is being dialed using"  + _phone;
        }

    }
}
