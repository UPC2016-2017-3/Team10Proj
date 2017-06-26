namespace hotel
{
    partial class main
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
            this.客房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.item2 = new System.Windows.Forms.ToolStripMenuItem();
            this.item3 = new System.Windows.Forms.ToolStripMenuItem();
            this.item6 = new System.Windows.Forms.ToolStripMenuItem();
            this.item7 = new System.Windows.Forms.ToolStripMenuItem();
            this.会员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item8 = new System.Windows.Forms.ToolStripMenuItem();
            this.item9 = new System.Windows.Forms.ToolStripMenuItem();
            this.item10 = new System.Windows.Forms.ToolStripMenuItem();
            this.统计管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item11 = new System.Windows.Forms.ToolStripMenuItem();
            this.item12 = new System.Windows.Forms.ToolStripMenuItem();
            this.item13 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房管理ToolStripMenuItem,
            this.会员管理ToolStripMenuItem,
            this.统计管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseClick);
            // 
            // 客房管理ToolStripMenuItem
            // 
            this.客房管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1,
            this.item2,
            this.item3,
            this.item6,
            this.item7});
            this.客房管理ToolStripMenuItem.Name = "客房管理ToolStripMenuItem";
            this.客房管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.客房管理ToolStripMenuItem.Text = "客房管理";
            // 
            // item1
            // 
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(168, 24);
            this.item1.Text = "客房类型设置";
            this.item1.Click += new System.EventHandler(this.客房类型设置ToolStripMenuItem_Click);
            // 
            // item2
            // 
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(168, 24);
            this.item2.Text = "客房信息设置";
            this.item2.Click += new System.EventHandler(this.客房信息设置ToolStripMenuItem_Click);
            // 
            // item3
            // 
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(168, 24);
            this.item3.Text = "消费记账";
            this.item3.Click += new System.EventHandler(this.房间物品管理ToolStripMenuItem_Click);
            // 
            // item6
            // 
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(168, 24);
            this.item6.Text = "业务管理";
            // 
            // item7
            // 
            this.item7.Name = "item7";
            this.item7.Size = new System.Drawing.Size(168, 24);
            this.item7.Text = "房态管理";
            // 
            // 会员管理ToolStripMenuItem
            // 
            this.会员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item8,
            this.item9,
            this.item10});
            this.会员管理ToolStripMenuItem.Name = "会员管理ToolStripMenuItem";
            this.会员管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.会员管理ToolStripMenuItem.Text = "会员管理";
            // 
            // item8
            // 
            this.item8.Name = "item8";
            this.item8.Size = new System.Drawing.Size(168, 24);
            this.item8.Text = "删除会员信息";
            // 
            // item9
            // 
            this.item9.Name = "item9";
            this.item9.Size = new System.Drawing.Size(168, 24);
            this.item9.Text = "查询会员信息";
            // 
            // item10
            // 
            this.item10.Name = "item10";
            this.item10.Size = new System.Drawing.Size(168, 24);
            this.item10.Text = "修改会员信息";
            // 
            // 统计管理ToolStripMenuItem
            // 
            this.统计管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item11,
            this.item12,
            this.item13});
            this.统计管理ToolStripMenuItem.Name = "统计管理ToolStripMenuItem";
            this.统计管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.统计管理ToolStripMenuItem.Text = "统计管理";
            // 
            // item11
            // 
            this.item11.Name = "item11";
            this.item11.Size = new System.Drawing.Size(168, 24);
            this.item11.Text = "分析盈利状况";
            // 
            // item12
            // 
            this.item12.Name = "item12";
            this.item12.Size = new System.Drawing.Size(168, 24);
            this.item12.Text = "分析空房状况";
            // 
            // item13
            // 
            this.item13.Name = "item13";
            this.item13.Size = new System.Drawing.Size(168, 24);
            this.item13.Text = "分析忠实客户";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1030, 619);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 客房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 会员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item8;
        private System.Windows.Forms.ToolStripMenuItem item9;
        private System.Windows.Forms.ToolStripMenuItem 统计管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item11;
        private System.Windows.Forms.ToolStripMenuItem item12;
        private System.Windows.Forms.ToolStripMenuItem item13;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item6;
        private System.Windows.Forms.ToolStripMenuItem item1;
        private System.Windows.Forms.ToolStripMenuItem item2;
        private System.Windows.Forms.ToolStripMenuItem item7;
        private System.Windows.Forms.ToolStripMenuItem item3;
        private System.Windows.Forms.ToolStripMenuItem item10;
    }
}