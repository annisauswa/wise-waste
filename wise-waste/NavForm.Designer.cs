﻿namespace wise_waste
{
    partial class NavForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pnSell = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.pnCatalogue = new System.Windows.Forms.Panel();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.pnTransHis = new System.Windows.Forms.Panel();
            this.btnTransHis = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.pnSell.SuspendLayout();
            this.pnCatalogue.SuspendLayout();
            this.pnTransHis.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 45);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wise Waste";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.RosyBrown;
            this.sidebar.Controls.Add(this.pnProfile);
            this.sidebar.Controls.Add(this.pnSell);
            this.sidebar.Controls.Add(this.pnCatalogue);
            this.sidebar.Controls.Add(this.pnTransHis);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 45);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(217, 392);
            this.sidebar.TabIndex = 1;
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.btnProfile);
            this.pnProfile.Location = new System.Drawing.Point(2, 2);
            this.pnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(183, 51);
            this.pnProfile.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.RosyBrown;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-8, -14);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(239, 74);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnSell
            // 
            this.pnSell.Controls.Add(this.btnSell);
            this.pnSell.Location = new System.Drawing.Point(2, 57);
            this.pnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnSell.Name = "pnSell";
            this.pnSell.Size = new System.Drawing.Size(183, 51);
            this.pnSell.TabIndex = 3;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(-8, -14);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(239, 73);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnCatalogue
            // 
            this.pnCatalogue.Controls.Add(this.btnCatalogue);
            this.pnCatalogue.Location = new System.Drawing.Point(2, 112);
            this.pnCatalogue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnCatalogue.Name = "pnCatalogue";
            this.pnCatalogue.Size = new System.Drawing.Size(183, 51);
            this.pnCatalogue.TabIndex = 3;
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCatalogue.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogue.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogue.Image")));
            this.btnCatalogue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogue.Location = new System.Drawing.Point(-8, -10);
            this.btnCatalogue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCatalogue.Size = new System.Drawing.Size(242, 76);
            this.btnCatalogue.TabIndex = 0;
            this.btnCatalogue.Text = "Catalogue";
            this.btnCatalogue.UseVisualStyleBackColor = false;
            this.btnCatalogue.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnTransHis
            // 
            this.pnTransHis.Controls.Add(this.btnTransHis);
            this.pnTransHis.Location = new System.Drawing.Point(2, 167);
            this.pnTransHis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTransHis.Name = "pnTransHis";
            this.pnTransHis.Size = new System.Drawing.Size(205, 51);
            this.pnTransHis.TabIndex = 3;
            // 
            // btnTransHis
            // 
            this.btnTransHis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTransHis.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransHis.Image = ((System.Drawing.Image)(resources.GetObject("btnTransHis.Image")));
            this.btnTransHis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransHis.Location = new System.Drawing.Point(-10, -10);
            this.btnTransHis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransHis.Name = "btnTransHis";
            this.btnTransHis.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTransHis.Size = new System.Drawing.Size(257, 78);
            this.btnTransHis.TabIndex = 0;
            this.btnTransHis.Text = "Transaction History";
            this.btnTransHis.UseVisualStyleBackColor = false;
            this.btnTransHis.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(2, 222);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(214, 51);
            this.pnLogout.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-10, -11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(244, 69);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.LightPink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 437);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NavForm";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.NavForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnSell.ResumeLayout(false);
            this.pnCatalogue.ResumeLayout(false);
            this.pnTransHis.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnCatalogue;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.Panel pnSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel pnTransHis;
        private System.Windows.Forms.Button btnTransHis;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}