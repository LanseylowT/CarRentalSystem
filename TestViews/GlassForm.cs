using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CarRentalSystem.Native;

namespace CarRentalSystem.TestViews
{
    public partial class GlassForm : Form
    {
    // defines how far we are extending the Glass margins
        private Win32.MARGINS margins;

        /// <summary>
        /// Override the onload, and define our Glass margins
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!Win32.DwmIsCompositionEnabled())
            {
                MessageBox.Show("This demo requires Vista, with Aero enabled.");
                Application.Exit();
            }
            SetGlassRegion();
        }
        /// <summary>
        /// Use the form padding values to define a Glass margin
        /// </summary>
        private void SetGlassRegion()
        {
            // Set up the glass effect using padding as the defining glass region
            if (Win32.DwmIsCompositionEnabled())
            {
                margins = new Win32.MARGINS();
                margins.Top = Padding.Top;
                margins.Left = Padding.Left;
                margins.Bottom = Padding.Bottom;
                margins.Right = Padding.Right;
                Win32.DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
        }
        /// <summary>
        /// Override the OnPaintBackground method, to draw the desired
        /// Glass regions black and display as Glass
        /// </summary>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Win32.DwmIsCompositionEnabled())
            {
                e.Graphics.Clear(Color.Black);
                // put back the original form background for non-glass area
                Rectangle clientArea = new Rectangle(
                margins.Left,
                margins.Top,
                this.ClientRectangle.Width - margins.Left - margins.Right,
                this.ClientRectangle.Height - margins.Top - margins.Bottom);
                Brush b = new SolidBrush(this.BackColor);
                e.Graphics.FillRectangle(b, clientArea);
            }
        }

        public GlassForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On scroll change the padding value, which is mapped to the Glass region.
        /// </summary>
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            this.Padding = new Padding(this.trackBar1.Value);
            SetGlassRegion();
            Invalidate();
        }
    }
}