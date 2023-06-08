using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Monster
    {
        string _name;
        double _damage;
        double _hp;
        double _def;
        double _reward;

        public Monster(string name, double damage, double hp, double def, double reward)
        {
            _name = name;
            _damage = damage;
            _hp = hp;
            _def = def;
            _reward = reward;
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
        public double reward
        {
            get => _reward;
            set => _reward = value;
        }
    }
}
