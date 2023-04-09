using System;

namespace S2
{
    class Card
    {
        public string Suit;
        public string Value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Classes
            //Card card = new Card();
            //card.Suit = "Clubs";
            //card.Value = "King";

            //Card card2 = new Card();
            //card2.Suit = "Spades";
            //card2.Value = "10";

            Card[] deck = new Card[52];

            int count = 0;
            for(int suit = 0; suit < 4; suit++)
            {
                for(int value = 1; value < 14; value++)
                {
                    Card card = new Card();
                    
                    if (suit == 0)      card.Suit = "Clubs";
                    else if (suit == 1) card.Suit = "Spades";
                    else if (suit == 2) card.Suit = "Hearts";
                    else                card.Suit = "Diamonds";

                    if(value > 10 || value == 1)
                    {
                        if      (value == 11) card.Value = "Jack";
                        else if (value == 12) card.Value = "Queen";
                        else if (value == 13) card.Value = "King";
                        else if (value == 1)  card.Value = "Ace";
                    }
                    else
                    {
                        card.Value = value.ToString();
                    }

                    deck[count] = card;
                    count++;
                }
            }

            for(int i = 0; i < deck.Length; i++)
            {
                Console.WriteLine("Suit: " + deck[i].Suit);
                Console.WriteLine("Value: " + deck[i].Value);
            }

            // Casting (Implicit and Explicit)
            //double d = 5.76;
            //int i = (int)d;

            //int i2 = 5;
            //double d2 = i2;

            //Console.WriteLine(i);

            // Arthmetic Operators (+, -, *, /, ++, --)
            //int i = 1;
            //i--;
            //Console.WriteLine(i);

            // Assignment Operators (+=, -=, ...)
            //int i = 1;
            //i += 3;
            //Console.WriteLine(i);

            // Comparison Operators (<, >, <=, ==, ...)
            //if(4 == 5) { }

            // Logic Operators (&&, ||, !)
            //bool check = true;
            //int i = 6;
            //int j = 10;

            //if (!true) { }

            // While Loops
            //int count = 1;

            //while (count < 6)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}

            // For Loops
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Arrays

            //                              0,        1
            string[] names = new string[2];
            names[0] = "Andrew";
            names[1] = "Douglas";
 
            for(int i = 0; i < names.Length; i++)
            {
                //Console.WriteLine(names[i]);
            }

            int[] values = new int[] { 0, 2, 0, 0 };

            int[,] values2D = new int[,]
            {  // 0  1
                { 0, 2 }, //0
                { 0, 0 } // 1
            };

            //values2D[0,1]

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(values2D[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
