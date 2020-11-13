namespace FlowerService
{
    partial class ZipSearchPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvZip = new System.Windows.Forms.DataGridView();
            this.txtRoadAdder1 = new System.Windows.Forms.TextBox();
            this.txtRoadZipcode = new System.Windows.Forms.TextBox();
            this.txtRoadAdder2 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZipcode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.btnRoad = new System.Windows.Forms.Button();
            this.btnJibun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "도로명(지번) 주소검색";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(150, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(357, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvZip
            // 
            this.dgvZip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZip.Location = new System.Drawing.Point(13, 61);
            this.dgvZip.Name = "dgvZip";
            this.dgvZip.RowTemplate.Height = 23;
            this.dgvZip.Size = new System.Drawing.Size(428, 251);
            this.dgvZip.TabIndex = 3;
            this.dgvZip.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZip_CellDoubleClick);
            // 
            // txtRoadAdder1
            // 
            this.txtRoadAdder1.Location = new System.Drawing.Point(113, 344);
            this.txtRoadAdder1.Name = "txtRoadAdder1";
            this.txtRoadAdder1.Size = new System.Drawing.Size(328, 21);
            this.txtRoadAdder1.TabIndex = 4;
            // 
            // txtRoadZipcode
            // 
            this.txtRoadZipcode.Location = new System.Drawing.Point(113, 371);
            this.txtRoadZipcode.Name = "txtRoadZipcode";
            this.txtRoadZipcode.Size = new System.Drawing.Size(98, 21);
            this.txtRoadZipcode.TabIndex = 5;
            // 
            // txtRoadAdder2
            // 
            this.txtRoadAdder2.Location = new System.Drawing.Point(217, 371);
            this.txtRoadAdder2.Name = "txtRoadAdder2";
            this.txtRoadAdder2.Size = new System.Drawing.Size(224, 21);
            this.txtRoadAdder2.TabIndex = 6;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Location = new System.Drawing.Point(217, 457);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(224, 21);
            this.txtJibunAddr2.TabIndex = 9;
            // 
            // txtJibunZipcode
            // 
            this.txtJibunZipcode.Location = new System.Drawing.Point(113, 457);
            this.txtJibunZipcode.Name = "txtJibunZipcode";
            this.txtJibunZipcode.Size = new System.Drawing.Size(98, 21);
            this.txtJibunZipcode.TabIndex = 8;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Location = new System.Drawing.Point(113, 430);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(328, 21);
            this.txtJibunAddr1.TabIndex = 7;
            // 
            // btnRoad
            // 
            this.btnRoad.Location = new System.Drawing.Point(13, 344);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(81, 48);
            this.btnRoad.TabIndex = 10;
            this.btnRoad.Text = "도로명주소 확인";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // btnJibun
            // 
            this.btnJibun.Location = new System.Drawing.Point(13, 430);
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Size = new System.Drawing.Size(81, 48);
            this.btnJibun.TabIndex = 11;
            this.btnJibun.Text = "지번주소   확인";
            this.btnJibun.UseVisualStyleBackColor = true;
            this.btnJibun.Click += new System.EventHandler(this.btnJibun_Click);
            // 
            // ZipSearchPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 543);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunZipcode);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.txtRoadAdder2);
            this.Controls.Add(this.txtRoadZipcode);
            this.Controls.Add(this.txtRoadAdder1);
            this.Controls.Add(this.dgvZip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "ZipSearchPopup";
            this.Text = "우편번호검색";
            this.Load += new System.EventHandler(this.ZipSearchPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvZip;
        private System.Windows.Forms.TextBox txtRoadAdder1;
        private System.Windows.Forms.TextBox txtRoadZipcode;
        private System.Windows.Forms.TextBox txtRoadAdder2;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZipcode;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.Button btnJibun;
    }
}