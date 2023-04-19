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
using System.Windows.Forms;
using System.Security.Cryptography;

namespace cafeManagement.BUS
{
    public class AccountBUS
    {

        public AccountBUS() { }
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return instance; }
            private set { instance = value; }
        }
        public void LoadAllAccount(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = DAO.AccountDAO.Instance.LoadAllAccount();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        public void LoadAccountBySearch(DataGridView dataGridView1,string textBoxText)
        {
            dataGridView1.DataSource = DAO.AccountDAO.Instance.LoadAccountBySearch(textBoxText);
        }
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        public bool CheckAdministator(string userName)
        {
            return AccountDAO.Instance.CheckAdministator(userName);
        }
        public string GetUserDisplayName(string userName)
        {
            return AccountDAO.Instance.GetUserDisplayName(userName);

        }
        public int EditAccount(string userName, string newUserName, string displayname, string password, int type)
        {
            return AccountDAO.Instance.Edit_Account(userName, newUserName, displayname, password, type);
        }

        public int AddAccount(string userAccount, string displayName, string password, string accountType)
        {
            return AccountDAO.Instance.AddAccount(userAccount, displayName, password, accountType);
        }
        public int DeleteAccount(string a)
        {
            return AccountDAO.Instance.Delete_Account(a);
        }
    }

}