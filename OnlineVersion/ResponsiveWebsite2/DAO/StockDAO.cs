using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;


namespace ResponsiveWebsite2
{
    public class StockDAO
    {
        DBConnect dbconnect = new DBConnect();

        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        //Constructor
        public StockDAO()
        {

        }

        public DataSet getAllChocolates(string type)
        {
            //string type = "Chocolate";
            string query = "SELECT * FROM stock where type='" + type + "'";

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                mysqlAdapter = new MySqlDataAdapter(cmd);
                dataSet = new DataSet();
                mysqlAdapter.Fill(dataSet);

                dbconnect.CloseConnection();

                return dataSet;
            }
            else
            {
                return dataSet;
            }
        }

        public DataSet getSingleItem(StockDTO stockdto)
        {

            string query = "SELECT * FROM stock WHERE barcode='" + stockdto.BARCODE + "'";

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                mysqlAdapter = new MySqlDataAdapter(cmd);
                dataSet = new DataSet();
                mysqlAdapter.Fill(dataSet);

                dbconnect.CloseConnection();

                return dataSet;
            }
            else
            {
                return dataSet;
            }
        }

        public void UpdateStock(StockDTO stockdto)
        {

            //string query = "SELECT * FROM stock WHERE item_id='" + stockdto.ITEM_ID + "'";
            string query = "UPDATE stock SET rest_item='" + stockdto.QUANTITY + "' WHERE barcode = " + stockdto.BARCODE + "";

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);
                cmd.ExecuteNonQuery();
                dbconnect.CloseConnection();              
            }
        }
    }
}