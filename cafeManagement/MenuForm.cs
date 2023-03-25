using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using cafeManagement.Resource.DAO;
using cafeManagement.Resource.DTO;
namespace cafeManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            dtwMenu.DataSource = DrinkDAO.Instance.GetListDrink();
            for (int i = 0; i < dtwMenu.ColumnCount; i++)
            {
                dtwMenu.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void bunifuButton3_Click(object sender, System.EventArgs e)
        {
            Form category = new CategoryForm();
            category.Show();
            //  var control = Application.OpenForms.Cast<ControlForm>().Last(); // using LINQ 
        }

        private void bunifuButton2_Click(object sender, System.EventArgs e)
        {
            Form addNew = new AddNewObject();
            addNew.Show();
        }

        private void btTimKiem_Click(object sender, System.EventArgs e)
        {
            loadSearch(txtSearch.Text);
        }

        private void loadSearch(string varQuery)
        {
            string query = "Select * from dbo.Drink where DrinkName like  '%" + varQuery + "%' or DrinkCategoryID like '%"+ varQuery + "%'";
            try
            {
                dtwMenu.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadSearch(txtSearch.Text);
            }
        }
    }
}