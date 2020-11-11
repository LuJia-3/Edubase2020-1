using SmartLinli.DatabaseDevelopement;
using System;
using System.Windows.Forms;

namespace SignUp
{
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
            this.AcceptButton = this.btn_SignUp;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string commandText =
                $@"INSERT tb_Student(No,Password)
					VALUES
					('{this.txb_Name.Text.Trim()}','{this.txb_Password.Text.Trim()}');";
            SqlHelper sqlHelper = new SqlHelper();
            int rowAffected = sqlHelper.QuickSubmit(commandText);
            if (rowAffected == 1)
            {
                MessageBox.Show("注册成功!");
            }
            else
            {
                MessageBox.Show("注册失败！");
            }
        }
    }
}
