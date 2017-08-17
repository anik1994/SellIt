using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResponsiveWebsite2
{
    public class StockDTO
    {
        private int item_id,quantity;
        private string barcode;

        public StockDTO(string barcode)
        {
            this.barcode = barcode;
        }

        public StockDTO(string barcode,int quantity)
        {
            this.barcode = barcode;
            this.quantity = quantity;
        }

        public int ITEM_ID
        {
            get { return item_id; }
            set { item_id = value; }
        }
        public string BARCODE
        {
            get { return barcode; }
            set { barcode = value; }
        }

        public int QUANTITY
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}