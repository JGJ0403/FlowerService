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
            this.사용자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바구니ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.꽃다발ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배송ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배송주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자ToolStripMenuItem,
            this.상품ToolStripMenuItem,
            this.배송ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 사용자ToolStripMenuItem
            // 
            this.사용자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem});
            this.사용자ToolStripMenuItem.Name = "사용자ToolStripMenuItem";
            this.사용자ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.사용자ToolStripMenuItem.Text = "사용자";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 상품ToolStripMenuItem
            // 
            this.상품ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품조회ToolStripMenuItem});
            this.상품ToolStripMenuItem.Name = "상품ToolStripMenuItem";
            this.상품ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.상품ToolStripMenuItem.Text = "상품";
            // 
            // 상품조회ToolStripMenuItem
            // 
            this.상품조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.바구니ToolStripMenuItem,
            this.꽃다발ToolStripMenuItem,
            this.화환ToolStripMenuItem});
            this.상품조회ToolStripMenuItem.Name = "상품조회ToolStripMenuItem";
            this.상품조회ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.상품조회ToolStripMenuItem.Text = "상품조회";
            // 
            // 바구니ToolStripMenuItem
            // 
            this.바구니ToolStripMenuItem.Name = "바구니ToolStripMenuItem";
            this.바구니ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.바구니ToolStripMenuItem.Text = "꽃바구니";
            // 
            // 꽃다발ToolStripMenuItem
            // 
            this.꽃다발ToolStripMenuItem.Name = "꽃다발ToolStripMenuItem";
            this.꽃다발ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.꽃다발ToolStripMenuItem.Text = "꽃다발";
            // 
            // 화환ToolStripMenuItem
            // 
            this.화환ToolStripMenuItem.Name = "화환ToolStripMenuItem";
            this.화환ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.화환ToolStripMenuItem.Text = "화환";
            // 
            // 배송ToolStripMenuItem
            // 
            this.배송ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배송주문ToolStripMenuItem});
            this.배송ToolStripMenuItem.Name = "배송ToolStripMenuItem";
            this.배송ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.배송ToolStripMenuItem.Text = "배송";
            // 
            // 배송주문ToolStripMenuItem
            // 
            this.배송주문ToolStripMenuItem.Name = "배송주문ToolStripMenuItem";
            this.배송주문ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.배송주문ToolStripMenuItem.Text = "배송조회";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 446);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "꽃 주문";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 사용자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배송ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배송주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바구니ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 꽃다발ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 화환ToolStripMenuItem;
    }
}