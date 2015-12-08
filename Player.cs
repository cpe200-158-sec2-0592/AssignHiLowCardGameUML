using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Player
    {
        private Card deck;
        private int score = 0;


        public int sc()
        {
            return score;
        }

        public Player()
        {
            deck = new Card();
        }

        public void Draw()
        {
            deck.Draw();
        }

        public void Show()
        {
            deck.show();
        }

        public int Addscore(int a)
        {
            return score += a;
        }

        public int play()
        {
            return deck.Draw();
        }

        public void AddCard(int n)
        {
            deck.AddCard(n);
        }

        public bool isEmpty()
        {
            return deck.isEmpty();
        }

    }
}