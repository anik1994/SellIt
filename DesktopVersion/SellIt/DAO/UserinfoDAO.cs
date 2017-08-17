using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace SellIt
{
    class UserinfoDAO
    {
        //to getting connection string
        private MySqlConnection connection;
        ConnectorDB dbObj= new ConnectorDB();

        //add admin
        public void AddUser(UserinfoDTO userinfodto)
        {
            dbObj.OpenConnection();
            string query = "Insert into userinfo (name, user_name, password, account_type, age, address, phone_no, salary) values ('"+
                userinfodto.NAME + "', '" + userinfodto.USER_NAME +"' , '"+
                encryption(userinfodto.PASSWORD) + "', '" + userinfodto.ACCOUNT_TYPE +"' , '"+
                userinfodto.AGE + "', '" + userinfodto.ADDRESS +"' , '"+
                userinfodto.PHONE_NO + "', '" + userinfodto.SALARY + "')";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();
            dbObj.CloseConnection();
        }

        //delete User
        public void DeleteUser(string id)
        {
            dbObj.OpenConnection();
            string query = " delete from userinfo where user_id= " + id;

            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();

            dbObj.CloseConnection();
        }
        //update user
        public void UpdateUser(UserinfoDTO userinfodto)
        {
            dbObj.OpenConnection();
            string query = "update userinfo set name = '" + userinfodto.NAME + 
                "', user_name = '"+userinfodto.USER_NAME+"', password = '"+userinfodto.PASSWORD+"', age ='"+userinfodto.AGE+
                "', address = '"+userinfodto.ADDRESS+"', phone_no = '"+userinfodto.PHONE_NO+"', salary ='"+userinfodto.SALARY+"' where user_id= '" + userinfodto.ID +"';";
            MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
            cmd.ExecuteNonQuery();

            dbObj.CloseConnection();
        }
        //method for checking password
        public int GetLoginInfo(UserinfoDTO userinfodto)
        {
            string query = "SELECT Count(*) FROM userinfo WHERE user_name='" + userinfodto.USER_NAME + "' AND password='" + encryption(userinfodto.PASSWORD) + "' AND account_type = '"+ userinfodto.ACCOUNT_TYPE+"'";
            int count = -1;

            if (dbObj.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
                count = int.Parse(cmd.ExecuteScalar() + "");

                dbObj.CloseConnection();

                return count;
            }
            else
            {
                return count;
            }
        }

        //reset password
        public void ResetPass(UserinfoDTO userinfodto)
        {
            string query = "Update userinfo set password = '" + encryption(userinfodto.PASSWORD) + "' where user_name = '" + userinfodto.USER_NAME + "';";

            if (dbObj.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbObj.connection);
                cmd.ExecuteNonQuery();
                dbObj.CloseConnection();
            }
            else
            {
                Console.WriteLine("Password cant be update due to connection problem");
            }
        }

        //for loding admin grid view
        public DataSet GetAdmins()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from userinfo where account_type = 'admin'";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, dbObj.connection);

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            dbObj.CloseConnection();

            return dataSet;

        }
        //for loding chashier grid view
        public DataSet GetCashier()
        {
            dbObj.OpenConnection();
            string sqlQuery = "select * from userinfo where account_type = 'cashier'";
            MySqlCommand cmd = new MySqlCommand(sqlQuery, dbObj.connection);

            MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            dbObj.CloseConnection();

            return dataSet;

        }

        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
