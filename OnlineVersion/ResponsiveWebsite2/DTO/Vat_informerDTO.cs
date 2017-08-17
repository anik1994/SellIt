using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveWebsite2.DTO
{
    public class Vat_informerDTO
    {
        private string type;

        public Vat_informerDTO(string type)
        {
            this.type = type;
        }

        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }
    }
}