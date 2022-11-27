using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.D && this.Width > panel3.Location.X)
            {
                panel3.Location = new Point(panel3.Location.X + 10, panel3.Location.Y);
                label1.Text = "X: " + panel3.Location.X;
                label2.Text = "Y: " + panel3.Location.Y;
            } else if(e.KeyCode == Keys.D && panel3.Location.X >= this.Width)
            {
                panel3.Location = new Point(0, panel3.Location.Y);
            }
            if (e.KeyCode == Keys.A && panel3.Location.X > 0)
            {
                panel3.Location = new Point(panel3.Location.X - 10, panel3.Location.Y);
                label1.Text = "X: " + panel3.Location.X;
                label2.Text = "Y: " + panel3.Location.Y;
            }
            else if (e.KeyCode == Keys.A && panel3.Location.X <= 0)
            {
                panel3.Location = new Point(this.Width, panel3.Location.Y);
            }
            if (e.KeyCode == Keys.W && panel3.Location.Y > 0)
            {
                label1.Text = "X: " + panel3.Location.X;
                label2.Text = "Y: " + panel3.Location.Y;
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y - 10);
            }
            else if (e.KeyCode == Keys.W && panel3.Location.Y <= 0)
            {
                panel3.Location = new Point(panel3.Location.X, this.Height);
            }
            if (e.KeyCode == Keys.S && panel3.Location.Y < this.Height)
            {
                label1.Text = "X: " + panel3.Location.X;
                label2.Text = "Y: " + panel3.Location.Y;
                panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + 10);
            }
            else if (e.KeyCode == Keys.S && panel3.Location.Y >= this.Height)
            {
                panel3.Location = new Point(panel3.Location.X,0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
