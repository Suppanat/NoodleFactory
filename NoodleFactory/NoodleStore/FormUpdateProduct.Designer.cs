namespace NoodleStore
{
    partial class FormUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateProduct));
            this.toolStripUpdateProduct = new System.Windows.Forms.ToolStrip();
            this.toolStripAddNewProduct = new System.Windows.Forms.ToolStripLabel();
            this.toolStripEditProduct = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearchProduct = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchButtonProduct = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProductDetailsPanel = new System.Windows.Forms.Panel();
            this.groupBoxProductDetails = new System.Windows.Forms.GroupBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonCancelProduct = new System.Windows.Forms.Button();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.textBoxProductDetails = new System.Windows.Forms.TextBox();
            this.textBoxProductAmount = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductCategory = new System.Windows.Forms.TextBox();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.labelProductDetails = new System.Windows.Forms.Label();
            this.labelProductAmount = new System.Windows.Forms.Label();
            this.labelProductCategory = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.toolStripUpdateProduct.SuspendLayout();
            this.ProductDetailsPanel.SuspendLayout();
            this.groupBoxProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripUpdateProduct
            // 
            this.toolStripUpdateProduct.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripUpdateProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddNewProduct,
            this.toolStripEditProduct,
            this.toolStripSeparator1,
            this.toolStripTextBoxSearchProduct,
            this.toolStripSearchButtonProduct,
            this.toolStripSeparator2});
            this.toolStripUpdateProduct.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripUpdateProduct.Location = new System.Drawing.Point(0, 0);
            this.toolStripUpdateProduct.Name = "toolStripUpdateProduct";
            this.toolStripUpdateProduct.Size = new System.Drawing.Size(784, 35);
            this.toolStripUpdateProduct.TabIndex = 0;
            this.toolStripUpdateProduct.Text = "toolStrip1";
            // 
            // toolStripAddNewProduct
            // 
            this.toolStripAddNewProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddNewProduct.Image")));
            this.toolStripAddNewProduct.IsLink = true;
            this.toolStripAddNewProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripAddNewProduct.LinkColor = System.Drawing.Color.Black;
            this.toolStripAddNewProduct.Name = "toolStripAddNewProduct";
            this.toolStripAddNewProduct.Size = new System.Drawing.Size(111, 32);
            this.toolStripAddNewProduct.Text = "เพิ่มข้อมูลสินค้า";
            this.toolStripAddNewProduct.Click += new System.EventHandler(this.toolStripAddNewProduct_Click);
            // 
            // toolStripEditProduct
            // 
            this.toolStripEditProduct.Enabled = false;
            this.toolStripEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditProduct.Image")));
            this.toolStripEditProduct.IsLink = true;
            this.toolStripEditProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripEditProduct.LinkColor = System.Drawing.Color.Black;
            this.toolStripEditProduct.Name = "toolStripEditProduct";
            this.toolStripEditProduct.Size = new System.Drawing.Size(119, 32);
            this.toolStripEditProduct.Text = "แก้ไขข้อมูลสินค้า";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripTextBoxSearchProduct
            // 
            this.toolStripTextBoxSearchProduct.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearchProduct.Margin = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.toolStripTextBoxSearchProduct.Name = "toolStripTextBoxSearchProduct";
            this.toolStripTextBoxSearchProduct.Size = new System.Drawing.Size(150, 35);
            // 
            // toolStripSearchButtonProduct
            // 
            this.toolStripSearchButtonProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchButtonProduct.Image")));
            this.toolStripSearchButtonProduct.IsLink = true;
            this.toolStripSearchButtonProduct.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripSearchButtonProduct.LinkColor = System.Drawing.Color.Black;
            this.toolStripSearchButtonProduct.Name = "toolStripSearchButtonProduct";
            this.toolStripSearchButtonProduct.Size = new System.Drawing.Size(66, 32);
            this.toolStripSearchButtonProduct.Text = "ค้นหา";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // ProductDetailsPanel
            // 
            this.ProductDetailsPanel.Controls.Add(this.groupBoxProductDetails);
            this.ProductDetailsPanel.Location = new System.Drawing.Point(12, 38);
            this.ProductDetailsPanel.Name = "ProductDetailsPanel";
            this.ProductDetailsPanel.Size = new System.Drawing.Size(273, 319);
            this.ProductDetailsPanel.TabIndex = 4;
            // 
            // groupBoxProductDetails
            // 
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductPrice);
            this.groupBoxProductDetails.Controls.Add(this.labelProductPrice);
            this.groupBoxProductDetails.Controls.Add(this.buttonDeleteProduct);
            this.groupBoxProductDetails.Controls.Add(this.buttonCancelProduct);
            this.groupBoxProductDetails.Controls.Add(this.buttonSaveProduct);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductDetails);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductAmount);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductName);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.textBoxProductCode);
            this.groupBoxProductDetails.Controls.Add(this.labelProductCode);
            this.groupBoxProductDetails.Controls.Add(this.labelProductDetails);
            this.groupBoxProductDetails.Controls.Add(this.labelProductAmount);
            this.groupBoxProductDetails.Controls.Add(this.labelProductCategory);
            this.groupBoxProductDetails.Controls.Add(this.labelProductName);
            this.groupBoxProductDetails.Enabled = false;
            this.groupBoxProductDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxProductDetails.Name = "groupBoxProductDetails";
            this.groupBoxProductDetails.Size = new System.Drawing.Size(267, 315);
            this.groupBoxProductDetails.TabIndex = 6;
            this.groupBoxProductDetails.TabStop = false;
            this.groupBoxProductDetails.Text = "ข้อมูลสินค้า";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(107, 156);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(140, 20);
            this.textBoxProductPrice.TabIndex = 11;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(20, 159);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(36, 13);
            this.labelProductPrice.TabIndex = 10;
            this.labelProductPrice.Text = "ราคา :";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteProduct.Image")));
            this.buttonDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(189, 252);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(58, 41);
            this.buttonDeleteProduct.TabIndex = 9;
            this.buttonDeleteProduct.Text = "ลบ";
            this.buttonDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteProduct.UseMnemonic = false;
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonCancelProduct
            // 
            this.buttonCancelProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelProduct.Image")));
            this.buttonCancelProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelProduct.Location = new System.Drawing.Point(107, 252);
            this.buttonCancelProduct.Name = "buttonCancelProduct";
            this.buttonCancelProduct.Size = new System.Drawing.Size(73, 41);
            this.buttonCancelProduct.TabIndex = 8;
            this.buttonCancelProduct.Text = "ยกเลิก";
            this.buttonCancelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelProduct.UseMnemonic = false;
            this.buttonCancelProduct.UseVisualStyleBackColor = true;
            this.buttonCancelProduct.Click += new System.EventHandler(this.buttonCancelProduct_Click);
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveProduct.Image")));
            this.buttonSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveProduct.Location = new System.Drawing.Point(23, 252);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(73, 41);
            this.buttonSaveProduct.TabIndex = 7;
            this.buttonSaveProduct.Text = "บันทึก";
            this.buttonSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveProduct.UseMnemonic = false;
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxProductDetails
            // 
            this.textBoxProductDetails.Location = new System.Drawing.Point(107, 192);
            this.textBoxProductDetails.Multiline = true;
            this.textBoxProductDetails.Name = "textBoxProductDetails";
            this.textBoxProductDetails.Size = new System.Drawing.Size(140, 39);
            this.textBoxProductDetails.TabIndex = 4;
            // 
            // textBoxProductAmount
            // 
            this.textBoxProductAmount.Location = new System.Drawing.Point(107, 124);
            this.textBoxProductAmount.Name = "textBoxProductAmount";
            this.textBoxProductAmount.Size = new System.Drawing.Size(140, 20);
            this.textBoxProductAmount.TabIndex = 3;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(107, 94);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(140, 20);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxProductCategory
            // 
            this.textBoxProductCategory.Location = new System.Drawing.Point(107, 61);
            this.textBoxProductCategory.Name = "textBoxProductCategory";
            this.textBoxProductCategory.Size = new System.Drawing.Size(140, 20);
            this.textBoxProductCategory.TabIndex = 1;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Enabled = false;
            this.textBoxProductCode.Location = new System.Drawing.Point(107, 30);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(74, 20);
            this.textBoxProductCode.TabIndex = 0;
            this.textBoxProductCode.TabStop = false;
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Location = new System.Drawing.Point(20, 33);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(58, 13);
            this.labelProductCode.TabIndex = 6;
            this.labelProductCode.Text = "รหัสสินค้า :";
            // 
            // labelProductDetails
            // 
            this.labelProductDetails.AutoSize = true;
            this.labelProductDetails.Location = new System.Drawing.Point(20, 195);
            this.labelProductDetails.Name = "labelProductDetails";
            this.labelProductDetails.Size = new System.Drawing.Size(67, 13);
            this.labelProductDetails.TabIndex = 3;
            this.labelProductDetails.Text = "รายละเอียด :";
            // 
            // labelProductAmount
            // 
            this.labelProductAmount.AutoSize = true;
            this.labelProductAmount.Location = new System.Drawing.Point(20, 127);
            this.labelProductAmount.Name = "labelProductAmount";
            this.labelProductAmount.Size = new System.Drawing.Size(47, 13);
            this.labelProductAmount.TabIndex = 2;
            this.labelProductAmount.Text = "ปริมาณ :";
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.AutoSize = true;
            this.labelProductCategory.Location = new System.Drawing.Point(20, 64);
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(50, 13);
            this.labelProductCategory.TabIndex = 1;
            this.labelProductCategory.Text = "ประเภท :";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(20, 97);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(52, 13);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "ชื่อสินค้่า :";
            // 
            // FormUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.toolStripUpdateProduct);
            this.Controls.Add(this.ProductDetailsPanel);
            this.Name = "FormUpdateProduct";
            this.Text = "FormUpdateProduct";
            this.toolStripUpdateProduct.ResumeLayout(false);
            this.toolStripUpdateProduct.PerformLayout();
            this.ProductDetailsPanel.ResumeLayout(false);
            this.groupBoxProductDetails.ResumeLayout(false);
            this.groupBoxProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUpdateProduct;
        private System.Windows.Forms.ToolStripLabel toolStripAddNewProduct;
        private System.Windows.Forms.ToolStripLabel toolStripEditProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchProduct;
        private System.Windows.Forms.ToolStripLabel toolStripSearchButtonProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel ProductDetailsPanel;
        private System.Windows.Forms.GroupBox groupBoxProductDetails;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonCancelProduct;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.TextBox textBoxProductDetails;
        private System.Windows.Forms.TextBox textBoxProductAmount;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductCategory;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.Label labelProductDetails;
        private System.Windows.Forms.Label labelProductAmount;
        private System.Windows.Forms.Label labelProductCategory;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label labelProductPrice;

    }
}