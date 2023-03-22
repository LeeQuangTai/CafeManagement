using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using cafeManagement.Resource.DAO;
namespace cafeManagement
{
    public partial class EditAccountForm : Form
    {
        public EditAccountForm()
        {
            InitializeComponent();
        }

        

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Account account = new Account(userNameCbb.Text, passwordTxt.Text, displayNameTxt.Text, typecbb.Text == "Admin" ? 1 : 2);
            if (MessageBox.Show("Bạn đã chắc chắn?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (passwordTxt.Text == "" || displayNameTxt.Text == "" || newUserNametxt.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống!");
                }
                else
                {
                    if (AccountDAO.Instance.EditAccount(account.UserName, newUserNametxt.Text,account.DisplayName,account.Password,account.Type) > 0 ? true : false)
                        MessageBox.Show("Chỉnh sửa hành công!");
                    else
                        MessageBox.Show("Chỉnh sứa thất bại!");
                }
            }
        }

        private void onLoad(object sender, EventArgs e)
        {
            var data = DataProvider.Instance.ExecuteQuery("select userName from dbo.account");
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account();
                account.UserName = item[0].ToString();
                userNameCbb.Items.Add(account.UserName);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
