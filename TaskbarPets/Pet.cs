using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskbarPets
{
    class Pet
    {
        public string Name, CurrentState;
        public int Width, Height;
        public List<string> Actions = new List<string>();
        public Point Position = new Point(0,0);
        public Model Model;

        public Pet(string name, int width, int height, string[] actions)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
            this.Actions.AddRange(actions);
            this.Model = new Model(this.Name, this.Actions);
        }
    }
}
