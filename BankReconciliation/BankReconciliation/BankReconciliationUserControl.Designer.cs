namespace BankReconciliation
{
    partial class BankReconciliationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReconciliation = new System.Windows.Forms.Button();
            this.dtpClosingDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClosingDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReconciliation
            // 
            this.btnReconciliation.Location = new System.Drawing.Point(121, 81);
            this.btnReconciliation.Name = "btnReconciliation";
            this.btnReconciliation.Size = new System.Drawing.Size(200, 23);
            this.btnReconciliation.TabIndex = 0;
            this.btnReconciliation.Text = "Get Reconciliation";
            this.btnReconciliation.UseVisualStyleBackColor = true;
            this.btnReconciliation.Click += new System.EventHandler(this.btnReconciliation_Click);
            // 
            // dtpClosingDate
            // 
            this.dtpClosingDate.Location = new System.Drawing.Point(121, 38);
            this.dtpClosingDate.Name = "dtpClosingDate";
            this.dtpClosingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpClosingDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClosingDate);
            this.groupBox1.Controls.Add(this.btnReconciliation);
            this.groupBox1.Controls.Add(this.dtpClosingDate);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 381);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Reconciliation";
            // 
            // lblClosingDate
            // 
            this.lblClosingDate.AutoSize = true;
            this.lblClosingDate.Location = new System.Drawing.Point(38, 44);
            this.lblClosingDate.Name = "lblClosingDate";
            this.lblClosingDate.Size = new System.Drawing.Size(67, 13);
            this.lblClosingDate.TabIndex = 2;
            this.lblClosingDate.Text = "Closing Date";
            // 
            // BankReconciliationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "BankReconciliationUserControl";
            this.Size = new System.Drawing.Size(352, 396);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReconciliation;
        private System.Windows.Forms.DateTimePicker dtpClosingDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClosingDate;
    }
}
