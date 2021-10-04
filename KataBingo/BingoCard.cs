using System;
using System.Collections.Generic;
using System.Text;

namespace KataBingo
{
    class BingoCard
    {
        int[,] card = new int[5, 5];


        public BingoCard()
        {

        }

        public int[,] GenerateCard()
        {
            int min = 0;
            int max = 0;

            Random r = new Random();

            Console.WriteLine("Your numbers are: ");
            Console.WriteLine("B  I  N  G  O");
            for (int i = 0; i < card.GetLength(1); i++)
            {

                for (int j = 0; j < card.GetLength(0); j++)
                {
                    switch (j)
                    {
                        case 0:
                            min = 1;
                            max = 15;
                            break;
                        case 1:
                            min = 16;
                            max = 30;
                            break;
                        case 2:
                            min = 31;
                            max = 45;
                            break;
                        case 3:
                            min = 46;
                            max = 60;
                            break;
                        case 4:
                            min = 61;
                            max = 75;
                            break;
                    }
                    if (i == 2 && j == 2)
                    {
                        card[i, j] = 0;
                        Console.Write("   ");
                    }
                    else
                    {
                        card[i, j] = r.Next(min, max);
                        Console.Write("{0} ", card[i, j]);
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            return card;
        }

    }
}
