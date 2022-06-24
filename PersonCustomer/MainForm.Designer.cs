
namespace PersonCustomer
{
    partial class MainForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.yesCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.labelsss = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.yesCheckBox);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.phoneBox);
            this.groupBox.Controls.Add(this.labelsss);
            this.groupBox.Controls.Add(this.addressBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.lastNameBox);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.nameBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(69, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(664, 614);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Enter Customer Details";
            // 
            // yesCheckBox
            // 
            this.yesCheckBox.AutoSize = true;
            this.yesCheckBox.Location = new System.Drawing.Point(292, 520);
            this.yesCheckBox.Name = "yesCheckBox";
            this.yesCheckBox.Size = new System.Drawing.Size(92, 38);
            this.yesCheckBox.TabIndex = 9;
            this.yesCheckBox.Text = "Yes";
            this.yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(542, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Do You Wish to Be on a Mailing List?";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(260, 343);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(355, 51);
            this.phoneBox.TabIndex = 7;
            // 
            // labelsss
            // 
            this.labelsss.AutoSize = true;
            this.labelsss.Location = new System.Drawing.Point(106, 360);
            this.labelsss.Name = "labelsss";
            this.labelsss.Size = new System.Drawing.Size(106, 34);
            this.labelsss.TabIndex = 6;
            this.labelsss.Text = "Phone:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(260, 247);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(355, 51);
            this.addressBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(262, 148);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(355, 51);
            this.lastNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(260, 67);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(355, 51);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(167, 688);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(221, 90);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add Customer";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("MV Boli", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(421, 688);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(221, 90);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(800, 838);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox yesCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label labelsss;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

