namespace GroupEProject1
{
    partial class FRMInventory
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
            this.LBXInventory = new System.Windows.Forms.ListBox();
            this.BTNClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBXInventory
            // 
            this.LBXInventory.FormattingEnabled = true;
            this.LBXInventory.Location = new System.Drawing.Point(78, 22);
            this.LBXInventory.Name = "LBXInventory";
            this.LBXInventory.Size = new System.Drawing.Size(465, 212);
            this.LBXInventory.TabIndex = 0;
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(216, 252);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(149, 23);
            this.BTNClose.TabIndex = 2;
            this.BTNClose.Text = "Close Inventory Form";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // FRMInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 315);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LBXInventory);
            this.Name = "FRMInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Available";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTNClose;
        public System.Windows.Forms.ListBox LBXInventory;
    }
}