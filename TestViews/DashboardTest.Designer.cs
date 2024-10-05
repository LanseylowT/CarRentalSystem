namespace CarRentalSystem.TestViews
{
    partial class DashboardTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAvailableCars = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnAvailableCars);
            this.panel1.Controls.Add(this.btnRentCar);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(87, 150);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(122, 47);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(10, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 10);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(308, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(883, 625);
            this.pnlMain.TabIndex = 1;
            // 
            // btnAvailableCars
            // 
            this.btnAvailableCars.Image = global::CarRentalSystem.Properties.Resources.car;
            this.btnAvailableCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAvailableCars.Location = new System.Drawing.Point(46, 370);
            this.btnAvailableCars.Name = "btnAvailableCars";
            this.btnAvailableCars.Size = new System.Drawing.Size(188, 57);
            this.btnAvailableCars.TabIndex = 4;
            this.btnAvailableCars.Text = "Available Cars";
            this.btnAvailableCars.UseVisualStyleBackColor = true;
            this.btnAvailableCars.Click += new System.EventHandler(this.btnAvailableCars_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.Image = global::CarRentalSystem.Properties.Resources.check;
            this.btnRentCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentCar.Location = new System.Drawing.Point(46, 446);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(188, 57);
            this.btnRentCar.TabIndex = 4;
            this.btnRentCar.Text = "Rent Car";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::CarRentalSystem.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(46, 293);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(188, 59);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalSystem.Properties.Resources.user_test;
            this.pictureBox1.Location = new System.Drawing.Point(95, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 627);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardTest";
            this.Text = "DashboardTest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnAvailableCars;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMain;
    }
}