namespace EvenselIT.UI.subForms
{
    partial class subFormSupplierManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subFormSupplierManagement));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSupplierManagement = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.dGridAllSuppliers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierAccNo = new System.Windows.Forms.TextBox();
            this.txtSupplierTelephoneNo = new System.Windows.Forms.TextBox();
            this.rtxtSupplierAddress = new System.Windows.Forms.RichTextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.txtSupAccNo = new System.Windows.Forms.TextBox();
            this.txtSupTelephoneNo = new System.Windows.Forms.TextBox();
            this.rtxtSupAddress = new System.Windows.Forms.RichTextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSupEmail = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControlSupplierManagement.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllSuppliers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControlSupplierManagement
            // 
            this.tabControlSupplierManagement.Controls.Add(this.tabPage1);
            this.tabControlSupplierManagement.Controls.Add(this.tabPage2);
            this.tabControlSupplierManagement.Controls.Add(this.tabPage3);
            this.tabControlSupplierManagement.Location = new System.Drawing.Point(13, 53);
            this.tabControlSupplierManagement.Name = "tabControlSupplierManagement";
            this.tabControlSupplierManagement.SelectedIndex = 0;
            this.tabControlSupplierManagement.Size = new System.Drawing.Size(662, 406);
            this.tabControlSupplierManagement.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectSupplier);
            this.tabPage1.Controls.Add(this.dGridAllSuppliers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Supplier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.Image = global::EvenselIT.UI.Properties.Resources.select;
            this.btnSelectSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectSupplier.Location = new System.Drawing.Point(245, 326);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(142, 48);
            this.btnSelectSupplier.TabIndex = 1;
            this.btnSelectSupplier.Text = "Select Supplier";
            this.btnSelectSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            // 
            // dGridAllSuppliers
            // 
            this.dGridAllSuppliers.AllowUserToAddRows = false;
            this.dGridAllSuppliers.CausesValidation = false;
            this.dGridAllSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAllSuppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dGridAllSuppliers.Location = new System.Drawing.Point(3, 3);
            this.dGridAllSuppliers.MultiSelect = false;
            this.dGridAllSuppliers.Name = "dGridAllSuppliers";
            this.dGridAllSuppliers.ReadOnly = true;
            this.dGridAllSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridAllSuppliers.Size = new System.Drawing.Size(648, 317);
            this.dGridAllSuppliers.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSupplierEmail);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnAddSupplier);
            this.tabPage2.Controls.Add(this.txtSupplierAccNo);
            this.tabPage2.Controls.Add(this.txtSupplierTelephoneNo);
            this.tabPage2.Controls.Add(this.rtxtSupplierAddress);
            this.tabPage2.Controls.Add(this.txtSupplierName);
            this.tabPage2.Controls.Add(this.txtSupplierId);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Supplier";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.Image")));
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(263, 306);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 59);
            this.btnAddSupplier.TabIndex = 10;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierAccNo
            // 
            this.txtSupplierAccNo.Location = new System.Drawing.Point(206, 266);
            this.txtSupplierAccNo.Name = "txtSupplierAccNo";
            this.txtSupplierAccNo.Size = new System.Drawing.Size(184, 20);
            this.txtSupplierAccNo.TabIndex = 9;
            // 
            // txtSupplierTelephoneNo
            // 
            this.txtSupplierTelephoneNo.Location = new System.Drawing.Point(206, 238);
            this.txtSupplierTelephoneNo.Name = "txtSupplierTelephoneNo";
            this.txtSupplierTelephoneNo.Size = new System.Drawing.Size(132, 20);
            this.txtSupplierTelephoneNo.TabIndex = 8;
            // 
            // rtxtSupplierAddress
            // 
            this.rtxtSupplierAddress.Location = new System.Drawing.Point(206, 127);
            this.rtxtSupplierAddress.Name = "rtxtSupplierAddress";
            this.rtxtSupplierAddress.Size = new System.Drawing.Size(184, 64);
            this.rtxtSupplierAddress.TabIndex = 7;
            this.rtxtSupplierAddress.Text = "";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(206, 93);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(184, 20);
            this.txtSupplierName.TabIndex = 6;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Location = new System.Drawing.Point(206, 57);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(184, 20);
            this.txtSupplierId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSupEmail);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnUpdateSupplier);
            this.tabPage3.Controls.Add(this.txtSupAccNo);
            this.tabPage3.Controls.Add(this.txtSupTelephoneNo);
            this.tabPage3.Controls.Add(this.rtxtSupAddress);
            this.tabPage3.Controls.Add(this.txtSupName);
            this.tabPage3.Controls.Add(this.txtSupId);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(654, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Edit Suppliers Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.Image = global::EvenselIT.UI.Properties.Resources.edit;
            this.btnUpdateSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(265, 305);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(127, 59);
            this.btnUpdateSupplier.TabIndex = 20;
            this.btnUpdateSupplier.Text = "Update Supplier";
            this.btnUpdateSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSupplier.UseVisualStyleBackColor = true;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // txtSupAccNo
            // 
            this.txtSupAccNo.Location = new System.Drawing.Point(208, 268);
            this.txtSupAccNo.Name = "txtSupAccNo";
            this.txtSupAccNo.Size = new System.Drawing.Size(184, 20);
            this.txtSupAccNo.TabIndex = 19;
            // 
            // txtSupTelephoneNo
            // 
            this.txtSupTelephoneNo.Location = new System.Drawing.Point(208, 240);
            this.txtSupTelephoneNo.Name = "txtSupTelephoneNo";
            this.txtSupTelephoneNo.Size = new System.Drawing.Size(132, 20);
            this.txtSupTelephoneNo.TabIndex = 18;
            // 
            // rtxtSupAddress
            // 
            this.rtxtSupAddress.Location = new System.Drawing.Point(208, 129);
            this.rtxtSupAddress.Name = "rtxtSupAddress";
            this.rtxtSupAddress.Size = new System.Drawing.Size(184, 64);
            this.rtxtSupAddress.TabIndex = 17;
            this.rtxtSupAddress.Text = "";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(208, 95);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(184, 20);
            this.txtSupName.TabIndex = 16;
            // 
            // txtSupId
            // 
            this.txtSupId.Location = new System.Drawing.Point(208, 59);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(184, 20);
            this.txtSupId.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telephone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Supplier Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Email";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(206, 203);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(184, 20);
            this.txtSupplierEmail.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Email";
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Location = new System.Drawing.Point(208, 208);
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.Size = new System.Drawing.Size(184, 20);
            this.txtSupEmail.TabIndex = 22;
            // 
            // subFormSupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 471);
            this.Controls.Add(this.tabControlSupplierManagement);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "subFormSupplierManagement";
            this.Text = "Supplier Management";
            this.Load += new System.EventHandler(this.subFormSupplierManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlSupplierManagement.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllSuppliers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlSupplierManagement;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupplierAccNo;
        private System.Windows.Forms.TextBox txtSupplierTelephoneNo;
        private System.Windows.Forms.RichTextBox rtxtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.TextBox txtSupAccNo;
        private System.Windows.Forms.TextBox txtSupTelephoneNo;
        private System.Windows.Forms.RichTextBox rtxtSupAddress;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dGridAllSuppliers;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupEmail;
        private System.Windows.Forms.Label label12;
    }
}