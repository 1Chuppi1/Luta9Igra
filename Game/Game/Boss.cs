using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Boss
    {
        string _name;
        double _damage;
        double _hp;

        public Boss(string name, double damage, double hp, double reward)
        {
            _name = name;
            _damage = damage;
            _hp = hp;
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
        
    }
}
