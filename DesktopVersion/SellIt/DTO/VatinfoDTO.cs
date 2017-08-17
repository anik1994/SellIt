using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellIt
{
    class VatinfoDTO
    {
        string type, vat;

        public VatinfoDTO(string type, string vat)
        {
            this.type = type;
            this.vat = vat;
        }

        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }
        public string VAT
        {
            get { return vat; }
            set { vat = value; }
        }
    }
}
