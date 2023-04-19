using cafeManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeManagement.BUS
{
    public class CategoryBUS
    {
        private static CategoryBUS instance;
        public static CategoryBUS Instance
        {
            get { if (instance == null) instance = new CategoryBUS(); return CategoryBUS.instance; }
            private set { CategoryBUS.instance = value; }
        }

        private CategoryBUS() { }
        public void addM(string id, string ten)
        {
            DrinkDAO.Instance.addM(id, ten);
        }
        public void GetDrinkCategories(DataGridView dgv)
        {
            dgv.DataSource = DrinkCategoryDAO.Instance.GetDrinkCategories();
        }
    }
}
