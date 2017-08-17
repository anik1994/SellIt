using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveWebsite2
{
    public class Customer_infoDTO
    {

        private string name,email,password,address,phoneno;

        public Customer_infoDTO(string email,string password)
        {
            this.email = email;
            this.password = password;
        }

        public Customer_infoDTO(string email)
        {
            this.email = email;
        }

        public Customer_infoDTO(string name,string email, string password,string address,string phoneno)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.address = address;
            this.phoneno = phoneno;
        }


        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        public string PHONENO
        {
            get { return phoneno; }
            set { phoneno = value; }
        }
    }
}