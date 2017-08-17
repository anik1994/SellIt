using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SellIt
{
    class StockDAO
    {
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter sqlAdapter;
        private DataSet dataSet;

        //to getting connection string
        private MySqlConnection connection;
        ConnectorDB dbObj = new ConnectorDB();
        
        //for the customer list
        /*public DataSet GetCustomers()
        {
            dbObj.OpenConnection();
            string sqlQuery = "SELECT * FROM `customer_info`";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;
        }*/
        //for the order list
        /*public DataSet GetOrders()
        {
            dbObj.OpenConnection();
            string sqlQuery = "SELECT * FROM `order_tbl`";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;
        }*/
        //for selling product(minus from stock)
        public void SellProduct(string barcode, string quantity)
        {
            dbObj.OpenConnection();
            string query = "UPDATE `stock` SET `rest_item`='" + quantity + "'  WHERE barcode = '" + barcode + "';";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();

            dbObj.CloseConnection();
        }
        //for searching
        public DataSet GetList(string search)
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from stock where item_name like '"+search+"%';";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;
        }
        //method for insert products
        public void InsertProducts(StockDTO stockDto)
        {
            dbObj.OpenConnection();
            string query = "INSERT INTO `stock`(`item_name`, `rest_item`, `selling_price`, `purhase_price`, `type`, `weight`, `barcode`) VALUES ('"+
                stockDto.ITEM_NAME+"','"+stockDto.REST_ITEM+"','"+stockDto.SELLING_PRICE+"','"+stockDto.PURHASE_PRICE+"','"+
                stockDto.TYPE+"','"+stockDto.WEIGHT+"','"+stockDto.BARCODE+"');";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();
            dbObj.CloseConnection();
        }
        //method for delete products
        public void DeleteProducts(string id)
        {
            dbObj.OpenConnection();
            string query = "delete from stock where item_id= " + id;
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();

            dbObj.CloseConnection();
        }
        //mothod for update products
        public void UpdateProducts(StockDTO stockDto)
        {
            dbObj.OpenConnection();
            string query = "UPDATE `stock` SET `item_name`='"+stockDto.ITEM_NAME+"',`rest_item`='"+stockDto.REST_ITEM+"',`selling_price`='"+
                stockDto.SELLING_PRICE+"',`purhase_price`='"+stockDto.PURHASE_PRICE+"',`type`='"+stockDto.TYPE
                +"',`weight`='"+stockDto.WEIGHT+"',`barcode`='"+stockDto.BARCODE+"'  WHERE item_id = '"+stockDto.ID+"';";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();

            dbObj.CloseConnection();
        }
        //method for productlist
        public DataSet GetProductList()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from stock join vat_informer on stock.type=vat_informer.type";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;

        }
        //for product list in products
        public DataSet GetProducts()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from stock";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;

        }
        //for products drop downlist
        public DataSet GetTypes()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select type from vat_informer";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;

        }
    }
}
