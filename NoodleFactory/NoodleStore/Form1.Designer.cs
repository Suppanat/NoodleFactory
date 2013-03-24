namespace NoodleStore
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.แฟมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSearchProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมสายการสงสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripeExit = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บลรายวนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บลเกบเงนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ใบสงของโรงงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เกยวกบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บรษทToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ขอมลโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.หนาตางToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.แฟมToolStripMenuItem,
            this.รายงานToolStripMenuItem,
            this.เกยวกบToolStripMenuItem,
            this.หนาตางToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // แฟมToolStripMenuItem
            // 
            this.แฟมToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripOrder,
            this.ToolStripProduct,
            this.ToolStripCustomer,
            this.เพมสายการสงสนคาToolStripMenuItem,
            this.toolStripSeparator1,
            this.ToolStripeExit});
            this.แฟมToolStripMenuItem.Name = "แฟมToolStripMenuItem";
            this.แฟมToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.แฟมToolStripMenuItem.Text = "แฟ้ม";
            // 
            // ToolStripOrder
            // 
            this.ToolStripOrder.Name = "ToolStripOrder";
            this.ToolStripOrder.Size = new System.Drawing.Size(152, 22);
            this.ToolStripOrder.Text = "รายการสั่งซื้อ";
            // 
            // ToolStripProduct
            // 
            this.ToolStripProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripUpdateProduct,
            this.ToolStripSearchProduct});
            this.ToolStripProduct.Name = "ToolStripProduct";
            this.ToolStripProduct.Size = new System.Drawing.Size(152, 22);
            this.ToolStripProduct.Text = "สินค้า";
            // 
            // ToolStripUpdateProduct
            // 
            this.ToolStripUpdateProduct.Name = "ToolStripUpdateProduct";
            this.ToolStripUpdateProduct.Size = new System.Drawing.Size(154, 22);
            this.ToolStripUpdateProduct.Text = "เพิ่ม/แก้ไข สินค้า";
            this.ToolStripUpdateProduct.Click += new System.EventHandler(this.ToolStripUpdateProduct_Click);
            // 
            // ToolStripSearchProduct
            // 
            this.ToolStripSearchProduct.Name = "ToolStripSearchProduct";
            this.ToolStripSearchProduct.Size = new System.Drawing.Size(154, 22);
            this.ToolStripSearchProduct.Text = "ค้นหาสินค้า";
            // 
            // ToolStripCustomer
            // 
            this.ToolStripCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSearchCustomer,
            this.ToolStripUpdateCustomer});
            this.ToolStripCustomer.Name = "ToolStripCustomer";
            this.ToolStripCustomer.Size = new System.Drawing.Size(152, 22);
            this.ToolStripCustomer.Text = "ลูกค้า";
            // 
            // ToolStripSearchCustomer
            // 
            this.ToolStripSearchCustomer.Name = "ToolStripSearchCustomer";
            this.ToolStripSearchCustomer.Size = new System.Drawing.Size(238, 22);
            this.ToolStripSearchCustomer.Text = "ค้นหาลูกค้า / เปลี่ยนสาย / ปรับราคา";
            this.ToolStripSearchCustomer.Click += new System.EventHandler(this.ToolStripSearchCustomer_Click);
            // 
            // ToolStripUpdateCustomer
            // 
            this.ToolStripUpdateCustomer.Name = "ToolStripUpdateCustomer";
            this.ToolStripUpdateCustomer.Size = new System.Drawing.Size(238, 22);
            this.ToolStripUpdateCustomer.Text = "เพิ่ม/แก้ไข ข้อมูลลูกค้า";
            this.ToolStripUpdateCustomer.Click += new System.EventHandler(this.ToolStripUpdateCustomer_Click);
            // 
            // เพมสายการสงสนคาToolStripMenuItem
            // 
            this.เพมสายการสงสนคาToolStripMenuItem.Name = "เพมสายการสงสนคาToolStripMenuItem";
            this.เพมสายการสงสนคาToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.เพมสายการสงสนคาToolStripMenuItem.Text = "สายการส่งสินค้า";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripeExit
            // 
            this.ToolStripeExit.Name = "ToolStripeExit";
            this.ToolStripeExit.Size = new System.Drawing.Size(152, 22);
            this.ToolStripeExit.Text = "ออก";
            this.ToolStripeExit.Click += new System.EventHandler(this.ToolStripeExit_Click);
            // 
            // รายงานToolStripMenuItem
            // 
            this.รายงานToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.บลรายวนToolStripMenuItem,
            this.บลเกบเงนToolStripMenuItem,
            this.ใบสงของโรงงานToolStripMenuItem});
            this.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem";
            this.รายงานToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.รายงานToolStripMenuItem.Text = "รายงาน";
            // 
            // บลรายวนToolStripMenuItem
            // 
            this.บลรายวนToolStripMenuItem.Name = "บลรายวนToolStripMenuItem";
            this.บลรายวนToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.บลรายวนToolStripMenuItem.Text = "บิลลูกค้ารายวัน";
            // 
            // บลเกบเงนToolStripMenuItem
            // 
            this.บลเกบเงนToolStripMenuItem.Name = "บลเกบเงนToolStripMenuItem";
            this.บลเกบเงนToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.บลเกบเงนToolStripMenuItem.Text = "บิลเก็บเงิน";
            // 
            // ใบสงของโรงงานToolStripMenuItem
            // 
            this.ใบสงของโรงงานToolStripMenuItem.Name = "ใบสงของโรงงานToolStripMenuItem";
            this.ใบสงของโรงงานToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ใบสงของโรงงานToolStripMenuItem.Text = "ใบสั่งของโรงงาน";
            // 
            // เกยวกบToolStripMenuItem
            // 
            this.เกยวกบToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.บรษทToolStripMenuItem,
            this.toolStripSeparator2,
            this.ขอมลโปรแกรมToolStripMenuItem});
            this.เกยวกบToolStripMenuItem.Name = "เกยวกบToolStripMenuItem";
            this.เกยวกบToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.เกยวกบToolStripMenuItem.Text = "เกี่ยวกับ";
            // 
            // บรษทToolStripMenuItem
            // 
            this.บรษทToolStripMenuItem.Name = "บรษทToolStripMenuItem";
            this.บรษทToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.บรษทToolStripMenuItem.Text = "บริษัท";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // ขอมลโปรแกรมToolStripMenuItem
            // 
            this.ขอมลโปรแกรมToolStripMenuItem.Name = "ขอมลโปรแกรมToolStripMenuItem";
            this.ขอมลโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ขอมลโปรแกรมToolStripMenuItem.Text = "ข้อมูลโปรแกรม";
            // 
            // หนาตางToolStripMenuItem
            // 
            this.หนาตางToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.หนาตางToolStripMenuItem.Name = "หนาตางToolStripMenuItem";
            this.หนาตางToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.หนาตางToolStripMenuItem.Text = "หน้าต่าง";
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "โรงงานก๊วยเตี๋ยว";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem แฟมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOrder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripProduct;
        private System.Windows.Forms.ToolStripMenuItem รายงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เกยวกบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บรษทToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ขอมลโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripeExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSearchCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSearchProduct;
        private System.Windows.Forms.ToolStripMenuItem บลรายวนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บลเกบเงนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ใบสงของโรงงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem หนาตางToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมสายการสงสนคาToolStripMenuItem;
    }
}

