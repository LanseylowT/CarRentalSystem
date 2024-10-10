using CarRentalSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem.TestViews
{
    public partial class DashboardTest : Form
    {
        public DashboardTest()
        {
            InitializeComponent();
        }

        // private void DashboardTest_Load(object sender, EventArgs e)
        // {
        //     // Add Style to Panel3
        //     PanelStyle.ApplyRoundedCorners(panel3, 40);
        //     PanelStyle.ApplyShadow(panel3, 1, Color.Gray);
        //
        //     // Add style to Analytics Panel
        //     PanelStyle.ApplyRoundedCorners(pnlAnalytics, 40);
        //     PanelStyle.ApplyShadow(pnlAnalytics, 5, Color.Gray);
        // }

        private void LoadForm(object form)
        {
            if (pnlMain.Controls.Count > 0)
                pnlMain.Controls.RemoveAt(0);
            
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(f);
            pnlMain.Tag = f;
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new HomePageTest());
        }

        private void btnAvailableCars_Click(object sender, EventArgs e)
        {
            LoadForm(new AvailableCarsPageTest());
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            LoadForm(new RentCarPageTest());
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            LoadForm(new InquiryPageTest(pnlMain));
        }

        private void DashboardTest_Load(object sender, EventArgs e)
        {
            LoadForm(new HomePageTest());
        }
    }
    
    // 883, 625 - Size of pnlMain
}
