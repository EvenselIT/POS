namespace EvenselIT.UI
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGridPOS = new System.Windows.Forms.DataGridView();
            this.btnCustomerManagment = new System.Windows.Forms.Button();
            this.btnItemManagement = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnRetrunManagement = new System.Windows.Forms.Button();
            this.btnTransManagement = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(1130, 13);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(98, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Logged User :";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(13, 7);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(107, 20);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Customer ID :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 47);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(132, 20);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Customer Name :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnTransManagement);
            this.panel1.Controls.Add(this.btnRetrunManagement);
            this.panel1.Controls.Add(this.btnItemManagement);
            this.panel1.Controls.Add(this.btnCustomerManagment);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 651);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCustomerID);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Location = new System.Drawing.Point(225, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 77);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dGridPOS);
            this.panel3.Location = new System.Drawing.Point(226, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1071, 490);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(226, 593);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1071, 71);
            this.panel4.TabIndex = 7;
            // 
            // dGridPOS
            // 
            this.dGridPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridPOS.Location = new System.Drawing.Point(3, 3);
            this.dGridPOS.Name = "dGridPOS";
            this.dGridPOS.Size = new System.Drawing.Size(1063, 482);
            this.dGridPOS.TabIndex = 0;
            // 
            // btnCustomerManagment
            // 
            this.btnCustomerManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagment.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerManagment.Image")));
            this.btnCustomerManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerManagment.Location = new System.Drawing.Point(3, 4);
            this.btnCustomerManagment.Name = "btnCustomerManagment";
            this.btnCustomerManagment.Size = new System.Drawing.Size(199, 64);
            this.btnCustomerManagment.TabIndex = 0;
            this.btnCustomerManagment.Text = "Customer Management";
            this.btnCustomerManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerManagment.UseVisualStyleBackColor = true;
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnItemManagement.Image")));
            this.btnItemManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemManagement.Location = new System.Drawing.Point(3, 74);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.Size = new System.Drawing.Size(199, 61);
            this.btnItemManagement.TabIndex = 1;
            this.btnItemManagement.Text = "Item Managment";
            this.btnItemManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemManagement.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogout.Location = new System.Drawing.Point(1130, 39);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grand Total : ";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(932, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(134, 62);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnRetrunManagement
            // 
            this.btnRetrunManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrunManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnRetrunManagement.Image")));
            this.btnRetrunManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrunManagement.Location = new System.Drawing.Point(3, 141);
            this.btnRetrunManagement.Name = "btnRetrunManagement";
            this.btnRetrunManagement.Size = new System.Drawing.Size(199, 61);
            this.btnRetrunManagement.TabIndex = 1;
            this.btnRetrunManagement.Text = "Return Managment";
            this.btnRetrunManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetrunManagement.UseVisualStyleBackColor = true;
            this.btnRetrunManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTransManagement
            // 
            this.btnTransManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTransManagement.Image")));
            this.btnTransManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransManagement.Location = new System.Drawing.Point(3, 208);
            this.btnTransManagement.Name = "btnTransManagement";
            this.btnTransManagement.Size = new System.Drawing.Size(199, 61);
            this.btnTransManagement.TabIndex = 1;
            this.btnTransManagement.Text = "Transaction Managment";
            this.btnTransManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransManagement.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(3, 584);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(199, 61);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 676);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evensel IT POS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGridPOS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCustomerManagment;
        private System.Windows.Forms.Button btnItemManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransManagement;
        private System.Windows.Forms.Button btnRetrunManagement;
        private System.Windows.Forms.Button btnSetting;
    }
}