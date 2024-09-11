namespace GroupEProject1
{
    partial class FRMVendor
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
            this.BTNNextRecord = new System.Windows.Forms.Button();
            this.BTNPreviousRecord = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.TXTVendorName = new System.Windows.Forms.TextBox();
            this.TXTVendorStreetAddress = new System.Windows.Forms.TextBox();
            this.TXTVendorCity = new System.Windows.Forms.TextBox();
            this.TXTVendorState = new System.Windows.Forms.TextBox();
            this.TXTVendorZipCode = new System.Windows.Forms.TextBox();
            this.TXTVendorPhoneNumber = new System.Windows.Forms.TextBox();
            this.TXTVendorSalesYearToDate = new System.Windows.Forms.TextBox();
            this.TXTVendorSalesRepresentativeName = new System.Windows.Forms.TextBox();
            this.TXTVendorComments = new System.Windows.Forms.TextBox();
            this.CBXVendorDefaultDiscount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNNextRecord
            // 
            this.BTNNextRecord.Location = new System.Drawing.Point(312, 412);
            this.BTNNextRecord.Name = "BTNNextRecord";
            this.BTNNextRecord.Size = new System.Drawing.Size(79, 50);
            this.BTNNextRecord.TabIndex = 11;
            this.BTNNextRecord.Text = "Next Record";
            this.BTNNextRecord.UseVisualStyleBackColor = true;
            this.BTNNextRecord.Click += new System.EventHandler(this.BTNNextRecord_Click);
            // 
            // BTNPreviousRecord
            // 
            this.BTNPreviousRecord.Location = new System.Drawing.Point(409, 412);
            this.BTNPreviousRecord.Name = "BTNPreviousRecord";
            this.BTNPreviousRecord.Size = new System.Drawing.Size(81, 50);
            this.BTNPreviousRecord.TabIndex = 12;
            this.BTNPreviousRecord.Text = "Previous Record";
            this.BTNPreviousRecord.UseVisualStyleBackColor = true;
            this.BTNPreviousRecord.Click += new System.EventHandler(this.BTNPreviousRecord_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(513, 412);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(75, 50);
            this.BTNSave.TabIndex = 13;
            this.BTNSave.Text = "Save Current Record";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(611, 412);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(71, 50);
            this.BTNClose.TabIndex = 14;
            this.BTNClose.Text = "Close Form";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // TXTVendorName
            // 
            this.TXTVendorName.Location = new System.Drawing.Point(271, 103);
            this.TXTVendorName.Name = "TXTVendorName";
            this.TXTVendorName.Size = new System.Drawing.Size(198, 20);
            this.TXTVendorName.TabIndex = 1;
            this.TXTVendorName.Tag = "Vendor Name";
            // 
            // TXTVendorStreetAddress
            // 
            this.TXTVendorStreetAddress.Location = new System.Drawing.Point(271, 147);
            this.TXTVendorStreetAddress.Name = "TXTVendorStreetAddress";
            this.TXTVendorStreetAddress.Size = new System.Drawing.Size(198, 20);
            this.TXTVendorStreetAddress.TabIndex = 2;
            this.TXTVendorStreetAddress.Tag = "Vendor Street Address";
            // 
            // TXTVendorCity
            // 
            this.TXTVendorCity.Location = new System.Drawing.Point(271, 186);
            this.TXTVendorCity.Name = "TXTVendorCity";
            this.TXTVendorCity.Size = new System.Drawing.Size(125, 20);
            this.TXTVendorCity.TabIndex = 3;
            this.TXTVendorCity.Tag = "Vendor City";
            // 
            // TXTVendorState
            // 
            this.TXTVendorState.Location = new System.Drawing.Point(271, 232);
            this.TXTVendorState.Name = "TXTVendorState";
            this.TXTVendorState.Size = new System.Drawing.Size(125, 20);
            this.TXTVendorState.TabIndex = 4;
            this.TXTVendorState.Tag = "Vendor State";
            // 
            // TXTVendorZipCode
            // 
            this.TXTVendorZipCode.Location = new System.Drawing.Point(271, 276);
            this.TXTVendorZipCode.Name = "TXTVendorZipCode";
            this.TXTVendorZipCode.Size = new System.Drawing.Size(93, 20);
            this.TXTVendorZipCode.TabIndex = 5;
            this.TXTVendorZipCode.Tag = "Vendor Zip Code";
            // 
            // TXTVendorPhoneNumber
            // 
            this.TXTVendorPhoneNumber.Location = new System.Drawing.Point(271, 313);
            this.TXTVendorPhoneNumber.Name = "TXTVendorPhoneNumber";
            this.TXTVendorPhoneNumber.Size = new System.Drawing.Size(93, 20);
            this.TXTVendorPhoneNumber.TabIndex = 6;
            this.TXTVendorPhoneNumber.Tag = "Vendor Phone Number";
            // 
            // TXTVendorSalesYearToDate
            // 
            this.TXTVendorSalesYearToDate.Location = new System.Drawing.Point(726, 112);
            this.TXTVendorSalesYearToDate.Name = "TXTVendorSalesYearToDate";
            this.TXTVendorSalesYearToDate.Size = new System.Drawing.Size(165, 20);
            this.TXTVendorSalesYearToDate.TabIndex = 7;
            this.TXTVendorSalesYearToDate.Tag = "Vendor Sales YTD";
            // 
            // TXTVendorSalesRepresentativeName
            // 
            this.TXTVendorSalesRepresentativeName.Location = new System.Drawing.Point(726, 159);
            this.TXTVendorSalesRepresentativeName.Name = "TXTVendorSalesRepresentativeName";
            this.TXTVendorSalesRepresentativeName.Size = new System.Drawing.Size(165, 20);
            this.TXTVendorSalesRepresentativeName.TabIndex = 8;
            this.TXTVendorSalesRepresentativeName.Tag = "Vendor Sales Representative Name";
            // 
            // TXTVendorComments
            // 
            this.TXTVendorComments.Location = new System.Drawing.Point(726, 208);
            this.TXTVendorComments.Name = "TXTVendorComments";
            this.TXTVendorComments.Size = new System.Drawing.Size(243, 20);
            this.TXTVendorComments.TabIndex = 9;
            this.TXTVendorComments.Tag = "Vendor Comments";
            // 
            // CBXVendorDefaultDiscount
            // 
            this.CBXVendorDefaultDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXVendorDefaultDiscount.FormattingEnabled = true;
            this.CBXVendorDefaultDiscount.Location = new System.Drawing.Point(726, 264);
            this.CBXVendorDefaultDiscount.Name = "CBXVendorDefaultDiscount";
            this.CBXVendorDefaultDiscount.Size = new System.Drawing.Size(121, 21);
            this.CBXVendorDefaultDiscount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vendor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vendor Street Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vendor City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vendor State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vendor Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vendor Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vendor Sales Year To Date (YTD):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Vendor Sales Representative Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Vendor Comments:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Vendor Default Discount:";
            // 
            // FRMVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 554);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBXVendorDefaultDiscount);
            this.Controls.Add(this.TXTVendorComments);
            this.Controls.Add(this.TXTVendorSalesRepresentativeName);
            this.Controls.Add(this.TXTVendorSalesYearToDate);
            this.Controls.Add(this.TXTVendorPhoneNumber);
            this.Controls.Add(this.TXTVendorZipCode);
            this.Controls.Add(this.TXTVendorState);
            this.Controls.Add(this.TXTVendorCity);
            this.Controls.Add(this.TXTVendorStreetAddress);
            this.Controls.Add(this.TXTVendorName);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNPreviousRecord);
            this.Controls.Add(this.BTNNextRecord);
            this.Name = "FRMVendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Form";
            this.Load += new System.EventHandler(this.FRMVendor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNNextRecord;
        private System.Windows.Forms.Button BTNPreviousRecord;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.TextBox TXTVendorName;
        private System.Windows.Forms.TextBox TXTVendorStreetAddress;
        private System.Windows.Forms.TextBox TXTVendorCity;
        private System.Windows.Forms.TextBox TXTVendorState;
        private System.Windows.Forms.TextBox TXTVendorZipCode;
        private System.Windows.Forms.TextBox TXTVendorPhoneNumber;
        private System.Windows.Forms.TextBox TXTVendorSalesYearToDate;
        private System.Windows.Forms.TextBox TXTVendorSalesRepresentativeName;
        private System.Windows.Forms.TextBox TXTVendorComments;
        private System.Windows.Forms.ComboBox CBXVendorDefaultDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}