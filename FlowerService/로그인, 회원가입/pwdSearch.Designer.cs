namespace FlowerService
{
    partial class pwdSearch
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
            this.txtIDS = new System.Windows.Forms.TextBox();
            this.txtNameS = new System.Windows.Forms.TextBox();
            this.txtEmailS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDS
            // 
            this.txtIDS.Location = new System.Drawing.Point(155, 42);
            this.txtIDS.Name = "txtIDS";
            this.txtIDS.Size = new System.Drawing.Size(143, 21);
            this.txtIDS.TabIndex = 0;
            // 
            // txtNameS
            // 
            this.txtNameS.Location = new System.Drawing.Point(155, 101);
            this.txtNameS.Name = "txtNameS";
            this.txtNameS.Size = new System.Drawing.Size(143, 21);
            this.txtNameS.TabIndex = 1;
            // 
            // txtEmailS
            // 
            this.txtEmailS.Location = new System.Drawing.Point(155, 160);
            this.txtEmailS.Name = "txtEmailS";
            this.txtEmailS.Size = new System.Drawing.Size(143, 21);
            this.txtEmailS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "이메일";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "비밀번호찾기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailS);
            this.Controls.Add(this.txtNameS);
            this.Controls.Add(this.txtIDS);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDS;
        private System.Windows.Forms.TextBox txtNameS;
        private System.Windows.Forms.TextBox txtEmailS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}