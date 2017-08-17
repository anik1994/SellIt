using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using ResponsiveWebsite2.DTO;

namespace ResponsiveWebsite2.DAO
{
    public class Order_tblDAO
    {
        DBConnect dbconnect = new DBConnect();

        //Constructor
        public Order_tblDAO()
        {
            
        }

        public void CreateOrder(Order_tblDTO order_tbldto)
        {
            string delivered = "NO";
            string query = "INSERT INTO order_tbl (cus_name, address, phn_no, item_name, item_quan,amount,vat,total_amount,delivered) VALUES('" + order_tbldto.CUS_NAME + "','"
                                                            + order_tbldto.ADDRESS + "','"
                                                            + order_tbldto.PHN_NO + "','"
                                                            + order_tbldto.ITEM_NAME + "','"
                                                            + order_tbldto.ITEM_QUAN + "','"
                                                            + order_tbldto.AMOUNT + "','"
                                                            + order_tbldto.VAT + "','"
                                                            + order_tbldto.TOTAL_AMOUNT + "','"
                                                            + delivered + "')";

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
    }
}