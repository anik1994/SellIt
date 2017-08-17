using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellIt
{
    
    class SelltblDTO
    {
        string products, quantity, amount, vat, totalAmount, dateTime;
        public SelltblDTO(string products,string quantity,string amount,string vat,string totalAmount,string dateTime)
        {
            this.products = products;
            this.quantity = quantity;
            this.amount = amount;
            this.vat = vat;
            this.totalAmount = totalAmount;
            this.dateTime = dateTime;
        }
        public string PRODUCTS
        {
            get { return products; }
            set { products = value; }
        }
        public string QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
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
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public string DATETIME
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}
