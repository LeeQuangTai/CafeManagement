using cafeManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.BUS
{
    public class MenuBUS
    {
        private static MenuBUS instance;

        public static MenuBUS Instance
        {
            get { if (instance == null) instance = new MenuBUS(); return MenuBUS.instance; }
            private set { MenuBUS.instance = value; }
        }

        private MenuBUS() { }
        public void GetListDrink(DataGridView dgv)
        {
            dgv.DataSource = DrinkDAO.Instance.GetListDrink();
        }
        public void loadSearch(DataGridView dgv, string varQuery)
        {
            string query = "Select * from dbo.Drink where DrinkName like  N'%" + varQuery + "%' or DrinkCategoryID like N'%" + varQuery + "%'";
            try
            {
                dgv.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

    }
}
