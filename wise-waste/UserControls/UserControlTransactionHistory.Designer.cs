namespace wise_waste.UserControls
{
    partial class UserControlTransactionHistory
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
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDataTransaksi = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.LoadTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(136, 85);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(0, 20);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvDataTransaksi
            // 
            this.dgvDataTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataTransaksi.Location = new System.Drawing.Point(49, 83);
            this.dgvDataTransaksi.Name = "dgvDataTransaksi";
            this.dgvDataTransaksi.RowHeadersWidth = 82;
            this.dgvDataTransaksi.Size = new System.Drawing.Size(407, 147);
            this.dgvDataTransaksi.TabIndex = 13;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(628, 364);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // LoadTransaction
            // 
            this.LoadTransaction.Location = new System.Drawing.Point(380, 237);
            this.LoadTransaction.Name = "LoadTransaction";
            this.LoadTransaction.Size = new System.Drawing.Size(75, 23);
            this.LoadTransaction.TabIndex = 15;
            this.LoadTransaction.Text = "Load";
            this.LoadTransaction.UseVisualStyleBackColor = true;
            this.LoadTransaction.Click += new System.EventHandler(this.LoadTransaction_Click);
            // 
            // UserControlTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoadTransaction);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvDataTransaksi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown1);
            this.Name = "UserControlTransactionHistory";
            this.Size = new System.Drawing.Size(472, 284);
            this.Load += new System.EventHandler(this.UserControlTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDataTransaksi;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button LoadTransaction;
    }
}
