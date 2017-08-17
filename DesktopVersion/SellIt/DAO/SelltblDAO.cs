using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SellIt
{
    class SelltblDAO
    {
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter sqlAdapter;
        private DataSet dataSet;

        //to getting connection string
        private MySqlConnection connection;
        ConnectorDB dbObj = new ConnectorDB();

        DataTable maxValue;

        public void Insert(SelltblDTO sellDTO)
        {
            dbObj.OpenConnection();
            string query = "INSERT INTO `sell_tbl`(`products`, `quantity`, `amount`, `vat`, `totalAmount`, `dateTime`) VALUES ('"+
                sellDTO.PRODUCTS + "','"+sellDTO.QUANTITY+"','"+sellDTO.AMOUNT+"','"+sellDTO.VAT+"','"+sellDTO.TOTAL_AMOUNT+
                "','"+sellDTO.DATETIME+"')";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();
            dbObj.CloseConnection();
        }
        public string getReceiptNumber()
        {
            dbObj.OpenConnection();
            string sqlQuery = "SELECT MAX(sell_id) AS max from sell_tbl;";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            maxValue = dataSet.Tables[0];
            string max="";
            foreach (DataRow dr in maxValue.Rows)
            {
                max = dr["max"].ToString();
            }

            return max;
        }
    }
}
