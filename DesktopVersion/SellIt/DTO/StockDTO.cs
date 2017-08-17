using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellIt
{
    class StockDTO
    {
        private string item_name, type, rest_item, selling_price, purhase_price, weight, barcode,id;

        //necessary constractors
        public StockDTO(string item_name, string type, string rest_item, string selling_price, string purhase_price, string weight, string barcode)
        {
            this.item_name = item_name;
            this.type = type;
            this.rest_item = rest_item;
            this.selling_price = selling_price;
            this.purhase_price = purhase_price;
            this.weight = weight;
            this.barcode = barcode;
        }
        //this constructor for update 
        public StockDTO(string item_name, string type, string rest_item, string selling_price, string purhase_price, string weight, string barcode, string id)
        {
            this.item_name = item_name;
            this.type = type;
            this.rest_item = rest_item;
            this.selling_price = selling_price;
            this.purhase_price = purhase_price;
            this.weight = weight;
            this.barcode = barcode;
            this.id = id;
        }

        //getters and setters
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string ITEM_NAME
        {
            get { return item_name; }
            set { item_name = value; }
        }
        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }
        public string REST_ITEM
        {
            get { return rest_item; }
            set { rest_item = value; }
        }
        public string SELLING_PRICE
        {
            get { return selling_price; }
            set { selling_price = value; }
        }
        public string PURHASE_PRICE
        {
            get { return purhase_price; }
            set { purhase_price = value; }
        }
        public string WEIGHT
        {
            get { return weight; }
            set { weight = value; }
        }
        public string BARCODE
        {
            get { return barcode; }
            set { barcode = value; }
        }
    }
}
