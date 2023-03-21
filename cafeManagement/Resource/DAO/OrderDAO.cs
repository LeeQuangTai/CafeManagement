using cafeManagement.Resource.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cafeManagement.Resource.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return OrderDAO.instance; }
            private set { OrderDAO.instance = value; }
        }

        private OrderDAO() { }
        public List<Order> GetListOrderByTable(string tableID)
        {
            List<Order> orders = new List<Order>();
            string query = "exec sp_GetListOrderByTable @TableID , 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {tableID});
            foreach (DataRow item in data.Rows)
            {
                Order order = new Order(item);
                orders.Add(order);
            }

            return orders;
        }
    }
}
