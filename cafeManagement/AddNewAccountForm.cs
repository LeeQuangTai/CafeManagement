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
namespace cafeManagement
{
    public partial class AddNewAccountForm : Form
    {
        public AddNewAccountForm()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == ""|| bunifuTextBox2.Text == "" ||bunifuTextBox3.Text == ""||comboBox1.Text=="")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else if (AccountDAO.Instance.addAccount(bunifuTextBox1.Text, bunifuTextBox3.Text, bunifuTextBox2.Text, (comboBox1.Text == "Admin" ? 1 : 2).ToString()) > 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!");

            }
        } 
    }
}

