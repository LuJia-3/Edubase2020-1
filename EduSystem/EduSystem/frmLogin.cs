using System;
using SmartLinli.Developement;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
    }
}
