using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 frm = new Form2()
            {
                TopLevel = false,
                TopMost = true
            };
            this.guna2Panel3.Controls.Add(frm);
            frm.Show();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

            this.guna2Panel3.Controls.Clear();
            Form2 frm = new Form2()
            {
                TopLevel = false,
                TopMost = true
            };
            this.guna2Panel3.Controls.Add(frm);
            frm.Show();
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;
        void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                  (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {

            this.guna2Panel3.Controls.Clear();
            about frm = new about()
            {
                TopLevel = false,
                TopMost = true
            };
            this.guna2Panel3.Controls.Add(frm);
            frm.Show();
        }
    }
}