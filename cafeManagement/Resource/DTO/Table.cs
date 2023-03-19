using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafeManagement.Resource.DTO
{
    public class Table
    {
        private string tableID;
        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        private string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Table(string tableID, string tableName, string status)
        {
            this.TableID = tableID;
            this.TableName = tableName;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.TableID = row["tableID"].ToString();
            this.TableName = row["tableName"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
