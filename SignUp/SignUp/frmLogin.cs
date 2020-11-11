using System;
using SmartLinli.DatabaseDevelopement;
using System.Windows.Forms;

namespace SignUp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_Login;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"SELECT 1 
					FROM tb_Student
					WHERE No='{this.txb_Name.Text.Trim()}' AND Password='{this.txb_Password.Text.Trim()}';";
            SqlHelper sqlHelper = new SqlHelper();
            int result = sqlHelper.QuickReturn<int>(commandText);
            if (result == 1)
            {
                MessageBox.Show("登录成功!");
            }
            else
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
        }
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frm_SignUp signUpForm = new frm_SignUp();
            signUpForm.ShowDialog();
        }
    }
}
