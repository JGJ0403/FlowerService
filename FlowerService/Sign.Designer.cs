namespace FlowerService
{
    partial class frmUser
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
            this.id = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.pwdOk = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.local = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwdOk = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBirth = new System.Windows.Forms.ComboBox();
            this.zipSearchControl1 = new FlowerService.ZipSearchControl();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(39, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 16);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwd.Location = new System.Drawing.Point(39, 109);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(76, 16);
            this.pwd.TabIndex = 1;
            this.pwd.Text = "비밀번호";
            // 
            // pwdOk
            // 
            this.pwdOk.AutoSize = true;
            this.pwdOk.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwdOk.Location = new System.Drawing.Point(39, 158);
            this.pwdOk.Name = "pwdOk";
            this.pwdOk.Size = new System.Drawing.Size(116, 16);
            this.pwdOk.TabIndex = 2;
            this.pwdOk.Text = "비밀번호 확인";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num.Location = new System.Drawing.Point(39, 256);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(76, 16);
            this.num.TabIndex = 4;
            this.num.Text = "휴대전화";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(39, 207);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 16);
            this.name.TabIndex = 3;
            this.name.Text = "이름";
            // 
            // local
            // 
            this.local.AutoSize = true;
            this.local.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.local.Location = new System.Drawing.Point(39, 354);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(42, 16);
            this.local.TabIndex = 7;
            this.local.Text = "주소";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth.Location = new System.Drawing.Point(39, 305);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(76, 16);
            this.birth.TabIndex = 6;
            this.birth.Text = "생년월일";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 21);
            this.txtID.TabIndex = 8;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(174, 106);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(130, 21);
            this.txtPwd.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 207);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 21);
            this.txtName.TabIndex = 11;
            // 
            // txtPwdOk
            // 
            this.txtPwdOk.Location = new System.Drawing.Point(174, 153);
            this.txtPwdOk.Name = "txtPwdOk";
            this.txtPwdOk.Size = new System.Drawing.Size(130, 21);
            this.txtPwdOk.TabIndex = 10;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(174, 256);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(130, 21);
            this.txtNum.TabIndex = 12;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(340, 56);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(75, 23);
            this.btnID.TabIndex = 16;
            this.btnID.Text = "ID중복검사";
            this.btnID.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(421, 498);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(93, 32);
            this.btnUser.TabIndex = 20;
            this.btnUser.Text = "회원가입";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 498);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtBirth
            // 
            this.txtBirth.FormattingEnabled = true;
            this.txtBirth.Location = new System.Drawing.Point(174, 305);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(130, 20);
            this.txtBirth.TabIndex = 22;
            // 
            // zipSearchControl1
            // 
            this.zipSearchControl1.Location = new System.Drawing.Point(170, 348);
            this.zipSearchControl1.Name = "zipSearchControl1";
            this.zipSearchControl1.Size = new System.Drawing.Size(341, 83);
            this.zipSearchControl1.TabIndex = 23;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 589);
            this.Controls.Add(this.zipSearchControl1);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPwdOk);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.local);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pwdOk);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.id);
            this.Name = "frmUser";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Label pwdOk;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label local;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwdOk;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox txtBirth;
        private ZipSearchControl zipSearchControl1;
    }
}