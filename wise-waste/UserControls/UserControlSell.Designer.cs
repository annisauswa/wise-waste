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
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(357, 80);
            this.lblSell.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(218, 31);
            this.lblSell.TabIndex = 0;
            this.lblSell.Text = "Sell your Waste";
            // 
            // radioBtnEwaste
            // 
            this.radioBtnEwaste.AutoSize = true;
            this.radioBtnEwaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEwaste.Location = new System.Drawing.Point(178, 157);
            this.radioBtnEwaste.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnEwaste.Name = "radioBtnEwaste";
            this.radioBtnEwaste.Size = new System.Drawing.Size(102, 28);
            this.radioBtnEwaste.TabIndex = 1;
            this.radioBtnEwaste.TabStop = true;
            this.radioBtnEwaste.Text = "Ewaste";
            this.radioBtnEwaste.UseVisualStyleBackColor = true;
            this.radioBtnEwaste.CheckedChanged += new System.EventHandler(this.radioBtnEwaste_CheckedChanged);
            // 
            // radioBtnOrganik
            // 
            this.radioBtnOrganik.AutoSize = true;
            this.radioBtnOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOrganik.Location = new System.Drawing.Point(360, 157);
            this.radioBtnOrganik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnOrganik.Name = "radioBtnOrganik";
            this.radioBtnOrganik.Size = new System.Drawing.Size(182, 28);
            this.radioBtnOrganik.TabIndex = 2;
            this.radioBtnOrganik.TabStop = true;
            this.radioBtnOrganik.Text = "Sampah Organik";
            this.radioBtnOrganik.UseVisualStyleBackColor = true;
            this.radioBtnOrganik.CheckedChanged += new System.EventHandler(this.radioBtnOrganik_CheckedChanged);
            // 
            // radioBtnAnorganik
            // 
            this.radioBtnAnorganik.AutoSize = true;
            this.radioBtnAnorganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnorganik.Location = new System.Drawing.Point(614, 157);
            this.radioBtnAnorganik.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnAnorganik.Name = "radioBtnAnorganik";
            this.radioBtnAnorganik.Size = new System.Drawing.Size(202, 28);
            this.radioBtnAnorganik.TabIndex = 3;
            this.radioBtnAnorganik.TabStop = true;
            this.radioBtnAnorganik.Text = "Sampah Anorganik";
            this.radioBtnAnorganik.UseVisualStyleBackColor = true;
            this.radioBtnAnorganik.CheckedChanged += new System.EventHandler(this.radioBtnAnorganik_CheckedChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(174, 122);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(248, 24);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "What\'s your waste category?";
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(178, 227);
            this.tbProdName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(662, 31);
            this.tbProdName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Waste name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pick up address";
            // 
            // tbSellAddress
            // 
            this.tbSellAddress.Location = new System.Drawing.Point(180, 300);
            this.tbSellAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSellAddress.Name = "tbSellAddress";
            this.tbSellAddress.Size = new System.Drawing.Size(662, 31);
            this.tbSellAddress.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(614, 419);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(226, 31);
            this.tbAmount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Weight";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(177, 368);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(610, 31);
            this.tbWeight.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "kg";
            // 
            // btnConfirmSell
            // 
            this.btnConfirmSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSell.Location = new System.Drawing.Point(692, 462);
            this.btnConfirmSell.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirmSell.Name = "btnConfirmSell";
            this.btnConfirmSell.Size = new System.Drawing.Size(150, 42);
            this.btnConfirmSell.TabIndex = 14;
            this.btnConfirmSell.Text = "Sell";
            this.btnConfirmSell.UseVisualStyleBackColor = true;
            this.btnConfirmSell.Click += new System.EventHandler(this.btnConfirmSell_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(516, 462);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UserControlSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UserControlSell";
            this.Size = new System.Drawing.Size(943, 546);
            this.Load += new System.EventHandler(this.UserControlSell_Load_1);
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
