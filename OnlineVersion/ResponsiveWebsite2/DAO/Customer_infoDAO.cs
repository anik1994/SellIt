using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace ResponsiveWebsite2
{

    public class Customer_infoDAO
    {
        DBConnect dbconnect = new DBConnect();
        private MySqlDataAdapter mysqlAdapter;
        private DataSet dataSet;

        //Constructor
        public Customer_infoDAO()
        {
            
        }

        public int GetLoginInfo(Customer_infoDTO customer_infodto)
        {
            string query = "SELECT Count(*) FROM customer_info WHERE email='" + customer_infodto.EMAIL + "' AND password='" + customer_infodto.PASSWORD + "'";
            int count = -1;

            if (dbconnect.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);
                count = int.Parse(cmd.ExecuteScalar() + "");

                dbconnect.CloseConnection();

                return count;
            }
            else
            {
                return count;
            }
        }

        public void CreateCustomer(Customer_infoDTO customer_infodto)
        {
            string query = "INSERT INTO customer_info (name, email, password, address, phone_no) VALUES('" + customer_infodto.NAME + "','"
                                                            + customer_infodto.EMAIL + "','"
                                                            + customer_infodto.PASSWORD + "','"
                                                            + customer_infodto.ADDRESS +  "','"
                                                            + customer_infodto.PHONENO +  "')";

            //open connection
            if (dbconnect.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, dbconnect.connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                dbconnect.CloseConnection();
            }
        }

        public DataSet getSingleItem(Customer_infoDTO customer_infodto)
        {

            string query = "SELECT * FROM customer_info WHERE email='" + customer_infodto.EMAIL + "'";

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