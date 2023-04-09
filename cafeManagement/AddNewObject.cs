using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using cafeManagement.DAO;

namespace cafeManagement
{
    public partial class AddNewObject : Form
    {
        public AddNewObject()
        {
            InitializeComponent();
        }

        public void loadDM()
        {
            string query = "select * from dbo.DrinkCategory";
            cbDanhMuc.DataSource = DAO.DrinkDAO.Instance.getData(query);
            cbDanhMuc.DisplayMember = "DrinkCategoryName";
            cbDanhMuc.ValueMember = "DrinkCategoryID";
        }
        private void AddNewObject_Load(object sender, EventArgs e)
        {

            loadDM();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifu_ID_Mon.Text == "" || bunifu_Ten_Mon.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {

                if (DrinkDAO.Instance.addSP(bunifu_ID_Mon.Text, bunifu_Ten_Mon.Text, cbDanhMuc.Text, int.Parse(DonGiaTxt.Text)) > 0);
                {
                    MessageBox.Show("Thêm thành công");

                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifu_ID_Mon_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifu_Ten_Mon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
