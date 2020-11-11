namespace SignUp
{
    partial class frm_SignUp
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
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lab_Tips = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(64, 59);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(67, 15);
            this.lab_Name.TabIndex = 0;
            this.lab_Name.Text = "用户名：";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(137, 56);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(133, 25);
            this.txb_Name.TabIndex = 1;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(79, 117);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(52, 15);
            this.lab_Password.TabIndex = 2;
            this.lab_Password.Text = "密码：";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(137, 114);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(133, 25);
            this.txb_Password.TabIndex = 3;
            // 
            // lab_Tips
            // 
            this.lab_Tips.AutoSize = true;
            this.lab_Tips.Location = new System.Drawing.Point(118, 184);
            this.lab_Tips.Name = "lab_Tips";
            this.lab_Tips.Size = new System.Drawing.Size(172, 15);
            this.lab_Tips.TabIndex = 4;
            this.lab_Tips.Text = "请输入学号密码用于注册";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(160, 233);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 300);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lab_Tips);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lab_Name);
            this.Name = "frm_SignUp";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lab_Tips;
        private System.Windows.Forms.Button btn_SignUp;
    }
}

