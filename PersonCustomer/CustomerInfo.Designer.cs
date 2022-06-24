
namespace PersonCustomer
{
    partial class CustomerInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.mailingLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mailingLabel);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numberLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fullNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.Location = new System.Drawing.Point(244, 156);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(385, 55);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address:";
            // 
            // addressLabel
            // 
            this.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressLabel.Location = new System.Drawing.Point(244, 242);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(385, 55);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Number:";
            // 
            // numberLabel
            // 
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Location = new System.Drawing.Point(354, 71);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(275, 55);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneLabel.Location = new System.Drawing.Point(244, 333);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(385, 55);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailingLabel
            // 
            this.mailingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailingLabel.Location = new System.Drawing.Point(50, 422);
            this.mailingLabel.Name = "mailingLabel";
            this.mailingLabel.Size = new System.Drawing.Size(580, 104);
            this.mailingLabel.TabIndex = 8;
            this.mailingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(273, 652);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(268, 102);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 794);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerInfo";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mailingLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
    }
}