namespace NoodleStore
{
    partial class FormSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchCustomer));
            this.toolStripSearchCustomer = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxSearchCustomer = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelChangeLine = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChangePrice = new System.Windows.Forms.ToolStripLabel();
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
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
            this.toolStripSearchCustomer.SuspendLayout();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSearchCustomer
            // 
            this.toolStripSearchCustomer.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripSearchCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearchCustomer,
            this.toolStripSearchLabel,
            this.toolStripSeparator1,
            this.toolStripLabelChangeLine,
            this.toolStripLabelChangePrice});
            this.toolStripSearchCustomer.Location = new System.Drawing.Point(0, 0);
            this.toolStripSearchCustomer.Name = "toolStripSearchCustomer";
            this.toolStripSearchCustomer.Size = new System.Drawing.Size(784, 35);
            this.toolStripSearchCustomer.TabIndex = 0;
            this.toolStripSearchCustomer.Text = "toolStrip1";
            // 
            // toolStripTextBoxSearchCustomer
            // 
            this.toolStripTextBoxSearchCustomer.BackColor = System.Drawing.Color.Silver;
            this.toolStripTextBoxSearchCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxSearchCustomer.Name = "toolStripTextBoxSearchCustomer";
            this.toolStripTextBoxSearchCustomer.Size = new System.Drawing.Size(150, 35);
            // 
            // toolStripSearchLabel
            // 
            this.toolStripSearchLabel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSearchLabel.Image")));
            this.toolStripSearchLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSearchLabel.IsLink = true;
            this.toolStripSearchLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripSearchLabel.LinkColor = System.Drawing.Color.Black;
            this.toolStripSearchLabel.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripSearchLabel.Name = "toolStripSearchLabel";
            this.toolStripSearchLabel.Size = new System.Drawing.Size(66, 32);
            this.toolStripSearchLabel.Text = "ค้นหา";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabelChangeLine
            // 
            this.toolStripLabelChangeLine.Name = "toolStripLabelChangeLine";
            this.toolStripLabelChangeLine.Size = new System.Drawing.Size(58, 32);
            this.toolStripLabelChangeLine.Text = "เปลี่ยนสาย";
            // 
            // toolStripLabelChangePrice
            // 
            this.toolStripLabelChangePrice.Name = "toolStripLabelChangePrice";
            this.toolStripLabelChangePrice.Size = new System.Drawing.Size(50, 32);
            this.toolStripLabelChangePrice.Text = "ปรับราคา";
            // 
            // groupBoxCustomerDetails
            // 
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
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(12, 38);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(267, 356);
            this.groupBoxCustomerDetails.TabIndex = 7;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "ข้อมูลลูกค้า";
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
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(107, 157);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(140, 39);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(107, 124);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.TabStop = false;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(107, 94);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.ReadOnly = true;
            this.textBoxCompany.Size = new System.Drawing.Size(140, 20);
            this.textBoxCompany.TabIndex = 2;
            this.textBoxCompany.TabStop = false;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(107, 61);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.ReadOnly = true;
            this.textBoxCustomerName.Size = new System.Drawing.Size(140, 20);
            this.textBoxCustomerName.TabIndex = 1;
            this.textBoxCustomerName.TabStop = false;
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
            this.comboBoxLine.Enabled = false;
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
            // FormSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Controls.Add(this.toolStripSearchCustomer);
            this.Name = "FormSearchCustomer";
            this.Text = "FormSearchCustomer";
            this.toolStripSearchCustomer.ResumeLayout(false);
            this.toolStripSearchCustomer.PerformLayout();
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSearchCustomer;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearchCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripSearchLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.TextBox textBoxCustomerCode;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.Label labelCustomerCode;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChangeLine;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChangePrice;
    }
}