using DeckOfCards.Classes;
using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            DieFun();

            //Deck deck = new Deck();

            //// Default output encoding (character set) is ASCII
            //// Set it to Unicode so we can display card sysbols
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //for (int i = 1; i <= 52; i++)
            //{
            //    Card topCard = deck.DealOne();

            //    Console.WriteLine($"{topCard.FaceValue} of {topCard.Suit} - {topCard.Symbol}");
            //}

            Console.ReadLine();
        }

        static void DieFun()
        {
            Cup cup = new Cup();

            while (!cup.IsEmpty)
            {
                PullAndRoll(cup);
            }
            
            //GreenDie die = new GreenDie();
            //string[] test = new string[13];
            //for (int i = 0; i < 13; i++)
            //{
            //    Console.WriteLine(die.Roll());
            //}

            //Console.WriteLine($"Probability Brain: {GreenDie.Probability(3, 6)}");
            //Console.WriteLine($"Probability Feet: {GreenDie.Probability(2, 6)}");
            //Console.WriteLine($"Probability Blast: {GreenDie.Probability(1, 6)}");
        }

        static void PullAndRoll(Cup cup)
        {
            var die = cup.PullDie();            

            string side = "";
            string color = "";
            if (die is GreenDie)
            {
                side = ((GreenDie)die).Roll();
                color = ((GreenDie)die).Color;
            }
            else if (die is YellowDie)
            {
                side = ((YellowDie)die).Roll();
                color = ((YellowDie)die).Color;
            }
            else if (die is RedDie)
            {
                side = ((RedDie)die).Roll();
                color = ((RedDie)die).Color;
            }
            Console.WriteLine($"You rolled a {color} {side}");
        }
    }
}
