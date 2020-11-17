namespace FlowerService
{
    partial class Main
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
            this.상품ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배송ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.상품ToolStripMenuItem,
            this.배송ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 상품ToolStripMenuItem
            // 
            this.상품ToolStripMenuItem.Name = "상품ToolStripMenuItem";
            this.상품ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.상품ToolStripMenuItem.Text = "상품등록관리";
            this.상품ToolStripMenuItem.Click += new System.EventHandler(this.상품ToolStripMenuItem_Click);
            // 
            // 배송ToolStripMenuItem
            // 
            this.배송ToolStripMenuItem.Name = "배송ToolStripMenuItem";
            this.배송ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.배송ToolStripMenuItem.Text = "배송관리";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.회원관리ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 446);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "관리자페이지";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 배송ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
    }
}