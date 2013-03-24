namespace NoodleStore
{
    partial class FormUpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateCustomer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddNewCustomer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripEditCustomer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CustomerDetailsPanel = new System.Windows.Forms.Panel();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxCustomerCode = new System.Windows.Forms.TextBox();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.labelCustomerCode = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.CustomerDetailsPanel.SuspendLayout();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddNewCustomer,
            this.toolStripEditCustomer,
            this.toolStripSeparator1,
            this.toolStripTextBoxSearch,
            this.toolStripSearchButton,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddNewCustomer
            // 
            this.toolStripAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddNewCustomer.Image")));
            this.toolStripAddNewCustomer.IsLink = true;
            this.toolStripAddNewCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripAddNewCustomer.LinkColor = System.Drawing.Color.Black;
            this.toolStripAddNewCustomer.Name = "toolStripAddNewCustomer";
            this.toolStripAddNewCustomer.Size = new System.Drawing.Size(110, 32);
            this.toolStripAddNewCustomer.Text = "เพิ่มข้อมูลลูกค้า";
            this.toolStripAddNewCustomer.Click += new System.EventHandler(this.toolStripAddNewCustomer_Click);
            // 
            // toolStripEditCustomer
            // 
            this.toolStripEditCustomer.Enabled = false;
            this.toolStripEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditCustomer.Image")));
            this.toolStripEditCustomer.IsLink = true;
            this.toolStripEditCustomer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripEditCustomer.LinkColor = System.Drawing.Color.Black;
            this.toolStripEditCustomer.Name = "toolStripEditCustomer";
            this.toolStripEditCustomer.Size = new System.Drawing.Size(118, 32);
            this.toolStripEditCustomer.Text = "แก้ไขข้อมูลลูกค้า";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearch.Margin = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(150, 35);
            // 
            // toolStripSearchButton
            // 
            this.toolStripSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchButton.Image")));
            this.toolStripSearchButton.IsLink = true;
            this.toolStripSearchButton.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripSearchButton.LinkColor = System.Drawing.Color.Black;
            this.toolStripSearchButton.Name = "toolStripSearchButton";
            this.toolStripSearchButton.Size = new System.Drawing.Size(66, 32);
            this.toolStripSearchButton.Text = "ค้นหา";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // CustomerDetailsPanel
            // 
            this.CustomerDetailsPanel.Controls.Add(this.groupBoxCustomerDetails);
            this.CustomerDetailsPanel.Location = new System.Drawing.Point(12, 38);
            this.CustomerDetailsPanel.Name = "CustomerDetailsPanel";
            this.CustomerDetailsPanel.Size = new System.Drawing.Size(273, 362);
            this.CustomerDetailsPanel.TabIndex = 2;
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.buttonDelete);
            this.groupBoxCustomerDetails.Controls.Add(this.buttonCancel);
            this.groupBoxCustomerDetails.Controls.Add(this.buttonSave);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxPhone);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxCompany);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomerDetails.Controls.Add(this.textBoxCustomerCode);
            this.groupBoxCustomerDetails.Controls.Add(this.comboBoxLine);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerCode);
            this.groupBoxCustomerDetails.Controls.Add(this.labelLine);
            this.groupBoxCustomerDetails.Controls.Add(this.labelEmail);
            this.groupBoxCustomerDetails.Controls.Add(this.labelAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.labelPhoneNumber);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCompany);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomerDetails.Enabled = false;
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(267, 356);
            this.groupBoxCustomerDetails.TabIndex = 6;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "ข้อมูลลูกค้า";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(188, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 41);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "ลบ";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseMnemonic = false;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(105, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(73, 41);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "ยกเลิก";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseMnemonic = false;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(21, 291);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(73, 41);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "บันทึก";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseMnemonic = false;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 207);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 157);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(140, 39);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(107, 124);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(107, 94);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(140, 20);
            this.textBoxCompany.TabIndex = 2;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(107, 61);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(140, 20);
            this.textBoxCustomerName.TabIndex = 1;
            // 
            // textBoxCustomerCode
            // 
            this.textBoxCustomerCode.Enabled = false;
            this.textBoxCustomerCode.Location = new System.Drawing.Point(107, 30);
            this.textBoxCustomerCode.Name = "textBoxCustomerCode";
            this.textBoxCustomerCode.ReadOnly = true;
            this.textBoxCustomerCode.Size = new System.Drawing.Size(74, 20);
            this.textBoxCustomerCode.TabIndex = 0;
            this.textBoxCustomerCode.TabStop = false;
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Location = new System.Drawing.Point(107, 242);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(140, 21);
            this.comboBoxLine.TabIndex = 6;
            // 
            // labelCustomerCode
            // 
            this.labelCustomerCode.AutoSize = true;
            this.labelCustomerCode.Location = new System.Drawing.Point(20, 33);
            this.labelCustomerCode.Name = "labelCustomerCode";
            this.labelCustomerCode.Size = new System.Drawing.Size(57, 13);
            this.labelCustomerCode.TabIndex = 6;
            this.labelCustomerCode.Text = "รหัสลูกค้า :";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(20, 245);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(59, 13);
            this.labelLine.TabIndex = 5;
            this.labelLine.Text = "สายส่งของ :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 210);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "อีเมล :";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(20, 160);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(33, 13);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "ที่อยู่ :";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(20, 127);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 2;
            this.labelPhoneNumber.Text = "เบอร์โทรศัพท์ :";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(20, 97);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(41, 13);
            this.labelCompany.TabIndex = 1;
            this.labelCompany.Text = "บริษัท :";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(20, 64);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(74, 13);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "ชือ - นามสกุล :";
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CustomerDetailsPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormUpdateCustomer";
            this.Text = "FormUpdateCustomer";
            this.Load += new System.EventHandler(this.FormUpdateCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CustomerDetailsPanel.ResumeLayout(false);
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripAddNewCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripEditCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripSearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel CustomerDetailsPanel;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCustomerCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerCode;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;

    }
}