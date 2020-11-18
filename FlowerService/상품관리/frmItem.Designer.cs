namespace FlowerService
{
    partial class frmItem
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
            this.btnAdditem = new System.Windows.Forms.Button();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtCare = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdditem
            // 
            this.btnAdditem.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdditem.Location = new System.Drawing.Point(820, 41);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(91, 28);
            this.btnAdditem.TabIndex = 4;
            this.btnAdditem.TabStop = false;
            this.btnAdditem.Text = "상품등록";
            this.btnAdditem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(808, 135);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(16, 12);
            this.lblItemID.TabIndex = 36;
            this.lblItemID.Text = "ID";
            // 
            // txtCare
            // 
            this.txtCare.Location = new System.Drawing.Point(497, 224);
            this.txtCare.Multiline = true;
            this.txtCare.Name = "txtCare";
            this.txtCare.Size = new System.Drawing.Size(277, 27);
            this.txtCare.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(497, 175);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(277, 28);
            this.txtPrice.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(820, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 28);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "삭제하기";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(638, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 239);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(408, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 268);
            this.listBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "주의사항";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "가격";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "상품종류";
            // 
            // txtCase
            // 
            this.txtCase.Location = new System.Drawing.Point(497, 127);
            this.txtCase.Multiline = true;
            this.txtCase.Name = "txtCase";
            this.txtCase.Size = new System.Drawing.Size(277, 27);
            this.txtCase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "상품명";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(497, 78);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 28);
            this.txtName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(674, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "검색하기";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(423, 41);
            this.txtItemSearch.Multiline = true;
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(235, 23);
            this.txtItemSearch.TabIndex = 5;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddImg.Location = new System.Drawing.Point(638, 505);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(160, 28);
            this.btnAddImg.TabIndex = 23;
            this.btnAddImg.TabStop = false;
            this.btnAddImg.Text = "상품 이미지 등록";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 71);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종류 선택";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(17, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "꽃바구니";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(271, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "화환";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(144, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "꽃다발";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(11, 89);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(380, 444);
            this.dgvItem.TabIndex = 20;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 549);
            this.Controls.Add(this.btnAdditem);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.txtCare);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvItem);
            this.Name = "frmItem";
            this.Text = "등록상품관리";
            this.Load += new System.EventHandler(this.frmItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtCare;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}