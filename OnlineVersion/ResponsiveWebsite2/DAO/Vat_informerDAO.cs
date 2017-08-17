using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using ResponsiveWebsite2.DTO;

namespace ResponsiveWebsite2.DAO
{
    public class Vat_informerDAO
    {
        DBConnect dbconnect = new DBConnect();
        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        //Constructor
        public Vat_informerDAO()
        {
            
        }

        public DataSet getVat(Vat_informerDTO vat_informerdto)
        {
            
            string query = "SELECT * FROM vat_informer where type='" + vat_informerdto.TYPE + "'";

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
    }
}