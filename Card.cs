using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Card
    {

        int[] card;
        int index = 0;


        public void show()
        {
            int rank, suit = 0;
            rank = index - 1;
            while (card[rank] > 13)
            {
                card[rank] -= 13;
                suit++;
            }
            if (card[rank] > 10)
            {
                if (card[rank] == 11)
                {
                    Console.Write("J ");
                }
                else if (card[rank] == 12)
                {
                    Console.Write("Q ");
                }
                else if (card[rank] == 13)
                {
                    Console.Write("K ");
                }
            }
            else
            {
                if (card[rank] == 1)
                {
                    Console.Write("A ");
                }
                else
                {
                    Console.Write(card[rank] + " ");
                }
            }
            if (suit == 0)
            {
                Console.WriteLine("Clubs");
            }
            else if (suit == 1)
            {
                Console.WriteLine("Diamonds");
            }
            else if (suit == 2)
            {
                Console.WriteLine("Hearts");
            }
            else if (suit == 3)
            {
                Console.WriteLine("Spades");
            }
        }

        public Card()
        {
            card = new int[52];
            for (int i = 0; i < 52; i++)
            {
                card[i] = i + 1;
            }
        }
        public int Draw()
        {
            index--;
            return card[index];

        }
        public void AddCard(int n)
        {
            card[index] = n;
            index++;
        }
        public bool isEmpty()
        {
            if (index == 0)
            {

                return true;
            }
            return false;
        }

        int num;

        public void Shuffle()
        {
            Random random = new Random();
            bool[] chek;
            chek = new bool[53];
            for (int i = 0; i < 52; i++)
            {
                chek[i] = false;
            }
            for (int i = 0; i < 52; i++)
            {
                num = random.Next(52) + 1;
                while (chek[num] == true)
                {
                    num = random.Next(52) + 1;
                }
                card[i] = num;
                chek[num] = true;
            }
            index = 52;
        }

    }
}
