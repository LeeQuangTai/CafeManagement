using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace cafeManagement.DTO
{
    internal class Account
    {
        public Account() { }
        public Account(string userName,string password,string displayName, int type) 
        {
            UserName = userName;
            Password = password;
            DisplayName = displayName;
            Type = type;
        }
        public Account(DataRow data)
        {
            UserName = data["userName"].ToString();
            Password = data["password"].ToString();
            DisplayName = data["displayName"].ToString();
            Type = int.Parse(data["type"].ToString());
        }
        string userName;
        string password;
        string displayName;
        int type;

        public string UserName
        {
            get{ return userName; }
            set { userName = value; }
        } 
        public string Password
        {
            get { return password; }   
            set { password = value; }
        }
        public int Type
        {
            get { return type; }   
            set { type = value; }
        }
        public string DisplayName
        {
            get { return displayName; } 
            set
            {
                displayName = value;
            }
        }
    }
}
