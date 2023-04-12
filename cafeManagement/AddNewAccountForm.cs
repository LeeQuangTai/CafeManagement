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
using cafeManagement.BUS;
namespace cafeManagement
{
    public partial class AddNewAccountForm : Form
    {
        private bool isOpened = false;

        public AddNewAccountForm()
        {
            InitializeComponent();
        }
        void onLoad()
        {
            if (!isOpened)

                isOpened = true;

            else
            {
                isOpened = false;
                this.Dispose();
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (userNametxt.Text == ""|| passTxt.Text == "" ||displayNameTxt.Text == ""||typeCbbx.Text=="")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else if (AccountBUS.Instance.AddAccount(userNametxt.Text, displayNameTxt.Text, passTxt.Text, (typeCbbx.Text == "Admin" ? 1 : 2).ToString()) > 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!");

            }
        }

        private void AddNewAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
       
            if (isOpened)
            {
                isOpened = false;
            }
            
        }
    }
}

