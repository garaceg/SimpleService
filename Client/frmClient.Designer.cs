namespace Client
{
    partial class frmClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetID = new System.Windows.Forms.Button();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtCodeName = new System.Windows.Forms.TextBox();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.txtProductionDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetID
            // 
            this.btnGetID.Location = new System.Drawing.Point(154, 57);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(109, 23);
            this.btnGetID.TabIndex = 0;
            this.btnGetID.Text = "Get Product Info";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(48, 39);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(60, 15);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "ProductID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(48, 57);
            this.txtProductID.MaxLength = 10;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 23);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductID_KeyPress);
            // 
            // txtCodeName
            // 
            this.txtCodeName.Location = new System.Drawing.Point(43, 169);
            this.txtCodeName.MaxLength = 10;
            this.txtCodeName.Name = "txtCodeName";
            this.txtCodeName.ReadOnly = true;
            this.txtCodeName.Size = new System.Drawing.Size(100, 23);
            this.txtCodeName.TabIndex = 4;
            // 
            // lblCodeName
            // 
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.Location = new System.Drawing.Point(43, 151);
            this.lblCodeName.Name = "lblCodeName";
            this.lblCodeName.Size = new System.Drawing.Size(70, 15);
            this.lblCodeName.TabIndex = 5;
            this.lblCodeName.Text = "Code Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(154, 151);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(154, 169);
            this.txtDescription.MaxLength = 10;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(272, 23);
            this.txtDescription.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(432, 169);
            this.txtCategory.MaxLength = 10;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(72, 23);
            this.txtCategory.TabIndex = 8;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(432, 151);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(43, 216);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(43, 234);
            this.txtColor.MaxLength = 10;
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(100, 23);
            this.txtColor.TabIndex = 11;
            // 
            // lblProductionDate
            // 
            this.lblProductionDate.AutoSize = true;
            this.lblProductionDate.Location = new System.Drawing.Point(154, 216);
            this.lblProductionDate.Name = "lblProductionDate";
            this.lblProductionDate.Size = new System.Drawing.Size(93, 15);
            this.lblProductionDate.TabIndex = 12;
            this.lblProductionDate.Text = "Production Date";
            // 
            // txtProductionDate
            // 
            this.txtProductionDate.Location = new System.Drawing.Point(154, 234);
            this.txtProductionDate.MaxLength = 10;
            this.txtProductionDate.Name = "txtProductionDate";
            this.txtProductionDate.ReadOnly = true;
            this.txtProductionDate.Size = new System.Drawing.Size(100, 23);
            this.txtProductionDate.TabIndex = 13;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.txtProductionDate);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCodeName);
            this.Controls.Add(this.txtCodeName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.btnGetID);
            this.Name = "frmClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetID;
        private Label lblProductID;
        private TextBox txtProductID;
        private TextBox txtCodeName;
        private Label lblCodeName;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private Label lblCategory;
        private Label lblColor;
        private TextBox txtColor;
        private Label lblProductionDate;
        private TextBox txtProductionDate;
    }
}