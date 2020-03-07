namespace Market
{
    partial class MainMenu
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
            this.Products = new System.Windows.Forms.LinkLabel();
            this.Groups = new System.Windows.Forms.LinkLabel();
            this.PurchaseWindow = new System.Windows.Forms.LinkLabel();
            this.SaleWindow = new System.Windows.Forms.LinkLabel();
            this.SoldList = new System.Windows.Forms.LinkLabel();
            this.ShowProductBalance = new System.Windows.Forms.LinkLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.Products.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.LinkColor = System.Drawing.Color.Black;
            this.Products.Location = new System.Drawing.Point(12, 28);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(100, 25);
            this.Products.TabIndex = 0;
            this.Products.TabStop = true;
            this.Products.Text = "საქონელი";
            this.Products.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Products_LinkClicked);
            // 
            // Groups
            // 
            this.Groups.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.Groups.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groups.LinkColor = System.Drawing.Color.Black;
            this.Groups.Location = new System.Drawing.Point(12, 68);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(163, 25);
            this.Groups.TabIndex = 0;
            this.Groups.TabStop = true;
            this.Groups.Text = "საქონლის ჯგუფები";
            this.Groups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Groups_LinkClicked);
            // 
            // PurchaseWindow
            // 
            this.PurchaseWindow.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.PurchaseWindow.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseWindow.LinkColor = System.Drawing.Color.Black;
            this.PurchaseWindow.Location = new System.Drawing.Point(12, 176);
            this.PurchaseWindow.Name = "PurchaseWindow";
            this.PurchaseWindow.Size = new System.Drawing.Size(86, 25);
            this.PurchaseWindow.TabIndex = 0;
            this.PurchaseWindow.TabStop = true;
            this.PurchaseWindow.Text = "შესყიდვა";
            this.PurchaseWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PurchaseWindow_LinkClicked);
            // 
            // SaleWindow
            // 
            this.SaleWindow.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaleWindow.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleWindow.LinkColor = System.Drawing.Color.Black;
            this.SaleWindow.Location = new System.Drawing.Point(12, 218);
            this.SaleWindow.Name = "SaleWindow";
            this.SaleWindow.Size = new System.Drawing.Size(86, 25);
            this.SaleWindow.TabIndex = 0;
            this.SaleWindow.TabStop = true;
            this.SaleWindow.Text = "გაყიდვა";
            this.SaleWindow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaleWindow_LinkClicked);
            // 
            // SoldList
            // 
            this.SoldList.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.SoldList.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldList.LinkColor = System.Drawing.Color.Black;
            this.SoldList.Location = new System.Drawing.Point(12, 333);
            this.SoldList.Name = "SoldList";
            this.SoldList.Size = new System.Drawing.Size(178, 25);
            this.SoldList.TabIndex = 0;
            this.SoldList.TabStop = true;
            this.SoldList.Text = "გაყიდული საქონელი";
            this.SoldList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SoldList_LinkClicked);
            // 
            // ShowProductBalance
            // 
            this.ShowProductBalance.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowProductBalance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProductBalance.LinkColor = System.Drawing.Color.Black;
            this.ShowProductBalance.Location = new System.Drawing.Point(12, 289);
            this.ShowProductBalance.Name = "ShowProductBalance";
            this.ShowProductBalance.Size = new System.Drawing.Size(178, 25);
            this.ShowProductBalance.TabIndex = 0;
            this.ShowProductBalance.TabStop = true;
            this.ShowProductBalance.Text = "საქონლის ნაშთი";
            this.ShowProductBalance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowProductBalance_LinkClicked);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Options});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(665, 26);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // Options
            // 
            this.Options.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(101, 22);
            this.Options.Text = "პარამეტრები";
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.ShowProductBalance);
            this.Controls.Add(this.SoldList);
            this.Controls.Add(this.SaleWindow);
            this.Controls.Add(this.PurchaseWindow);
            this.Controls.Add(this.Groups);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Sylfaen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "მთავარი მენიუ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Products;
        private System.Windows.Forms.LinkLabel Groups;
        private System.Windows.Forms.LinkLabel PurchaseWindow;
        private System.Windows.Forms.LinkLabel SaleWindow;
        private System.Windows.Forms.LinkLabel SoldList;
        private System.Windows.Forms.LinkLabel ShowProductBalance;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Options;
    }
}