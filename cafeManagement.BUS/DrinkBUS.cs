using cafeManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.BUS
{
    public class DrinkBUS
    {
        private static DrinkBUS instance;
        public static DrinkBUS Instance
        {
            get { if (instance == null) instance = new DrinkBUS(); return DrinkBUS.instance; }
            private set { DrinkBUS.instance = value; }
        }

        private DrinkBUS() { }
        public void loadDM(ComboBox cbb)
        {
            string query = "select * from dbo.DrinkCategory";
            cbb.DataSource = DrinkDAO.Instance.getData(query);
            cbb.DisplayMember = "DrinkCategoryName";
            cbb.ValueMember = "DrinkCategoryID";
        }
        public int addSP(string id, string ten, string danhmuc, int gia )
        {
            return DrinkDAO.Instance.addSP(id, ten, danhmuc, gia);
        }


    }
}
