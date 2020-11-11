namespace StudentInformation
{
    partial class frm_StudentInfo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_StudentNo = new System.Windows.Forms.Label();
            this.lab_Class = new System.Windows.Forms.Label();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.lab_BirthDate = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_StudentNo = new System.Windows.Forms.TextBox();
            this.txb_Class = new System.Windows.Forms.TextBox();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.txb_BirthDate = new System.Windows.Forms.TextBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(33, 47);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(37, 15);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "姓名";
            // 
            // lab_StudentNo
            // 
            this.lab_StudentNo.AutoSize = true;
            this.lab_StudentNo.Location = new System.Drawing.Point(33, 99);
            this.lab_StudentNo.Name = "lab_StudentNo";
            this.lab_StudentNo.Size = new System.Drawing.Size(37, 15);
            this.lab_StudentNo.TabIndex = 1;
            this.lab_StudentNo.Text = "学号";
            // 
            // lab_Class
            // 
            this.lab_Class.AutoSize = true;
            this.lab_Class.Location = new System.Drawing.Point(33, 155);
            this.lab_Class.Name = "lab_Class";
            this.lab_Class.Size = new System.Drawing.Size(37, 15);
            this.lab_Class.TabIndex = 2;
            this.lab_Class.Text = "班级";
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.Location = new System.Drawing.Point(274, 47);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(37, 15);
            this.lab_Gender.TabIndex = 3;
            this.lab_Gender.Text = "性别";
            // 
            // lab_BirthDate
            // 
            this.lab_BirthDate.AutoSize = true;
            this.lab_BirthDate.Location = new System.Drawing.Point(274, 99);
            this.lab_BirthDate.Name = "lab_BirthDate";
            this.lab_BirthDate.Size = new System.Drawing.Size(37, 15);
            this.lab_BirthDate.TabIndex = 4;
            this.lab_BirthDate.Text = "生日";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(85, 44);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(126, 25);
            this.txb_Name.TabIndex = 5;
            // 
            // txb_StudentNo
            // 
            this.txb_StudentNo.Location = new System.Drawing.Point(85, 96);
            this.txb_StudentNo.Name = "txb_StudentNo";
            this.txb_StudentNo.Size = new System.Drawing.Size(126, 25);
            this.txb_StudentNo.TabIndex = 6;
            // 
            // txb_Class
            // 
            this.txb_Class.Location = new System.Drawing.Point(85, 152);
            this.txb_Class.Name = "txb_Class";
            this.txb_Class.Size = new System.Drawing.Size(126, 25);
            this.txb_Class.TabIndex = 7;
            // 
            // txb_Gender
            // 
            this.txb_Gender.Location = new System.Drawing.Point(333, 44);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.Size = new System.Drawing.Size(49, 25);
            this.txb_Gender.TabIndex = 8;
            // 
            // txb_BirthDate
            // 
            this.txb_BirthDate.Location = new System.Drawing.Point(333, 96);
            this.txb_BirthDate.Name = "txb_BirthDate";
            this.txb_BirthDate.Size = new System.Drawing.Size(130, 25);
            this.txb_BirthDate.TabIndex = 9;
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(151, 254);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(75, 23);
            this.btn_Info.TabIndex = 10;
            this.btn_Info.Text = "载入";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(290, 254);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // frm_StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 359);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.txb_BirthDate);
            this.Controls.Add(this.txb_Gender);
            this.Controls.Add(this.txb_Class);
            this.Controls.Add(this.txb_StudentNo);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lab_BirthDate);
            this.Controls.Add(this.lab_Gender);
            this.Controls.Add(this.lab_Class);
            this.Controls.Add(this.lab_StudentNo);
            this.Controls.Add(this.lab_Name);
            this.Name = "frm_StudentInfo";
            this.Text = "学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Label lab_StudentNo;
        private System.Windows.Forms.Label lab_Class;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.Label lab_BirthDate;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_StudentNo;
        private System.Windows.Forms.TextBox txb_Class;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.TextBox txb_BirthDate;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Update;
    }
}

