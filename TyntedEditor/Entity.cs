using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Entity
    {
        public string name;
        public string tag;

        public Entity(string name, string tag = "Default")
        {
            this.name = name;
            this.tag = tag;
        }
    }
}
