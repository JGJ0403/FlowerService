namespace FlowerService.사용자
{
    partial class userMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.상품선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원정보수정ToolStripMenuItem,
            this.상품선택ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 상품선택ToolStripMenuItem
            // 
            this.상품선택ToolStripMenuItem.Name = "상품선택ToolStripMenuItem";
            this.상품선택ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.상품선택ToolStripMenuItem.Text = "상품주문";
            // 
            // 회원정보수정ToolStripMenuItem
            // 
            this.회원정보수정ToolStripMenuItem.Name = "회원정보수정ToolStripMenuItem";
            this.회원정보수정ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.회원정보수정ToolStripMenuItem.Text = "회원정보수정";
            // 
            // userMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "userMain";
            this.Text = "회원용 페이지";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원정보수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품선택ToolStripMenuItem;
    }
}