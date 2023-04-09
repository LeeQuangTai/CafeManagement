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
using cafeManagement.Resource.DAO;
using System.Text.RegularExpressions;

namespace cafeManagement
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (convertToUnSign3(IDtxt.Text) == "" || nameTxt.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {
                DrinkDAO.Instance.addM(convertToUnSign3(IDtxt.Text), nameTxt.Text);
                Load_Category();
                MessageBox.Show("Thêm thành công");
            }
        }
        private void Load_Category()
        {
            dataGridView1.DataSource = DrinkCategoryDAO.Instance.GetDrinkCategories();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Load_Category();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
