namespace RMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catergoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodItemNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catgoryIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daywiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1619, 46);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.companySettingsToolStripMenuItem});
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(137, 42);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.catergoryToolStripMenuItem,
            this.foodItemsToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(329, 42);
            this.manageUsersToolStripMenuItem.Text = "Manage ";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.usersToolStripMenuItem.Text = "Users ";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // catergoryToolStripMenuItem
            // 
            this.catergoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("catergoryToolStripMenuItem.Image")));
            this.catergoryToolStripMenuItem.Name = "catergoryToolStripMenuItem";
            this.catergoryToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.catergoryToolStripMenuItem.Text = "Category";
            this.catergoryToolStripMenuItem.Click += new System.EventHandler(this.catergoryToolStripMenuItem_Click);
            // 
            // foodItemsToolStripMenuItem
            // 
            this.foodItemsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("foodItemsToolStripMenuItem.Image")));
            this.foodItemsToolStripMenuItem.Name = "foodItemsToolStripMenuItem";
            this.foodItemsToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.foodItemsToolStripMenuItem.Text = "Food Items";
            this.foodItemsToolStripMenuItem.Click += new System.EventHandler(this.foodItemsToolStripMenuItem_Click);
            // 
            // companySettingsToolStripMenuItem
            // 
            this.companySettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("companySettingsToolStripMenuItem.Image")));
            this.companySettingsToolStripMenuItem.Name = "companySettingsToolStripMenuItem";
            this.companySettingsToolStripMenuItem.Size = new System.Drawing.Size(329, 42);
            this.companySettingsToolStripMenuItem.Text = "Company Settings";
            this.companySettingsToolStripMenuItem.Click += new System.EventHandler(this.companySettingsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datwiseToolStripMenuItem,
            this.daywiseToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(93, 42);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem1,
            this.categoryToolStripMenuItem,
            this.oodItemsToolStripMenuItem,
            this.companyToolStripMenuItem});
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(131, 42);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userIdToolStripMenuItem,
            this.userNameToolStripMenuItem});
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(237, 42);
            this.usersToolStripMenuItem1.Text = "Users";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryIdToolStripMenuItem,
            this.categoryNameToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // oodItemsToolStripMenuItem
            // 
            this.oodItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodIdToolStripMenuItem,
            this.foodItemNameToolStripMenuItem,
            this.catgoryIdToolStripMenuItem,
            this.rateToolStripMenuItem});
            this.oodItemsToolStripMenuItem.Name = "oodItemsToolStripMenuItem";
            this.oodItemsToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.oodItemsToolStripMenuItem.Text = "Food Items";
            this.oodItemsToolStripMenuItem.Click += new System.EventHandler(this.oodItemsToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billIdToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(237, 42);
            this.companyToolStripMenuItem.Text = "Bill";
            // 
            // userIdToolStripMenuItem
            // 
            this.userIdToolStripMenuItem.Name = "userIdToolStripMenuItem";
            this.userIdToolStripMenuItem.Size = new System.Drawing.Size(239, 42);
            this.userIdToolStripMenuItem.Text = "User Id";
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(239, 42);
            this.userNameToolStripMenuItem.Text = "User Name";
            // 
            // categoryIdToolStripMenuItem
            // 
            this.categoryIdToolStripMenuItem.Name = "categoryIdToolStripMenuItem";
            this.categoryIdToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.categoryIdToolStripMenuItem.Text = "CategoryId";
            // 
            // categoryNameToolStripMenuItem
            // 
            this.categoryNameToolStripMenuItem.Name = "categoryNameToolStripMenuItem";
            this.categoryNameToolStripMenuItem.Size = new System.Drawing.Size(297, 42);
            this.categoryNameToolStripMenuItem.Text = "Category Name";
            // 
            // foodIdToolStripMenuItem
            // 
            this.foodIdToolStripMenuItem.Name = "foodIdToolStripMenuItem";
            this.foodIdToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.foodIdToolStripMenuItem.Text = "Food Id";
            // 
            // foodItemNameToolStripMenuItem
            // 
            this.foodItemNameToolStripMenuItem.Name = "foodItemNameToolStripMenuItem";
            this.foodItemNameToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.foodItemNameToolStripMenuItem.Text = "Food Item Name";
            // 
            // catgoryIdToolStripMenuItem
            // 
            this.catgoryIdToolStripMenuItem.Name = "catgoryIdToolStripMenuItem";
            this.catgoryIdToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.catgoryIdToolStripMenuItem.Text = "Category Id";
            // 
            // rateToolStripMenuItem
            // 
            this.rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            this.rateToolStripMenuItem.Size = new System.Drawing.Size(310, 42);
            this.rateToolStripMenuItem.Text = "Rate";
            // 
            // billIdToolStripMenuItem
            // 
            this.billIdToolStripMenuItem.Name = "billIdToolStripMenuItem";
            this.billIdToolStripMenuItem.Size = new System.Drawing.Size(180, 42);
            this.billIdToolStripMenuItem.Text = "Bill Id";
            // 
            // datwiseToolStripMenuItem
            // 
            this.datwiseToolStripMenuItem.Name = "datwiseToolStripMenuItem";
            this.datwiseToolStripMenuItem.Size = new System.Drawing.Size(213, 42);
            this.datwiseToolStripMenuItem.Text = "Datewise";
            // 
            // daywiseToolStripMenuItem
            // 
            this.daywiseToolStripMenuItem.Name = "daywiseToolStripMenuItem";
            this.daywiseToolStripMenuItem.Size = new System.Drawing.Size(213, 42);
            this.daywiseToolStripMenuItem.Text = "Daywise";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 65);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1619, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catergoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oodItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodItemNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catgoryIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daywiseToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}