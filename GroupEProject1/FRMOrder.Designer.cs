namespace GroupEProject1
{
    partial class FRMOrder
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
            this.RDOCarryout = new System.Windows.Forms.RadioButton();
            this.RDODelivery = new System.Windows.Forms.RadioButton();
            this.GBXCarryoutOrDelivery = new System.Windows.Forms.GroupBox();
            this.GBXCustomerInformation = new System.Windows.Forms.GroupBox();
            this.CHKSameAsDelivery = new System.Windows.Forms.CheckBox();
            this.TXTPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTZipCode = new System.Windows.Forms.TextBox();
            this.TXTState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTStreetAddress = new System.Windows.Forms.TextBox();
            this.TXTCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTSubdivision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBXDeliveryAddress = new System.Windows.Forms.GroupBox();
            this.TXTDeliveryPhoneNumber = new System.Windows.Forms.TextBox();
            this.TXTDeliverySubDivision = new System.Windows.Forms.TextBox();
            this.TXTDeliveryZipCode = new System.Windows.Forms.TextBox();
            this.TXTDeliveryState = new System.Windows.Forms.TextBox();
            this.TXTDeliveryCity = new System.Windows.Forms.TextBox();
            this.TXTDeliveryStreet = new System.Windows.Forms.TextBox();
            this.TXTDeliveryName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNComplete = new System.Windows.Forms.Button();
            this.BTNClearData = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.LBXOrderItems = new System.Windows.Forms.ListBox();
            this.GBXOrderInformation = new System.Windows.Forms.GroupBox();
            this.TXTSubtotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TXTOrderTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TXTQuantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CBXBreadCrustOption = new System.Windows.Forms.ComboBox();
            this.CBXFoodItem = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BTNDefaultInfo = new System.Windows.Forms.Button();
            this.BTNCheckInventory = new System.Windows.Forms.Button();
            this.BTNDisplayVendors = new System.Windows.Forms.Button();
            this.PBXPizza = new System.Windows.Forms.PictureBox();
            this.PBXDeli = new System.Windows.Forms.PictureBox();
            this.GBXCarryoutOrDelivery.SuspendLayout();
            this.GBXCustomerInformation.SuspendLayout();
            this.GBXDeliveryAddress.SuspendLayout();
            this.GBXOrderInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXDeli)).BeginInit();
            this.SuspendLayout();
            // 
            // RDOCarryout
            // 
            this.RDOCarryout.AutoSize = true;
            this.RDOCarryout.Location = new System.Drawing.Point(24, 29);
            this.RDOCarryout.Name = "RDOCarryout";
            this.RDOCarryout.Size = new System.Drawing.Size(64, 17);
            this.RDOCarryout.TabIndex = 1;
            this.RDOCarryout.Text = "Carryout";
            this.RDOCarryout.UseVisualStyleBackColor = true;
            this.RDOCarryout.CheckedChanged += new System.EventHandler(this.RDOCarryout_CheckedChanged);
            // 
            // RDODelivery
            // 
            this.RDODelivery.Checked = true;
            this.RDODelivery.Location = new System.Drawing.Point(116, 29);
            this.RDODelivery.Name = "RDODelivery";
            this.RDODelivery.Size = new System.Drawing.Size(85, 17);
            this.RDODelivery.TabIndex = 2;
            this.RDODelivery.TabStop = true;
            this.RDODelivery.Text = "Delivery";
            this.RDODelivery.UseVisualStyleBackColor = true;
            // 
            // GBXCarryoutOrDelivery
            // 
            this.GBXCarryoutOrDelivery.Controls.Add(this.RDOCarryout);
            this.GBXCarryoutOrDelivery.Controls.Add(this.RDODelivery);
            this.GBXCarryoutOrDelivery.Location = new System.Drawing.Point(12, 12);
            this.GBXCarryoutOrDelivery.Name = "GBXCarryoutOrDelivery";
            this.GBXCarryoutOrDelivery.Size = new System.Drawing.Size(230, 78);
            this.GBXCarryoutOrDelivery.TabIndex = 0;
            this.GBXCarryoutOrDelivery.TabStop = false;
            this.GBXCarryoutOrDelivery.Text = "Carryout Or Delivery";
            // 
            // GBXCustomerInformation
            // 
            this.GBXCustomerInformation.Controls.Add(this.CHKSameAsDelivery);
            this.GBXCustomerInformation.Controls.Add(this.TXTPhoneNumber);
            this.GBXCustomerInformation.Controls.Add(this.label8);
            this.GBXCustomerInformation.Controls.Add(this.TXTZipCode);
            this.GBXCustomerInformation.Controls.Add(this.TXTState);
            this.GBXCustomerInformation.Controls.Add(this.label7);
            this.GBXCustomerInformation.Controls.Add(this.label4);
            this.GBXCustomerInformation.Controls.Add(this.label5);
            this.GBXCustomerInformation.Controls.Add(this.TXTStreetAddress);
            this.GBXCustomerInformation.Controls.Add(this.TXTCity);
            this.GBXCustomerInformation.Controls.Add(this.label3);
            this.GBXCustomerInformation.Controls.Add(this.TXTSubdivision);
            this.GBXCustomerInformation.Controls.Add(this.label2);
            this.GBXCustomerInformation.Controls.Add(this.TXTCustomerName);
            this.GBXCustomerInformation.Controls.Add(this.label1);
            this.GBXCustomerInformation.Location = new System.Drawing.Point(13, 110);
            this.GBXCustomerInformation.Name = "GBXCustomerInformation";
            this.GBXCustomerInformation.Size = new System.Drawing.Size(338, 241);
            this.GBXCustomerInformation.TabIndex = 2;
            this.GBXCustomerInformation.TabStop = false;
            this.GBXCustomerInformation.Text = "Customer Information";
            // 
            // CHKSameAsDelivery
            // 
            this.CHKSameAsDelivery.AutoSize = true;
            this.CHKSameAsDelivery.Location = new System.Drawing.Point(16, 218);
            this.CHKSameAsDelivery.Name = "CHKSameAsDelivery";
            this.CHKSameAsDelivery.Size = new System.Drawing.Size(245, 17);
            this.CHKSameAsDelivery.TabIndex = 16;
            this.CHKSameAsDelivery.Text = "Delivery Address is same as Customer Address";
            this.CHKSameAsDelivery.UseVisualStyleBackColor = true;
            this.CHKSameAsDelivery.CheckedChanged += new System.EventHandler(this.CHKSameAsDelivery_CheckedChanged);
            // 
            // TXTPhoneNumber
            // 
            this.TXTPhoneNumber.Location = new System.Drawing.Point(115, 185);
            this.TXTPhoneNumber.MaxLength = 10;
            this.TXTPhoneNumber.Name = "TXTPhoneNumber";
            this.TXTPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TXTPhoneNumber.TabIndex = 9;
            this.TXTPhoneNumber.Tag = "Phone Number";
            this.TXTPhoneNumber.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Phone Number:";
            // 
            // TXTZipCode
            // 
            this.TXTZipCode.Location = new System.Drawing.Point(66, 119);
            this.TXTZipCode.MaxLength = 5;
            this.TXTZipCode.Name = "TXTZipCode";
            this.TXTZipCode.Size = new System.Drawing.Size(100, 20);
            this.TXTZipCode.TabIndex = 7;
            this.TXTZipCode.Tag = "Zip Code";
            this.TXTZipCode.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // TXTState
            // 
            this.TXTState.Location = new System.Drawing.Point(213, 84);
            this.TXTState.MaxLength = 2;
            this.TXTState.Name = "TXTState";
            this.TXTState.Size = new System.Drawing.Size(37, 20);
            this.TXTState.TabIndex = 6;
            this.TXTState.Tag = "State";
            this.TXTState.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zip Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "State:";
            // 
            // TXTStreetAddress
            // 
            this.TXTStreetAddress.Location = new System.Drawing.Point(100, 58);
            this.TXTStreetAddress.Name = "TXTStreetAddress";
            this.TXTStreetAddress.Size = new System.Drawing.Size(182, 20);
            this.TXTStreetAddress.TabIndex = 4;
            this.TXTStreetAddress.Tag = "Street Address";
            this.TXTStreetAddress.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // TXTCity
            // 
            this.TXTCity.Location = new System.Drawing.Point(41, 83);
            this.TXTCity.Name = "TXTCity";
            this.TXTCity.Size = new System.Drawing.Size(100, 20);
            this.TXTCity.TabIndex = 5;
            this.TXTCity.Tag = "City";
            this.TXTCity.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Street Address:";
            // 
            // TXTSubdivision
            // 
            this.TXTSubdivision.Location = new System.Drawing.Point(100, 159);
            this.TXTSubdivision.Name = "TXTSubdivision";
            this.TXTSubdivision.Size = new System.Drawing.Size(182, 20);
            this.TXTSubdivision.TabIndex = 8;
            this.TXTSubdivision.Tag = "Subdivision";
            this.TXTSubdivision.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subdivision:";
            // 
            // TXTCustomerName
            // 
            this.TXTCustomerName.Location = new System.Drawing.Point(100, 26);
            this.TXTCustomerName.Name = "TXTCustomerName";
            this.TXTCustomerName.Size = new System.Drawing.Size(182, 20);
            this.TXTCustomerName.TabIndex = 3;
            this.TXTCustomerName.Tag = "Customer Name";
            this.TXTCustomerName.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // GBXDeliveryAddress
            // 
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryPhoneNumber);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliverySubDivision);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryZipCode);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryState);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryCity);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryStreet);
            this.GBXDeliveryAddress.Controls.Add(this.TXTDeliveryName);
            this.GBXDeliveryAddress.Controls.Add(this.label14);
            this.GBXDeliveryAddress.Controls.Add(this.label13);
            this.GBXDeliveryAddress.Controls.Add(this.label12);
            this.GBXDeliveryAddress.Controls.Add(this.label11);
            this.GBXDeliveryAddress.Controls.Add(this.label10);
            this.GBXDeliveryAddress.Controls.Add(this.label9);
            this.GBXDeliveryAddress.Controls.Add(this.label6);
            this.GBXDeliveryAddress.Location = new System.Drawing.Point(13, 357);
            this.GBXDeliveryAddress.Name = "GBXDeliveryAddress";
            this.GBXDeliveryAddress.Size = new System.Drawing.Size(348, 222);
            this.GBXDeliveryAddress.TabIndex = 3;
            this.GBXDeliveryAddress.TabStop = false;
            this.GBXDeliveryAddress.Text = "Delivery Address";
            // 
            // TXTDeliveryPhoneNumber
            // 
            this.TXTDeliveryPhoneNumber.Location = new System.Drawing.Point(100, 174);
            this.TXTDeliveryPhoneNumber.MaxLength = 10;
            this.TXTDeliveryPhoneNumber.Name = "TXTDeliveryPhoneNumber";
            this.TXTDeliveryPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TXTDeliveryPhoneNumber.TabIndex = 16;
            this.TXTDeliveryPhoneNumber.Tag = "Delivery Phone Number";
            // 
            // TXTDeliverySubDivision
            // 
            this.TXTDeliverySubDivision.Location = new System.Drawing.Point(83, 148);
            this.TXTDeliverySubDivision.Name = "TXTDeliverySubDivision";
            this.TXTDeliverySubDivision.Size = new System.Drawing.Size(100, 20);
            this.TXTDeliverySubDivision.TabIndex = 15;
            this.TXTDeliverySubDivision.Tag = "Delivery Subdivision";
            // 
            // TXTDeliveryZipCode
            // 
            this.TXTDeliveryZipCode.Location = new System.Drawing.Point(81, 120);
            this.TXTDeliveryZipCode.MaxLength = 5;
            this.TXTDeliveryZipCode.Name = "TXTDeliveryZipCode";
            this.TXTDeliveryZipCode.Size = new System.Drawing.Size(100, 20);
            this.TXTDeliveryZipCode.TabIndex = 14;
            this.TXTDeliveryZipCode.Tag = "Delivery Zip Code";
            // 
            // TXTDeliveryState
            // 
            this.TXTDeliveryState.Location = new System.Drawing.Point(210, 85);
            this.TXTDeliveryState.MaxLength = 2;
            this.TXTDeliveryState.Name = "TXTDeliveryState";
            this.TXTDeliveryState.Size = new System.Drawing.Size(37, 20);
            this.TXTDeliveryState.TabIndex = 13;
            this.TXTDeliveryState.Tag = "Delivery State";
            // 
            // TXTDeliveryCity
            // 
            this.TXTDeliveryCity.Location = new System.Drawing.Point(46, 88);
            this.TXTDeliveryCity.Name = "TXTDeliveryCity";
            this.TXTDeliveryCity.Size = new System.Drawing.Size(100, 20);
            this.TXTDeliveryCity.TabIndex = 12;
            this.TXTDeliveryCity.Tag = "Delivery City";
            // 
            // TXTDeliveryStreet
            // 
            this.TXTDeliveryStreet.Location = new System.Drawing.Point(81, 55);
            this.TXTDeliveryStreet.Name = "TXTDeliveryStreet";
            this.TXTDeliveryStreet.Size = new System.Drawing.Size(216, 20);
            this.TXTDeliveryStreet.TabIndex = 11;
            this.TXTDeliveryStreet.Tag = "Delivery Street";
            // 
            // TXTDeliveryName
            // 
            this.TXTDeliveryName.Location = new System.Drawing.Point(81, 23);
            this.TXTDeliveryName.Name = "TXTDeliveryName";
            this.TXTDeliveryName.Size = new System.Drawing.Size(216, 20);
            this.TXTDeliveryName.TabIndex = 10;
            this.TXTDeliveryName.Tag = "Delivery Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Subdivision:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Phone Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Zip Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "State:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Street:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // BTNComplete
            // 
            this.BTNComplete.Location = new System.Drawing.Point(501, 572);
            this.BTNComplete.Name = "BTNComplete";
            this.BTNComplete.Size = new System.Drawing.Size(87, 23);
            this.BTNComplete.TabIndex = 21;
            this.BTNComplete.Text = "Complete";
            this.BTNComplete.UseVisualStyleBackColor = true;
            this.BTNComplete.Click += new System.EventHandler(this.BTNComplete_Click);
            // 
            // BTNClearData
            // 
            this.BTNClearData.Location = new System.Drawing.Point(601, 572);
            this.BTNClearData.Name = "BTNClearData";
            this.BTNClearData.Size = new System.Drawing.Size(90, 23);
            this.BTNClearData.TabIndex = 22;
            this.BTNClearData.Text = "Clear Form";
            this.BTNClearData.UseVisualStyleBackColor = true;
            this.BTNClearData.Click += new System.EventHandler(this.BTNClearData_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNClose.Location = new System.Drawing.Point(697, 572);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(91, 23);
            this.BTNClose.TabIndex = 23;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(380, 572);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(115, 23);
            this.BTNAdd.TabIndex = 20;
            this.BTNAdd.Text = "Add Another Order";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // LBXOrderItems
            // 
            this.LBXOrderItems.FormattingEnabled = true;
            this.LBXOrderItems.Location = new System.Drawing.Point(25, 305);
            this.LBXOrderItems.Name = "LBXOrderItems";
            this.LBXOrderItems.Size = new System.Drawing.Size(318, 121);
            this.LBXOrderItems.TabIndex = 9;
            this.LBXOrderItems.TabStop = false;
            // 
            // GBXOrderInformation
            // 
            this.GBXOrderInformation.Controls.Add(this.TXTSubtotal);
            this.GBXOrderInformation.Controls.Add(this.label20);
            this.GBXOrderInformation.Controls.Add(this.TXTOrderTotal);
            this.GBXOrderInformation.Controls.Add(this.label19);
            this.GBXOrderInformation.Controls.Add(this.PBXPizza);
            this.GBXOrderInformation.Controls.Add(this.PBXDeli);
            this.GBXOrderInformation.Controls.Add(this.TXTQuantity);
            this.GBXOrderInformation.Controls.Add(this.label18);
            this.GBXOrderInformation.Controls.Add(this.label17);
            this.GBXOrderInformation.Controls.Add(this.label16);
            this.GBXOrderInformation.Controls.Add(this.CBXBreadCrustOption);
            this.GBXOrderInformation.Controls.Add(this.CBXFoodItem);
            this.GBXOrderInformation.Controls.Add(this.label15);
            this.GBXOrderInformation.Controls.Add(this.LBXOrderItems);
            this.GBXOrderInformation.Location = new System.Drawing.Point(413, 32);
            this.GBXOrderInformation.Name = "GBXOrderInformation";
            this.GBXOrderInformation.Size = new System.Drawing.Size(375, 531);
            this.GBXOrderInformation.TabIndex = 10;
            this.GBXOrderInformation.TabStop = false;
            this.GBXOrderInformation.Text = "Order Information";
            // 
            // TXTSubtotal
            // 
            this.TXTSubtotal.Location = new System.Drawing.Point(166, 455);
            this.TXTSubtotal.Name = "TXTSubtotal";
            this.TXTSubtotal.ReadOnly = true;
            this.TXTSubtotal.Size = new System.Drawing.Size(140, 20);
            this.TXTSubtotal.TabIndex = 24;
            this.TXTSubtotal.TabStop = false;
            this.TXTSubtotal.Tag = "Subtotal";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 458);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Subtotal:";
            // 
            // TXTOrderTotal
            // 
            this.TXTOrderTotal.Location = new System.Drawing.Point(166, 499);
            this.TXTOrderTotal.Name = "TXTOrderTotal";
            this.TXTOrderTotal.ReadOnly = true;
            this.TXTOrderTotal.Size = new System.Drawing.Size(140, 20);
            this.TXTOrderTotal.TabIndex = 22;
            this.TXTOrderTotal.TabStop = false;
            this.TXTOrderTotal.Tag = "Order Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 499);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Order Total:";
            // 
            // TXTQuantity
            // 
            this.TXTQuantity.Location = new System.Drawing.Point(155, 121);
            this.TXTQuantity.Name = "TXTQuantity";
            this.TXTQuantity.Size = new System.Drawing.Size(100, 20);
            this.TXTQuantity.TabIndex = 19;
            this.TXTQuantity.Tag = "Quanity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Quantity:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Bread/Crust Options";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Food Item:";
            // 
            // CBXBreadCrustOption
            // 
            this.CBXBreadCrustOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXBreadCrustOption.FormattingEnabled = true;
            this.CBXBreadCrustOption.Location = new System.Drawing.Point(155, 78);
            this.CBXBreadCrustOption.Name = "CBXBreadCrustOption";
            this.CBXBreadCrustOption.Size = new System.Drawing.Size(151, 21);
            this.CBXBreadCrustOption.TabIndex = 18;
            // 
            // CBXFoodItem
            // 
            this.CBXFoodItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXFoodItem.FormattingEnabled = true;
            this.CBXFoodItem.Location = new System.Drawing.Point(155, 41);
            this.CBXFoodItem.Name = "CBXFoodItem";
            this.CBXFoodItem.Size = new System.Drawing.Size(151, 21);
            this.CBXFoodItem.TabIndex = 17;
            this.CBXFoodItem.UseWaitCursor = true;
            this.CBXFoodItem.SelectedIndexChanged += new System.EventHandler(this.CBXFoodItem_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Picture of Item:";
            // 
            // BTNDefaultInfo
            // 
            this.BTNDefaultInfo.Location = new System.Drawing.Point(434, 611);
            this.BTNDefaultInfo.Name = "BTNDefaultInfo";
            this.BTNDefaultInfo.Size = new System.Drawing.Size(83, 37);
            this.BTNDefaultInfo.TabIndex = 24;
            this.BTNDefaultInfo.Text = "Default Information";
            this.BTNDefaultInfo.UseVisualStyleBackColor = true;
            this.BTNDefaultInfo.Click += new System.EventHandler(this.BTNDefaultInfo_Click);
            // 
            // BTNCheckInventory
            // 
            this.BTNCheckInventory.Location = new System.Drawing.Point(545, 611);
            this.BTNCheckInventory.Name = "BTNCheckInventory";
            this.BTNCheckInventory.Size = new System.Drawing.Size(84, 37);
            this.BTNCheckInventory.TabIndex = 25;
            this.BTNCheckInventory.Text = "Check Inventory";
            this.BTNCheckInventory.UseVisualStyleBackColor = true;
            this.BTNCheckInventory.Click += new System.EventHandler(this.BTNCheckInventory_Click);
            // 
            // BTNDisplayVendors
            // 
            this.BTNDisplayVendors.Location = new System.Drawing.Point(659, 611);
            this.BTNDisplayVendors.Name = "BTNDisplayVendors";
            this.BTNDisplayVendors.Size = new System.Drawing.Size(75, 37);
            this.BTNDisplayVendors.TabIndex = 26;
            this.BTNDisplayVendors.Text = "Display Vendors";
            this.BTNDisplayVendors.UseVisualStyleBackColor = true;
            this.BTNDisplayVendors.Click += new System.EventHandler(this.BTNDisplayVendors_Click);
            // 
            // PBXPizza
            // 
            this.PBXPizza.Image = global::GroupEProject1.Properties.Resources.pizza;
            this.PBXPizza.Location = new System.Drawing.Point(126, 161);
            this.PBXPizza.Name = "PBXPizza";
            this.PBXPizza.Size = new System.Drawing.Size(180, 122);
            this.PBXPizza.TabIndex = 20;
            this.PBXPizza.TabStop = false;
            // 
            // PBXDeli
            // 
            this.PBXDeli.Image = global::GroupEProject1.Properties.Resources.deli;
            this.PBXDeli.Location = new System.Drawing.Point(155, 169);
            this.PBXDeli.Name = "PBXDeli";
            this.PBXDeli.Size = new System.Drawing.Size(151, 67);
            this.PBXDeli.TabIndex = 19;
            this.PBXDeli.TabStop = false;
            // 
            // FRMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNClose;
            this.ClientSize = new System.Drawing.Size(832, 670);
            this.Controls.Add(this.BTNDisplayVendors);
            this.Controls.Add(this.BTNCheckInventory);
            this.Controls.Add(this.BTNDefaultInfo);
            this.Controls.Add(this.GBXOrderInformation);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNClearData);
            this.Controls.Add(this.BTNComplete);
            this.Controls.Add(this.GBXDeliveryAddress);
            this.Controls.Add(this.GBXCustomerInformation);
            this.Controls.Add(this.GBXCarryoutOrDelivery);
            this.Name = "FRMOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.FRMOrder_Load);
            this.GBXCarryoutOrDelivery.ResumeLayout(false);
            this.GBXCarryoutOrDelivery.PerformLayout();
            this.GBXCustomerInformation.ResumeLayout(false);
            this.GBXCustomerInformation.PerformLayout();
            this.GBXDeliveryAddress.ResumeLayout(false);
            this.GBXDeliveryAddress.PerformLayout();
            this.GBXOrderInformation.ResumeLayout(false);
            this.GBXOrderInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBXDeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RDOCarryout;
        private System.Windows.Forms.RadioButton RDODelivery;
        private System.Windows.Forms.GroupBox GBXCarryoutOrDelivery;
        private System.Windows.Forms.GroupBox GBXCustomerInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTStreetAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTSubdivision;
        private System.Windows.Forms.TextBox TXTPhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTZipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GBXDeliveryAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTDeliveryPhoneNumber;
        private System.Windows.Forms.TextBox TXTDeliverySubDivision;
        private System.Windows.Forms.TextBox TXTDeliveryZipCode;
        private System.Windows.Forms.TextBox TXTDeliveryState;
        private System.Windows.Forms.TextBox TXTDeliveryCity;
        private System.Windows.Forms.TextBox TXTDeliveryStreet;
        private System.Windows.Forms.TextBox TXTDeliveryName;
        private System.Windows.Forms.Button BTNComplete;
        private System.Windows.Forms.Button BTNClearData;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.ListBox LBXOrderItems;
        private System.Windows.Forms.GroupBox GBXOrderInformation;
        private System.Windows.Forms.CheckBox CHKSameAsDelivery;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CBXBreadCrustOption;
        private System.Windows.Forms.ComboBox CBXFoodItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TXTQuantity;
        private System.Windows.Forms.PictureBox PBXPizza;
        private System.Windows.Forms.PictureBox PBXDeli;
        private System.Windows.Forms.TextBox TXTOrderTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXTSubtotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BTNDefaultInfo;
        private System.Windows.Forms.Button BTNCheckInventory;
        private System.Windows.Forms.Button BTNDisplayVendors;
    }
}

