using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        string _name;
        double _damage;
        double _hp;
        int _coins;

        public Player(string name, double damage, double hp)
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
        public int Coins
        {
            get => _coins;
            set => _coins = value;
        }
    }
}
