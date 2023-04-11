using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskbarPets
{
    public partial class Form1 : Form
    {
        Pet Duck = new Pet("Duck", 20, 20, new string[] { "walk" });
        public Point canvasOffset;

        public Form1()
        {
            InitializeComponent();
            Screen screen = Screen.FromControl(this);
            this.Width = screen.Bounds.Width;
            this.Height = 100;
            canvasOffset = new Point(0, screen.WorkingArea.Height - this.Height);
            this.Location = canvasOffset;
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(Image.FromFile(Duck.Model.Models["walk"].ElementAt(0)), new Point(0,0));
        }
    }
}
