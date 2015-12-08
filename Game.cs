using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLowCardGame
{
    class Game
    {
        private Card deck;
        private Player p1, p2;
        int a1, a2, b1, i;
        public void Play()
        {
            while (true)
            {
                if (p1.isEmpty())
                {
                    Console.WriteLine("END GAME ");
                    Console.WriteLine("Score player 1 : " + p1.sc());
                    Console.WriteLine("Score player 2 : " + p2.sc());
                    Console.ReadLine();
                    break;
                }
                Console.Write("P1 : ");
                p1.Show();
                Console.Write("P2 : ");
                p2.Show();
                a1 = p1.play();
                a2 = p2.play();
                if (a1 > a2)
                {
                    Console.WriteLine("P1 Win");
                    p1.Addscore(1);
                }
                else if (a1 < a2)
                {
                    Console.WriteLine("P2 Win");
                    p2.Addscore(1);
                }
                else if (a1 == a2)
                {
                    Console.WriteLine("Deal");
                    b1 = a1;
                    for (i = 0; i < b1; i++)
                    {
                        if (p1.isEmpty())
                        {
                            break;
                        }
                        a1 = p1.play();
                        a2 = p2.play();

                    }
                    int suit = 0;
                    Console.Write("Play again P1 : ");
                    while (a1 > 13)
                    {
                        a1 -= 13;
                        suit++;
                    }
                    if (a1 > 10)
                    {
                        if (a1 == 11)
                        {
                            Console.Write("J ");
                        }
                        else if (a1 == 12)
                        {
                            Console.Write("Q ");
                        }
                        else if (a1 == 13)
                        {
                            Console.Write("K ");
                        }
                    }
                    else
                    {
                        if (a1 == 1)
                        {
                            Console.Write("A ");
                        }
                        else
                        {
                            Console.Write(a1 + " ");
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
                    Console.Write("Play again P2 : ");
                    suit = 0;
                    while (a2 > 13)
                    {
                        a2 -= 13;
                        suit++;
                    }
                    if (a2 > 10)
                    {
                        if (a2 == 11)
                        {
                            Console.Write("J ");
                        }
                        else if (a2 == 12)
                        {
                            Console.Write("Q ");
                        }
                        else if (a2 == 13)
                        {
                            Console.Write("K ");
                        }
                    }
                    else
                    {
                        if (a2 == 1)
                        {
                            Console.Write("A ");
                        }
                        else
                        {
                            Console.Write(a2 + " ");
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
                    if (a1 > a2)
                    {
                        Console.WriteLine("P1 Win");
                        p1.Addscore(i + 1);
                    }
                    else if (a1 < a2)
                    {
                        Console.WriteLine("P2 Win");
                        p2.Addscore(i + 1);
                    }
                    else if (a1 == a2)
                    {
                        deck = new Card();
                        deck.Shuffle();
                        p1 = new Player();
                        p2 = new Player();
                        for (int i = 0; i < 26; i++)
                        {
                            p1.AddCard(deck.Draw());
                            p2.AddCard(deck.Draw());
                        }
                        Console.WriteLine("----New Game ----");
                        Play();
                    }
                }

                Console.ReadLine();
            }
        }
        public void Deal()
        {

        }
        public Game()
        {
            deck = new Card();
            deck.Shuffle();
            p1 = new Player();
            p2 = new Player();
            for (int i = 0; i < 26; i++)
            {
                p1.AddCard(deck.Draw());
                p2.AddCard(deck.Draw());
            }

            Play();
        }
    }
}