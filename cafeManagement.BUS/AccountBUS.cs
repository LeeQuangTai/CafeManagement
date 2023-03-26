using cafeManagement.DAO;
using cafeManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Security.Cryptography;

namespace cafeManagement.BUS
{
    public class AccountBUS
    {

        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        public AccountBUS() { }
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        //public int EditAccount(string userName, string newUserName, string displayname, string password, int type)
        //{
        //    return AccountDAO.Instance.EditAccount(userName, newUserName, displayname, password, type);
        //}

        //public int AddAccount(string userAccount, string displayName, string password, string accountType)
        //{
        //    return AccountDAO.Instance.addAccount(userAccount, displayName, password, accountType);
        //}
        //public int DeleteAccount(string a)
        //{
        //    return AccountDAO.Instance.DeleteAccount(a);
        //}
    }

}