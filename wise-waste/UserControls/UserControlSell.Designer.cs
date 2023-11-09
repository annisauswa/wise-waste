namespace wise_waste
{
    partial class UserControlSell
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
            this.lblSell = new System.Windows.Forms.Label();
            this.radioBtnEwaste = new System.Windows.Forms.RadioButton();
            this.radioBtnOrganik = new System.Windows.Forms.RadioButton();
            this.radioBtnAnorganik = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSellAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmSell = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(368, 72);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(155, 24);
            this.lblSell.TabIndex = 0;
            this.lblSell.Text = "Sell your Waste";
            // 
            // radioBtnEwaste
            // 
            this.radioBtnEwaste.AutoSize = true;
            this.radioBtnEwaste.Location = new System.Drawing.Point(281, 161);
            this.radioBtnEwaste.Name = "radioBtnEwaste";
            this.radioBtnEwaste.Size = new System.Drawing.Size(60, 17);
            this.radioBtnEwaste.TabIndex = 1;
            this.radioBtnEwaste.TabStop = true;
            this.radioBtnEwaste.Text = "Ewaste";
            this.radioBtnEwaste.UseVisualStyleBackColor = true;
            this.radioBtnEwaste.CheckedChanged += new System.EventHandler(this.radioBtnEwaste_CheckedChanged);
            // 
            // radioBtnOrganik
            // 
            this.radioBtnOrganik.AutoSize = true;
            this.radioBtnOrganik.Location = new System.Drawing.Point(372, 161);
            this.radioBtnOrganik.Name = "radioBtnOrganik";
            this.radioBtnOrganik.Size = new System.Drawing.Size(104, 17);
            this.radioBtnOrganik.TabIndex = 2;
            this.radioBtnOrganik.TabStop = true;
            this.radioBtnOrganik.Text = "Sampah Organik";
            this.radioBtnOrganik.UseVisualStyleBackColor = true;
            this.radioBtnOrganik.CheckedChanged += new System.EventHandler(this.radioBtnOrganik_CheckedChanged);
            // 
            // radioBtnAnorganik
            // 
            this.radioBtnAnorganik.AutoSize = true;
            this.radioBtnAnorganik.Location = new System.Drawing.Point(499, 161);
            this.radioBtnAnorganik.Name = "radioBtnAnorganik";
            this.radioBtnAnorganik.Size = new System.Drawing.Size(115, 17);
            this.radioBtnAnorganik.TabIndex = 3;
            this.radioBtnAnorganik.TabStop = true;
            this.radioBtnAnorganik.Text = "Sampah Anorganik";
            this.radioBtnAnorganik.UseVisualStyleBackColor = true;
            this.radioBtnAnorganik.CheckedChanged += new System.EventHandler(this.radioBtnAnorganik_CheckedChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(278, 134);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(144, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "What\'s your waste category?";
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(281, 224);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(333, 20);
            this.tbProdName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Waste name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pick up address";
            // 
            // tbSellAddress
            // 
            this.tbSellAddress.Location = new System.Drawing.Point(281, 289);
            this.tbSellAddress.Name = "tbSellAddress";
            this.tbSellAddress.Size = new System.Drawing.Size(333, 20);
            this.tbSellAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(499, 416);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(115, 20);
            this.tbAmount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Weight";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(281, 359);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(307, 20);
            this.tbWeight.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "kg";
            // 
            // btnConfirmSell
            // 
            this.btnConfirmSell.Location = new System.Drawing.Point(539, 466);
            this.btnConfirmSell.Name = "btnConfirmSell";
            this.btnConfirmSell.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSell.TabIndex = 14;
            this.btnConfirmSell.Text = "Sell";
            this.btnConfirmSell.UseVisualStyleBackColor = true;
            this.btnConfirmSell.Click += new System.EventHandler(this.btnConfirmSell_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(437, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserControlSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmSell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSellAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProdName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.radioBtnAnorganik);
            this.Controls.Add(this.radioBtnOrganik);
            this.Controls.Add(this.radioBtnEwaste);
            this.Controls.Add(this.lblSell);
            this.Name = "UserControlSell";
            this.Size = new System.Drawing.Size(900, 621);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.RadioButton radioBtnEwaste;
        private System.Windows.Forms.RadioButton radioBtnOrganik;
        private System.Windows.Forms.RadioButton radioBtnAnorganik;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSellAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmSell;
        private System.Windows.Forms.Button btnCancel;
    }
}
