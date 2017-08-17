using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace SellIt
{
    class VatinfoDAO
    {
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter sqlAdapter;
        private DataSet dataSet;

        //to getting connection string
        private MySqlConnection connection;
        ConnectorDB dbObj = new ConnectorDB();

        //method for insert vat and type
        public void InsertItem(VatinfoDTO vatinfoDto)
        {
            dbObj.OpenConnection();
            string query = "INSERT INTO `vat_informer`(`type`, `vat`) VALUES ('"+vatinfoDto.TYPE+"','"+vatinfoDto.VAT+"');";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();
            dbObj.CloseConnection();
        }
        
        //method for vatlist
        public DataSet GetVatList()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from vat_informer";
            sqlCommand = new MySqlCommand(sqlQuery, dbObj.connection);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);
            dbObj.CloseConnection();

            return dataSet;

        }
    }
}
