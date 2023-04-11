using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TaskbarPets
{
    public partial class Form1 : Form
    {
        Pet Duck = new Pet("Duck", 20, 20, new string[] { "walk" });
        public Point canvasOffset;
        public int i = 0, j = 0;

        public Form1()
        {
            InitializeComponent();
            Screen screen = Screen.FromControl(this);
            this.Width = screen.Bounds.Width;
            this.Height = 75;
            canvasOffset = new Point(0, screen.WorkingArea.Height - this.Height);
            this.Location = canvasOffset;
            this.TopMost = true;
            Form1.CheckForIllegalCrossThreadCalls = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer(50);
            t.AutoReset = true;
            t.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            t.Start();
        }

        private async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            RefreshForm();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(Image.FromFile(Duck.Model.Models["walk"].ElementAt(i)), new Point(j,0));
            j += 6;
            if (i < 9)
            {
                i++;
            }
            else
            {
                i = 0;
            }
        }

        private void RefreshForm()
        {
            this.Refresh();
        }
    }
}
