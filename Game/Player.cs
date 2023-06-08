using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        string _name;
        double _damage;
        double _hp;
        double _def;

        public Player(string name, double damage, double hp, double def)
        {
            _name = name;
            _damage = damage;
            _hp = hp;
            _def = def;
        }

        public string name
        {
            get => _name;
            set => _name = value;
        }
        public double damage
        {
            get => _damage;
            set => _damage = value;
        }
        public double hp
        {
            get => _hp;
            set => _hp = value;
        }
        public double def
        {
            get => _def;
            set => _def = value;
        }
    }
}
