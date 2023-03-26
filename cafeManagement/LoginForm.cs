using cafeManagement.Resource.BUS;
using cafeManagement.Resource.DAO;
using System;
using System.Windows.Forms;

namespace cafeManagement
{
    public partial class LoginForm : ViewForm
    {
        public bool isAllowToAccess;
        public override FormType FormType => FormType.Login;
        public LoginForm()
        {
            InitializeComponent();
        }
      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            userNameTxt.Focus();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string passWord = passwordTxt.Text;
            if (Login(userName, passWord))
            {
                isAllowToAccess = true;
                Program.SwitchFormType(FormType.Control);
                //this.Close();
                this.userNameTxt.Clear();
                this.passwordTxt.Clear();
                this.userNameTxt.Focus();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            }
        }

        private void userNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                passwordTxt.Focus();
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }

        


    }
}
