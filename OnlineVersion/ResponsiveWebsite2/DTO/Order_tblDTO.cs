using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveWebsite2.DTO
{
    public class Order_tblDTO
    {
        private string cus_name,address,phn_no,item_name,item_quan,amount,vat,total_amount;

        public Order_tblDTO(string cus_name,string address,string phn_no,string item_name,string item_quan,string amount,string vat,string total_amount)
        {
            this.cus_name = cus_name;
            this.address = address;
            this.phn_no = phn_no;
            this.item_name = item_name;
            this.item_quan = item_quan;
            this.amount = amount;
            this.vat = vat;
            this.total_amount = total_amount;
        }

        public string CUS_NAME
        {
            get { return cus_name; }
            set { cus_name = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        public string PHN_NO
        {
            get { return phn_no; }
            set { phn_no = value; }
        }
        public string ITEM_NAME
        {
            get { return item_name; }
            set { item_name = value; }
        }
        public string ITEM_QUAN
        {
            get { return item_quan; }
            set { item_quan = value; }
        }
        public string AMOUNT
        {
            get { return amount; }
            set { amount = value; }
        }
        public string VAT
        {
            get { return vat; }
            set { vat = value; }
        }
        public string TOTAL_AMOUNT
        {
            get { return total_amount; }
            set { total_amount = value; }
        }
    }
}