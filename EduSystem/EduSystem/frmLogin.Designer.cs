namespace EduSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lab_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(203, 224);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(75, 23);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(203, 187);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(171, 117);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(141, 25);
            this.txb_Password.TabIndex = 9;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(125, 120);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(52, 15);
            this.lab_Password.TabIndex = 8;
            this.lab_Password.Text = "密码：";
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(171, 69);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(141, 25);
            this.txb_Name.TabIndex = 7;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Location = new System.Drawing.Point(110, 72);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(67, 15);
            this.lab_Name.TabIndex = 6;
            this.lab_Name.Text = "用户名：";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 313);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lab_Password);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lab_Name);
            this.Name = "frmLogin";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lab_Name;
    }
}