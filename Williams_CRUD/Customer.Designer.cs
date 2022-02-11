
namespace Williams_CRUD
{
    partial class Customer
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
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.IDLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.comanyNameLabel = new System.Windows.Forms.Label();
            this.salesPersonLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressTypeLabel = new System.Windows.Forms.Label();
            this.addressLine1Label = new System.Windows.Forms.Label();
            this.addressLine2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateProvinceLabel = new System.Windows.Forms.Label();
            this.countryRegionLabel = new System.Windows.Forms.Label();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.suffixTB = new System.Windows.Forms.TextBox();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.emailAddressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.salesPersonTB = new System.Windows.Forms.TextBox();
            this.addressTypeTB = new System.Windows.Forms.TextBox();
            this.addressLine1TB = new System.Windows.Forms.TextBox();
            this.addressLine2TB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateProvinceTB = new System.Windows.Forms.TextBox();
            this.countryRegionTB = new System.Windows.Forms.TextBox();
            this.postalCodeTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.Location = new System.Drawing.Point(12, 173);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.Size = new System.Drawing.Size(776, 361);
            this.CustomerGridView.TabIndex = 0;
            this.CustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellContentClick);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(25, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(131, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(238, 9);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(346, 9);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(69, 13);
            this.middleNameLabel.TabIndex = 4;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(452, 9);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(559, 9);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 6;
            this.suffixLabel.Text = "Suffix";
            // 
            // comanyNameLabel
            // 
            this.comanyNameLabel.AutoSize = true;
            this.comanyNameLabel.Location = new System.Drawing.Point(666, 9);
            this.comanyNameLabel.Name = "comanyNameLabel";
            this.comanyNameLabel.Size = new System.Drawing.Size(82, 13);
            this.comanyNameLabel.TabIndex = 7;
            this.comanyNameLabel.Text = "Company Name";
            // 
            // salesPersonLabel
            // 
            this.salesPersonLabel.AutoSize = true;
            this.salesPersonLabel.Location = new System.Drawing.Point(238, 59);
            this.salesPersonLabel.Name = "salesPersonLabel";
            this.salesPersonLabel.Size = new System.Drawing.Size(69, 13);
            this.salesPersonLabel.TabIndex = 8;
            this.salesPersonLabel.Text = "Sales Person";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Location = new System.Drawing.Point(25, 60);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.emailAddressLabel.TabIndex = 9;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(131, 60);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // addressTypeLabel
            // 
            this.addressTypeLabel.AutoSize = true;
            this.addressTypeLabel.Location = new System.Drawing.Point(346, 59);
            this.addressTypeLabel.Name = "addressTypeLabel";
            this.addressTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.addressTypeLabel.TabIndex = 11;
            this.addressTypeLabel.Text = "Address Type";
            // 
            // addressLine1Label
            // 
            this.addressLine1Label.AutoSize = true;
            this.addressLine1Label.Location = new System.Drawing.Point(452, 60);
            this.addressLine1Label.Name = "addressLine1Label";
            this.addressLine1Label.Size = new System.Drawing.Size(77, 13);
            this.addressLine1Label.TabIndex = 12;
            this.addressLine1Label.Text = "Address Line 1";
            // 
            // addressLine2Label
            // 
            this.addressLine2Label.AutoSize = true;
            this.addressLine2Label.Location = new System.Drawing.Point(559, 60);
            this.addressLine2Label.Name = "addressLine2Label";
            this.addressLine2Label.Size = new System.Drawing.Size(77, 13);
            this.addressLine2Label.TabIndex = 13;
            this.addressLine2Label.Text = "Address Line 2";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(666, 60);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "City";
            // 
            // stateProvinceLabel
            // 
            this.stateProvinceLabel.AutoSize = true;
            this.stateProvinceLabel.Location = new System.Drawing.Point(238, 108);
            this.stateProvinceLabel.Name = "stateProvinceLabel";
            this.stateProvinceLabel.Size = new System.Drawing.Size(89, 13);
            this.stateProvinceLabel.TabIndex = 15;
            this.stateProvinceLabel.Text = "State or Province";
            // 
            // countryRegionLabel
            // 
            this.countryRegionLabel.AutoSize = true;
            this.countryRegionLabel.Location = new System.Drawing.Point(346, 108);
            this.countryRegionLabel.Name = "countryRegionLabel";
            this.countryRegionLabel.Size = new System.Drawing.Size(92, 13);
            this.countryRegionLabel.TabIndex = 16;
            this.countryRegionLabel.Text = "Country or Region";
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(452, 108);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.postalCodeLabel.TabIndex = 17;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // IDTB
            // 
            this.IDTB.Location = new System.Drawing.Point(28, 26);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(100, 20);
            this.IDTB.TabIndex = 18;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(134, 26);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 19;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(240, 26);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 20;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(346, 26);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(100, 20);
            this.middleNameTB.TabIndex = 21;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(453, 25);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(100, 20);
            this.lastNameTB.TabIndex = 22;
            // 
            // suffixTB
            // 
            this.suffixTB.Location = new System.Drawing.Point(560, 25);
            this.suffixTB.Name = "suffixTB";
            this.suffixTB.Size = new System.Drawing.Size(100, 20);
            this.suffixTB.TabIndex = 23;
            // 
            // companyNameTB
            // 
            this.companyNameTB.Location = new System.Drawing.Point(667, 25);
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.Size = new System.Drawing.Size(100, 20);
            this.companyNameTB.TabIndex = 24;
            // 
            // emailAddressTB
            // 
            this.emailAddressTB.Location = new System.Drawing.Point(28, 75);
            this.emailAddressTB.Name = "emailAddressTB";
            this.emailAddressTB.Size = new System.Drawing.Size(100, 20);
            this.emailAddressTB.TabIndex = 25;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(132, 75);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 26;
            // 
            // salesPersonTB
            // 
            this.salesPersonTB.Location = new System.Drawing.Point(239, 75);
            this.salesPersonTB.Name = "salesPersonTB";
            this.salesPersonTB.Size = new System.Drawing.Size(100, 20);
            this.salesPersonTB.TabIndex = 27;
            // 
            // addressTypeTB
            // 
            this.addressTypeTB.Location = new System.Drawing.Point(346, 75);
            this.addressTypeTB.Name = "addressTypeTB";
            this.addressTypeTB.Size = new System.Drawing.Size(100, 20);
            this.addressTypeTB.TabIndex = 28;
            // 
            // addressLine1TB
            // 
            this.addressLine1TB.Location = new System.Drawing.Point(453, 75);
            this.addressLine1TB.Name = "addressLine1TB";
            this.addressLine1TB.Size = new System.Drawing.Size(100, 20);
            this.addressLine1TB.TabIndex = 29;
            // 
            // addressLine2TB
            // 
            this.addressLine2TB.Location = new System.Drawing.Point(560, 75);
            this.addressLine2TB.Name = "addressLine2TB";
            this.addressLine2TB.Size = new System.Drawing.Size(100, 20);
            this.addressLine2TB.TabIndex = 30;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(667, 75);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(100, 20);
            this.cityTB.TabIndex = 31;
            // 
            // stateProvinceTB
            // 
            this.stateProvinceTB.Location = new System.Drawing.Point(241, 125);
            this.stateProvinceTB.Name = "stateProvinceTB";
            this.stateProvinceTB.Size = new System.Drawing.Size(100, 20);
            this.stateProvinceTB.TabIndex = 32;
            // 
            // countryRegionTB
            // 
            this.countryRegionTB.Location = new System.Drawing.Point(346, 125);
            this.countryRegionTB.Name = "countryRegionTB";
            this.countryRegionTB.Size = new System.Drawing.Size(100, 20);
            this.countryRegionTB.TabIndex = 33;
            // 
            // postalCodeTB
            // 
            this.postalCodeTB.Location = new System.Drawing.Point(453, 125);
            this.postalCodeTB.Name = "postalCodeTB";
            this.postalCodeTB.Size = new System.Drawing.Size(100, 20);
            this.postalCodeTB.TabIndex = 34;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(28, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 23);
            this.addButton.TabIndex = 35;
            this.addButton.Text = "Add New Info";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(132, 122);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 36;
            this.updateButton.Text = "Update Existing";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(562, 122);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(98, 23);
            this.getInfoButton.TabIndex = 37;
            this.getInfoButton.Text = "Get Information";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(669, 122);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "Delete Info";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.postalCodeTB);
            this.Controls.Add(this.countryRegionTB);
            this.Controls.Add(this.stateProvinceTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressLine2TB);
            this.Controls.Add(this.addressLine1TB);
            this.Controls.Add(this.addressTypeTB);
            this.Controls.Add(this.salesPersonTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.emailAddressTB);
            this.Controls.Add(this.companyNameTB);
            this.Controls.Add(this.suffixTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.countryRegionLabel);
            this.Controls.Add(this.stateProvinceLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLine2Label);
            this.Controls.Add(this.addressLine1Label);
            this.Controls.Add(this.addressTypeLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.salesPersonLabel);
            this.Controls.Add(this.comanyNameLabel);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.Label comanyNameLabel;
        private System.Windows.Forms.Label salesPersonLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressTypeLabel;
        private System.Windows.Forms.Label addressLine1Label;
        private System.Windows.Forms.Label addressLine2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateProvinceLabel;
        private System.Windows.Forms.Label countryRegionLabel;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox suffixTB;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.TextBox emailAddressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox salesPersonTB;
        private System.Windows.Forms.TextBox addressTypeTB;
        private System.Windows.Forms.TextBox addressLine1TB;
        private System.Windows.Forms.TextBox addressLine2TB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox stateProvinceTB;
        private System.Windows.Forms.TextBox countryRegionTB;
        private System.Windows.Forms.TextBox postalCodeTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button deleteButton;
    }
}