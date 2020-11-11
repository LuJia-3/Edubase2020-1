namespace EduSystem
{
    partial class frm_EduSystem
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
            this.lab_StudentInfo = new System.Windows.Forms.Label();
            this.lab_StudentNo = new System.Windows.Forms.Label();
            this.lab_SNo = new System.Windows.Forms.Label();
            this.lab_StudentName = new System.Windows.Forms.Label();
            this.lab_Image = new System.Windows.Forms.Label();
            this.btn_MyDesk = new System.Windows.Forms.Button();
            this.btn_StudentAchievement = new System.Windows.Forms.Button();
            this.btn_TrainManage = new System.Windows.Forms.Button();
            this.btn_TestRegistration = new System.Windows.Forms.Button();
            this.btn_PracticalTraining = new System.Windows.Forms.Button();
            this.btn_TeachEvaluation = new System.Windows.Forms.Button();
            this.txb_StudentNo = new System.Windows.Forms.TextBox();
            this.txb_StudentName = new System.Windows.Forms.TextBox();
            this.lab_Gender = new System.Windows.Forms.Label();
            this.txb_Gender = new System.Windows.Forms.TextBox();
            this.lab_Class = new System.Windows.Forms.Label();
            this.lab_BirthDate = new System.Windows.Forms.Label();
            this.txb_Class = new System.Windows.Forms.TextBox();
            this.txb_BirthDate = new System.Windows.Forms.TextBox();
            this.txb_Image = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_StudentInfo
            // 
            this.lab_StudentInfo.AutoSize = true;
            this.lab_StudentInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lab_StudentInfo.Location = new System.Drawing.Point(12, 31);
            this.lab_StudentInfo.Name = "lab_StudentInfo";
            this.lab_StudentInfo.Size = new System.Drawing.Size(67, 15);
            this.lab_StudentInfo.TabIndex = 0;
            this.lab_StudentInfo.Text = "学生信息";
            // 
            // lab_StudentNo
            // 
            this.lab_StudentNo.AutoSize = true;
            this.lab_StudentNo.Location = new System.Drawing.Point(197, 152);
            this.lab_StudentNo.Name = "lab_StudentNo";
            this.lab_StudentNo.Size = new System.Drawing.Size(0, 15);
            this.lab_StudentNo.TabIndex = 1;
            // 
            // lab_SNo
            // 
            this.lab_SNo.AutoSize = true;
            this.lab_SNo.Location = new System.Drawing.Point(24, 71);
            this.lab_SNo.Name = "lab_SNo";
            this.lab_SNo.Size = new System.Drawing.Size(37, 15);
            this.lab_SNo.TabIndex = 3;
            this.lab_SNo.Text = "学号";
            // 
            // lab_StudentName
            // 
            this.lab_StudentName.AutoSize = true;
            this.lab_StudentName.Location = new System.Drawing.Point(24, 123);
            this.lab_StudentName.Name = "lab_StudentName";
            this.lab_StudentName.Size = new System.Drawing.Size(37, 15);
            this.lab_StudentName.TabIndex = 4;
            this.lab_StudentName.Text = "姓名";
            // 
            // lab_Image
            // 
            this.lab_Image.AutoSize = true;
            this.lab_Image.Location = new System.Drawing.Point(24, 332);
            this.lab_Image.Name = "lab_Image";
            this.lab_Image.Size = new System.Drawing.Size(37, 15);
            this.lab_Image.TabIndex = 5;
            this.lab_Image.Text = "头像";
            // 
            // btn_MyDesk
            // 
            this.btn_MyDesk.Location = new System.Drawing.Point(240, 71);
            this.btn_MyDesk.Name = "btn_MyDesk";
            this.btn_MyDesk.Size = new System.Drawing.Size(150, 123);
            this.btn_MyDesk.TabIndex = 6;
            this.btn_MyDesk.Text = "我的桌面";
            this.btn_MyDesk.UseVisualStyleBackColor = true;
            // 
            // btn_StudentAchievement
            // 
            this.btn_StudentAchievement.Location = new System.Drawing.Point(419, 71);
            this.btn_StudentAchievement.Name = "btn_StudentAchievement";
            this.btn_StudentAchievement.Size = new System.Drawing.Size(150, 123);
            this.btn_StudentAchievement.TabIndex = 7;
            this.btn_StudentAchievement.Text = "学籍成绩";
            this.btn_StudentAchievement.UseVisualStyleBackColor = true;
            // 
            // btn_TrainManage
            // 
            this.btn_TrainManage.Location = new System.Drawing.Point(599, 71);
            this.btn_TrainManage.Name = "btn_TrainManage";
            this.btn_TrainManage.Size = new System.Drawing.Size(150, 123);
            this.btn_TrainManage.TabIndex = 8;
            this.btn_TrainManage.Text = "培养管理";
            this.btn_TrainManage.UseVisualStyleBackColor = true;
            // 
            // btn_TestRegistration
            // 
            this.btn_TestRegistration.Location = new System.Drawing.Point(240, 249);
            this.btn_TestRegistration.Name = "btn_TestRegistration";
            this.btn_TestRegistration.Size = new System.Drawing.Size(150, 120);
            this.btn_TestRegistration.TabIndex = 9;
            this.btn_TestRegistration.Text = "考试报名";
            this.btn_TestRegistration.UseVisualStyleBackColor = true;
            // 
            // btn_PracticalTraining
            // 
            this.btn_PracticalTraining.Location = new System.Drawing.Point(419, 249);
            this.btn_PracticalTraining.Name = "btn_PracticalTraining";
            this.btn_PracticalTraining.Size = new System.Drawing.Size(150, 120);
            this.btn_PracticalTraining.TabIndex = 10;
            this.btn_PracticalTraining.Text = "实践环节";
            this.btn_PracticalTraining.UseVisualStyleBackColor = true;
            // 
            // btn_TeachEvaluation
            // 
            this.btn_TeachEvaluation.Location = new System.Drawing.Point(599, 249);
            this.btn_TeachEvaluation.Name = "btn_TeachEvaluation";
            this.btn_TeachEvaluation.Size = new System.Drawing.Size(150, 120);
            this.btn_TeachEvaluation.TabIndex = 11;
            this.btn_TeachEvaluation.Text = "教学评价";
            this.btn_TeachEvaluation.UseVisualStyleBackColor = true;
            // 
            // txb_StudentNo
            // 
            this.txb_StudentNo.Location = new System.Drawing.Point(67, 68);
            this.txb_StudentNo.Name = "txb_StudentNo";
            this.txb_StudentNo.Size = new System.Drawing.Size(130, 25);
            this.txb_StudentNo.TabIndex = 12;
            // 
            // txb_StudentName
            // 
            this.txb_StudentName.Location = new System.Drawing.Point(67, 120);
            this.txb_StudentName.Name = "txb_StudentName";
            this.txb_StudentName.Size = new System.Drawing.Size(130, 25);
            this.txb_StudentName.TabIndex = 13;
            // 
            // lab_Gender
            // 
            this.lab_Gender.AutoSize = true;
            this.lab_Gender.Location = new System.Drawing.Point(24, 179);
            this.lab_Gender.Name = "lab_Gender";
            this.lab_Gender.Size = new System.Drawing.Size(37, 15);
            this.lab_Gender.TabIndex = 14;
            this.lab_Gender.Text = "性别";
            // 
            // txb_Gender
            // 
            this.txb_Gender.Location = new System.Drawing.Point(67, 176);
            this.txb_Gender.Name = "txb_Gender";
            this.txb_Gender.Size = new System.Drawing.Size(130, 25);
            this.txb_Gender.TabIndex = 15;
            // 
            // lab_Class
            // 
            this.lab_Class.AutoSize = true;
            this.lab_Class.Location = new System.Drawing.Point(24, 233);
            this.lab_Class.Name = "lab_Class";
            this.lab_Class.Size = new System.Drawing.Size(37, 15);
            this.lab_Class.TabIndex = 16;
            this.lab_Class.Text = "班级";
            // 
            // lab_BirthDate
            // 
            this.lab_BirthDate.AutoSize = true;
            this.lab_BirthDate.Location = new System.Drawing.Point(24, 282);
            this.lab_BirthDate.Name = "lab_BirthDate";
            this.lab_BirthDate.Size = new System.Drawing.Size(37, 15);
            this.lab_BirthDate.TabIndex = 17;
            this.lab_BirthDate.Text = "生日";
            // 
            // txb_Class
            // 
            this.txb_Class.Location = new System.Drawing.Point(67, 230);
            this.txb_Class.Name = "txb_Class";
            this.txb_Class.Size = new System.Drawing.Size(130, 25);
            this.txb_Class.TabIndex = 18;
            // 
            // txb_BirthDate
            // 
            this.txb_BirthDate.Location = new System.Drawing.Point(67, 279);
            this.txb_BirthDate.Name = "txb_BirthDate";
            this.txb_BirthDate.Size = new System.Drawing.Size(130, 25);
            this.txb_BirthDate.TabIndex = 19;
            // 
            // txb_Image
            // 
            this.txb_Image.Location = new System.Drawing.Point(67, 329);
            this.txb_Image.Name = "txb_Image";
            this.txb_Image.Size = new System.Drawing.Size(130, 25);
            this.txb_Image.TabIndex = 20;
            // 
            // frm_EduSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Image);
            this.Controls.Add(this.txb_BirthDate);
            this.Controls.Add(this.txb_Class);
            this.Controls.Add(this.lab_BirthDate);
            this.Controls.Add(this.lab_Class);
            this.Controls.Add(this.txb_Gender);
            this.Controls.Add(this.lab_Gender);
            this.Controls.Add(this.txb_StudentName);
            this.Controls.Add(this.txb_StudentNo);
            this.Controls.Add(this.btn_TeachEvaluation);
            this.Controls.Add(this.btn_PracticalTraining);
            this.Controls.Add(this.btn_TestRegistration);
            this.Controls.Add(this.btn_TrainManage);
            this.Controls.Add(this.btn_StudentAchievement);
            this.Controls.Add(this.btn_MyDesk);
            this.Controls.Add(this.lab_Image);
            this.Controls.Add(this.lab_StudentName);
            this.Controls.Add(this.lab_SNo);
            this.Controls.Add(this.lab_StudentNo);
            this.Controls.Add(this.lab_StudentInfo);
            this.Name = "frm_EduSystem";
            this.Text = "教务系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_StudentInfo;
        private System.Windows.Forms.Label lab_StudentNo;
        private System.Windows.Forms.Label lab_SNo;
        private System.Windows.Forms.Label lab_StudentName;
        private System.Windows.Forms.Label lab_Image;
        private System.Windows.Forms.Button btn_MyDesk;
        private System.Windows.Forms.Button btn_StudentAchievement;
        private System.Windows.Forms.Button btn_TrainManage;
        private System.Windows.Forms.Button btn_TestRegistration;
        private System.Windows.Forms.Button btn_PracticalTraining;
        private System.Windows.Forms.Button btn_TeachEvaluation;
        private System.Windows.Forms.TextBox txb_StudentNo;
        private System.Windows.Forms.TextBox txb_StudentName;
        private System.Windows.Forms.Label lab_Gender;
        private System.Windows.Forms.TextBox txb_Gender;
        private System.Windows.Forms.Label lab_Class;
        private System.Windows.Forms.Label lab_BirthDate;
        private System.Windows.Forms.TextBox txb_Class;
        private System.Windows.Forms.TextBox txb_BirthDate;
        private System.Windows.Forms.TextBox txb_Image;
    }
}

