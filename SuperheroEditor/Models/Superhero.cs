using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroEditor.Models
{
    public class Superhero
    {
        private string name;
        private int power;
        private int speed;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
