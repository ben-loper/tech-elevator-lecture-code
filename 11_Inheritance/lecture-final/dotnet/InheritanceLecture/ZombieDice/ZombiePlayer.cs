using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie
{
    public class ZombiePlayer : Player
    {
        private const int NumberDiePerRoll = 3;
        private const int MaxBlastCount = 3;

        public int TotalBrains { get; set; }
        public int TurnBlasts { get; set; }
        public int TurnBrains { get; set; }
        public int TurnFeet
        {
            get
            {
                return _lastFeetDie.Count;
            }
        }
        public bool BlastExceeded
        {
            get
            {
                return TurnBlasts >= MaxBlastCount;
            }
        }

        public int RoundCount { get; set; }
        private List<Die> _lastFeetDie = new List<Die>();
        private Cup _cup = new Cup();

        public ZombiePlayer() : base()
        {
            ResetGame();
        }

        public void ResetGame()
        {
            ResetTurn();
            RoundCount = 1;            
        }

        private void ResetTurn()
        {
            // Reset turn info
            TurnBrains = 0;
            TurnBlasts = 0;
            _cup.Reset();
            _lastFeetDie.Clear();
        }

        public void TakeRoll()
        {
            VerifyBlastCount();

            // Collect the dice to roll
            List<Die> pulledDice = new List<Die>();
            for (int i = 0; i < (NumberDiePerRoll - _lastFeetDie.Count); i++)
            {
                pulledDice.Add(_cup.PullDie());
            }
            foreach (var die in _lastFeetDie)
            {
                pulledDice.Add(die);
            }
            _lastFeetDie.Clear();

            // Roll the dice
            foreach (var die in pulledDice)
            {
                string side = die.Roll();
                if(side == Die.Blast)
                {
                    TurnBlasts++;
                }
                else if(side == Die.Feet)
                {
                    // Save the number of feet rolled
                    _lastFeetDie.Add(die);
                }
                else
                {
                    TurnBrains++;
                }
            }         
            
            // Check to see if blast count has been exceeded
            if(BlastExceeded)
            {
                TurnBrains = 0;
                RoundCount++;
            }
        }

        public void PassTurn()
        {
            VerifyBlastCount();

            RoundCount++;
            TotalBrains += TurnBrains;
            ResetTurn();
        }

        private void VerifyBlastCount()
        {
            if (BlastExceeded)
            {
                throw new Exception("Blast count has already been exceeded.");
            }
        }

    }
}
