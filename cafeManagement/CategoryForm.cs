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
using System.Text.RegularExpressions;
using cafeManagement.BUS;

namespace cafeManagement
{
    public partial class CategoryForm : Form
    {
        static bool isOpened = false;
        public CategoryForm()
        {
            InitializeComponent();
           // this.MouseClick += mouse_click;
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            
                if (!this.ClientRectangle.Contains(e.Location))
                {
                    // Click occurred outside of the form's client area, ignore it
                    return;
                }

                // Handle the click event within the form's client area
                // ...
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (convertToUnSign3(IDtxt.Text) == "" || nameTxt.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {
                CategoryBUS.Instance.addM(convertToUnSign3(IDtxt.Text), nameTxt.Text);
                Load_Category();
                MessageBox.Show("Thêm thành công");
            }
        }
        private void Load_Category()
        {

            if (!isOpened)

                isOpened = true;

            else
                this.Dispose();
            CategoryBUS.Instance.GetDrinkCategories(dataGridView1);
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
            if (!LoginForm.isAdministrator)
            {
                bunifuButton1.Enabled = false;
            }
            else
                bunifuButton1.Enabled = true;

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
        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            if (isOpened)
            {
                isOpened = false;
            }
        }
    }
}
