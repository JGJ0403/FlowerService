namespace FlowerService
{
    partial class adminUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zipSearchControl1 = new FlowerService.ZipSearchControl();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.local = new System.Windows.Forms.Label();
            this.birth = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.수정 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(483, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // zipSearchControl1
            // 
            this.zipSearchControl1.Location = new System.Drawing.Point(640, 232);
            this.zipSearchControl1.Name = "zipSearchControl1";
            this.zipSearchControl1.Size = new System.Drawing.Size(341, 83);
            this.zipSearchControl1.TabIndex = 38;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(644, 137);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(130, 21);
            this.txtNum.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(644, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 21);
            this.txtName.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(644, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 21);
            this.txtID.TabIndex = 31;
            // 
            // local
            // 
            this.local.AutoSize = true;
            this.local.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.local.Location = new System.Drawing.Point(556, 236);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(42, 16);
            this.local.TabIndex = 30;
            this.local.Text = "주소";
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.birth.Location = new System.Drawing.Point(522, 187);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(76, 16);
            this.birth.TabIndex = 29;
            this.birth.Text = "생년월일";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num.Location = new System.Drawing.Point(522, 137);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(76, 16);
            this.num.TabIndex = 28;
            this.num.Text = "휴대전화";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.Location = new System.Drawing.Point(556, 87);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 16);
            this.name.TabIndex = 27;
            this.name.Text = "이름";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id.Location = new System.Drawing.Point(575, 37);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 16);
            this.id.TabIndex = 24;
            this.id.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 39;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(888, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 수정
            // 
            this.수정.Location = new System.Drawing.Point(699, 353);
            this.수정.Name = "수정";
            this.수정.Size = new System.Drawing.Size(102, 37);
            this.수정.TabIndex = 41;
            this.수정.Text = "수정";
            this.수정.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(644, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // 회원관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 420);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.수정);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zipSearchControl1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.local);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "회원관리";
            this.Text = "adminUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZipSearchControl zipSearchControl1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label local;
        private System.Windows.Forms.Label birth;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button 수정;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}