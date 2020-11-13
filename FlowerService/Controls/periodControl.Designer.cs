namespace FlowerService.Controls
{
    partial class periodControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.btn6Month = new System.Windows.Forms.Button();
            this.btn3Month = new System.Windows.Forms.Button();
            this.btnOneMonth = new System.Windows.Forms.Button();
            this.btnOneWeek = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(99, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "~";
            // 
            // btn6Month
            // 
            this.btn6Month.Location = new System.Drawing.Point(382, 3);
            this.btn6Month.Name = "btn6Month";
            this.btn6Month.Size = new System.Drawing.Size(49, 23);
            this.btn6Month.TabIndex = 36;
            this.btn6Month.Text = "6개월";
            this.btn6Month.UseVisualStyleBackColor = true;
            // 
            // btn3Month
            // 
            this.btn3Month.Location = new System.Drawing.Point(328, 3);
            this.btn3Month.Name = "btn3Month";
            this.btn3Month.Size = new System.Drawing.Size(46, 23);
            this.btn3Month.TabIndex = 35;
            this.btn3Month.Text = "3개월";
            this.btn3Month.UseVisualStyleBackColor = true;
            // 
            // btnOneMonth
            // 
            this.btnOneMonth.Location = new System.Drawing.Point(272, 3);
            this.btnOneMonth.Name = "btnOneMonth";
            this.btnOneMonth.Size = new System.Drawing.Size(48, 23);
            this.btnOneMonth.TabIndex = 34;
            this.btnOneMonth.Text = "1개월";
            this.btnOneMonth.UseVisualStyleBackColor = true;
            // 
            // btnOneWeek
            // 
            this.btnOneWeek.Location = new System.Drawing.Point(232, 3);
            this.btnOneWeek.Name = "btnOneWeek";
            this.btnOneWeek.Size = new System.Drawing.Size(32, 23);
            this.btnOneWeek.TabIndex = 33;
            this.btnOneWeek.Text = "1주";
            this.btnOneWeek.UseVisualStyleBackColor = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(132, 4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(93, 21);
            this.dtpEnd.TabIndex = 32;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(0, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(93, 21);
            this.dtpStart.TabIndex = 31;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // periodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn6Month);
            this.Controls.Add(this.btn3Month);
            this.Controls.Add(this.btnOneMonth);
            this.Controls.Add(this.btnOneWeek);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Name = "periodControl";
            this.Size = new System.Drawing.Size(437, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn6Month;
        private System.Windows.Forms.Button btn3Month;
        private System.Windows.Forms.Button btnOneMonth;
        private System.Windows.Forms.Button btnOneWeek;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}
