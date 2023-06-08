using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Location
    {

        string _name;
        List<Monster> _monsters;
        Boss _finalboss;

        public Location(string name, List<Monster> monsters, Boss finalboss)
        {
            _name = name;
            _monsters = monsters;
            _finalboss = finalboss;
        }
        public string name
        {
            get => _name;
            set => _name = value;
        }
        public List<Monster> monsters
        {
            get => _monsters;
            set => _monsters = value;
        }

        public Boss finalboss
        {
            get => _finalboss;
            set => _finalboss = value;
        }
    }
}
