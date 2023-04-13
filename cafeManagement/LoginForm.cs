using cafeManagement.BUS;
using cafeManagement.DTO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cafeManagement
{
    public partial class LoginForm : ViewForm
    {
        public bool isAllowToAccess;
        public static bool isAdministrator;
        public static string user;
        public static Form loginForm;
        public override FormType FormType => FormType.Login;
        public LoginForm()
        {
            InitializeComponent();
            loginForm = this;
        }
      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            userNameTxt.Focus();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

      
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string passWord = passwordTxt.Text;
            user = userNameTxt.Text;
            if (AccountBUS.Instance.Login(userName, passWord))
            {
                isAllowToAccess = true;
                isAdministrator = AccountBUS.Instance.CheckAdministator(userName);
               // Program.SwitchFormType(FormType.Control);
                //this.Close();
                this.userNameTxt.Clear();
                this.passwordTxt.Clear();
                this.userNameTxt.Focus();

                ControlForm control = new ControlForm();
                control.Show();
                this.Hide();
                //control.SignOut += ThisSignOut;
                
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            }
        }

        private void ThisSignOut(object sender,  EventArgs e)
        {
            (sender as ControlForm).isSignOut = false;
            (sender as ControlForm).Close();
            this.Show(); 
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

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
        //protected override void OnShown(EventArgs e)
        //{
        //    base.OnShown(e);
        //    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
        //}
        //public override void OnHide()
        //{
        //    base.OnHide();
        //    this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
        //}

    }
}
