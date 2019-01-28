using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class Cup
    {
        private List<Die> _dice = new List<Die>();
        private Random _rnd = new Random();

        public bool IsEmpty
        {
            get
            {
                return _dice.Count == 0;
            }
        }

        public Cup()
        {
            Reset();
        }

        public void Reset()
        {
            _dice.Clear();
            LoadDice(6, new GreenDie());
            LoadDice(4, new YellowDie());
            LoadDice(3, new RedDie());
        }

        private void LoadDice(int numOfDice, Die die)
        {
            for(int i = 0; i < numOfDice; i++)
            {
                _dice.Add(die);
            }
        }

        public Die PullDie()
        {
            Die result = null;
            int index = _rnd.Next(0, _dice.Count);
            result = _dice[index];
            _dice.RemoveAt(index);
            return result;
        }
    }
}
