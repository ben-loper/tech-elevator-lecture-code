using DeckOfCards.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    public class Cup
    {
        private List<object> _dice = new List<object>();
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

        private void LoadDice(int numOfDice, object die)
        {
            for(int i = 0; i < numOfDice; i++)
            {
                _dice.Add(die);
            }
        }

        public object PullDie()
        {
            object result = null;
            int index = _rnd.Next(0, _dice.Count);
            result = _dice[index];
            _dice.RemoveAt(index);
            return result;
        }
    }
}
