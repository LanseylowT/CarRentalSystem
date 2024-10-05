using System.ComponentModel;

namespace CarRentalSystem.TestViews
{
    partial class HomePageTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlTotalIncome = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCar = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblCarCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAnalytics = new System.Windows.Forms.Panel();
            this.cartesianCustomerData = new LiveCharts.WinForms.CartesianChart();
            this.cartesianIncomeData = new LiveCharts.WinForms.CartesianChart();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlTotalIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pnlCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlAnalytics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pnlTotalIncome);
            this.panel3.Controls.Add(this.pnlCar);
            this.panel3.Location = new System.Drawing.Point(1, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 129);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(624, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 105);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CarRentalSystem.Properties.Resources.people;
            this.pictureBox7.Location = new System.Drawing.Point(12, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "9";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Customer";
            // 
            // pnlTotalIncome
            // 
            this.pnlTotalIncome.Controls.Add(this.pictureBox6);
            this.pnlTotalIncome.Controls.Add(this.label3);
            this.pnlTotalIncome.Controls.Add(this.label4);
            this.pnlTotalIncome.Location = new System.Drawing.Point(315, 10);
            this.pnlTotalIncome.Name = "pnlTotalIncome";
            this.pnlTotalIncome.Size = new System.Drawing.Size(201, 105);
            this.pnlTotalIncome.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRentalSystem.Properties.Resources.money;
            this.pictureBox6.Location = new System.Drawing.Point(12, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "$11,590.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Income";
            // 
            // pnlCar
            // 
            this.pnlCar.Controls.Add(this.pictureBox5);
            this.pnlCar.Controls.Add(this.lblCarCount);
            this.pnlCar.Controls.Add(this.label2);
            this.pnlCar.Location = new System.Drawing.Point(14, 10);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(201, 105);
            this.pnlCar.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRentalSystem.Properties.Resources.car;
            this.pictureBox5.Location = new System.Drawing.Point(12, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // lblCarCount
            // 
            this.lblCarCount.AutoSize = true;
            this.lblCarCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCarCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCount.Location = new System.Drawing.Point(182, 0);
            this.lblCarCount.Name = "lblCarCount";
            this.lblCarCount.Size = new System.Drawing.Size(19, 21);
            this.lblCarCount.TabIndex = 1;
            this.lblCarCount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Cars";
            // 
            // pnlAnalytics
            // 
            this.pnlAnalytics.Controls.Add(this.cartesianCustomerData);
            this.pnlAnalytics.Controls.Add(this.cartesianIncomeData);
            this.pnlAnalytics.Location = new System.Drawing.Point(12, 170);
            this.pnlAnalytics.Name = "pnlAnalytics";
            this.pnlAnalytics.Size = new System.Drawing.Size(856, 443);
            this.pnlAnalytics.TabIndex = 2;
            // 
            // cartesianCustomerData
            // 
            this.cartesianCustomerData.Location = new System.Drawing.Point(478, 64);
            this.cartesianCustomerData.Name = "cartesianCustomerData";
            this.cartesianCustomerData.Size = new System.Drawing.Size(358, 348);
            this.cartesianCustomerData.TabIndex = 0;
            this.cartesianCustomerData.Text = "cartesianChart1";
            // 
            // cartesianIncomeData
            // 
            this.cartesianIncomeData.Location = new System.Drawing.Point(12, 64);
            this.cartesianIncomeData.Name = "cartesianIncomeData";
            this.cartesianIncomeData.Size = new System.Drawing.Size(388, 348);
            this.cartesianIncomeData.TabIndex = 0;
            this.cartesianIncomeData.Text = "cartesianChart1";
            // 
            // HomePageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 625);
            this.Controls.Add(this.pnlAnalytics);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageTest";
            this.Text = "HomePageTest";
            this.Load += new System.EventHandler(this.HomePageTest_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlTotalIncome.ResumeLayout(false);
            this.pnlTotalIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pnlCar.ResumeLayout(false);
            this.pnlCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlAnalytics.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlAnalytics;
        private LiveCharts.WinForms.CartesianChart cartesianCustomerData;
        private LiveCharts.WinForms.CartesianChart cartesianIncomeData;

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlTotalIncome;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblCarCount;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}