using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SellIt
{
    class UserinfoDTO
    {
        private string id, name, user_name, password, account_type, address, phone_no;
        private int age;
        private double salary;

        //necessary constractors
        public UserinfoDTO(string name, string user_name, string password, string account_type, string address, string phone_no, int age, double salary)
        {
            //for add an admin
            this.name = name; 
            this.user_name = user_name;
            this.password = password;
            this.account_type = account_type;
            this.address = address;
            this.phone_no = phone_no;
            this.age = age;
            this.salary = salary;
        }
        public UserinfoDTO(string name, string user_name, string password, string account_type, string address, string phone_no, int age, double salary, string id)
        {
            //for update an admin
            this.name = name;
            this.user_name = user_name;
            this.password = password;
            this.account_type = account_type;
            this.address = address;
            this.phone_no = phone_no;
            this.age = age;
            this.salary = salary;
            this.id = id;
        }
        public UserinfoDTO(string user_name, string password, string account_type)
        {
            //this constructor for login
            this.user_name = user_name;
            this.password = password;
            this.account_type = account_type;
        }
        public UserinfoDTO(string user_name, string password)
        {
            //this constructor for reset password
            this.user_name = user_name;
            this.password = password;
        }
        
        
        //getters and setters are starting from here
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public string USER_NAME
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public string ACCOUNT_TYPE
        {
            get { return account_type; }
            set { account_type = value; }
        }
        public string ADDRESS
        {
            get { return address; }
            set { address = value; }
        }
        public string PHONE_NO
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public double SALARY
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
