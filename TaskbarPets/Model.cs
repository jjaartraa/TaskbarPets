using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskbarPets
{
    class Model
    {
        public Dictionary<string, List<string>> Models = new Dictionary<string, List<string>>();

        public Model(string name, List<string> actions)
        {
            foreach (var keyWord in actions)
            {
                Models.Add(keyWord, new List<string>(Directory.GetFiles(@"C:\Users\Jaroslav\source\repos\TaskbarPets\Models\" + name, "*" + keyWord + "*.png")));
            }
        }
    }
}
