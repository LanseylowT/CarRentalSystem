using System;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.Helpers;

namespace CarRentalSystem.TestViews
{
    public partial class HomePageTest : Form
    {
        public HomePageTest()
        {
            InitializeComponent();
        }

        private void HomePageTest_Load(object sender, EventArgs e)
        {
            // Add Style to Panel3
            PanelStyle.ApplyRoundedCorners(panel3, 40);
            PanelStyle.ApplyShadow(panel3, 1, Color.Gray);
        
            // Add style to Analytics Panel
            PanelStyle.ApplyRoundedCorners(pnlAnalytics, 40);
            PanelStyle.ApplyShadow(pnlAnalytics, 5, Color.Gray);
        }
    }
}