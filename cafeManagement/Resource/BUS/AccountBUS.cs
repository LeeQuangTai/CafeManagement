using cafeManagement.Resource.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.Resource.BUS
{
    internal class AccountBUS
    {
        public AccountBUS() { }
        private static AccountBUS instance;
        public static AccountBUS Instance 
        { 
            get { if (instance != null) instance = new AccountBUS(); return instance; } set { instance = value; }        
        }
        public bool Login(string userName, string passWord)
        {
            return false;
        }

        public int EditAccount(string userName, string newUserName, string displayname, string password, int type)
        {
            return 1;
        }

        public void AddAccount(string userAccount, string displayName, string password, string accountType)
        {
        }
        public int DeleteAccount(string a)
        {
            return  -1;
        }
    }

}