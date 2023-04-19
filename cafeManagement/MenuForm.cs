using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using cafeManagement.BUS;
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
            MenuBUS.Instance.GetListDrink(dtwMenu);
            for (int i = 0; i < dtwMenu.ColumnCount; i++)
            {
                dtwMenu.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void bunifuButton3_Click(object sender, System.EventArgs e)
        {
            Form category = new CategoryForm();
            category.ShowDialog();    
            //  var control = Application.OpenForms.Cast<ControlForm>().Last(); // using LINQ 
        }

        private void bunifuButton2_Click(object sender, System.EventArgs e)
        {
            Form addNew = new AddNewObject();
            addNew.ShowDialog();
        }

        private void btTimKiem_Click(object sender, System.EventArgs e)
        {
            MenuBUS.Instance.loadSearch(dtwMenu, txtSearch.Text);
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MenuBUS.Instance.loadSearch(dtwMenu, txtSearch.Text);
            }
        }

        private void dtwMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}