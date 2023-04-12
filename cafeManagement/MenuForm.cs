using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using cafeManagement.BUS;
using cafeManagement.DAO;
namespace cafeManagement
{
    public partial class MenuForm : Form
    {
        private List<Bunifu.UI.WinForms.BunifuButton.BunifuButton> administratorButtons = new List<Bunifu.UI.WinForms.BunifuButton.BunifuButton>();
        public MenuForm()
        {
            InitializeComponent();
            administratorButtons.Add(btThemMH);
        }

        private void MenuForm_Load(object sender, System.EventArgs e)
        {
            if (!LoginForm.isAdministrator)
            {
                foreach (var button in administratorButtons)
                {
                    button.Enabled = false;
                }
            }
            else
                foreach (var button in administratorButtons)
                {
                    button.Enabled = true;
                }
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
            string query = "Select * from dbo.Drink where DrinkName like  N'%" + varQuery + "%' or DrinkCategoryID like N'%"+ varQuery + "%'";
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