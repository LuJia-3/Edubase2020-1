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
    public partial class frm_EduSystem : Form
    {
        public frm_EduSystem()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_StudentNo_TextChanged(object sender, EventArgs e)
        {
            string commandText =
               $"SELECT * FROM tb_Student WHERE No='{this.txb_StudentNo}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_StudentNo.Text = sqlHelper["No"].ToString();
            }
        }

        private void txb_StudentName_TextChanged(object sender, EventArgs e)
        {
            string commandText =
               $"SELECT * FROM tb_Student WHERE Name='{this.txb_StudentName}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_StudentName.Text = sqlHelper["Name"].ToString();
            }
        }

        private void txb_Gender_TextChanged(object sender, EventArgs e)
        {
            string commandText =
               $"SELECT * FROM tb_Student WHERE Gender='{this.txb_Gender}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_Gender.Text = sqlHelper["Gender"].ToString();
            }
        }

        private void txb_Class_TextChanged(object sender, EventArgs e)
        {
            string commandText =
               $"SELECT * FROM tb_Student WHERE Class='{this.txb_Class}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_Class.Text = sqlHelper["Class"].ToString();
            }

        }

        private void txb_BirthDate_TextChanged(object sender, EventArgs e)
        {
            string commandText =
               $"SELECT * FROM tb_Student WHERE BirthDate='{this.txb_BirthDate}';";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.QuickRead(commandText);
            if (sqlHelper.HasRecord)
            {
                this.txb_BirthDate.Text = ((DateTime)sqlHelper["BirthDate"]).ToShortDateString();
            }
        }
    }
}


