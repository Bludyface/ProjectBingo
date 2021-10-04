using System;
using System.Collections.Generic;
using System.Text;

namespace KataBingo
{
    class Number
    {
        public Number()
        {

        }

        public void GenerateNumbers(int[,] card)
        {
            int nmatch = 0;
            for (int n = 1; n <= 75; n++)
            {
                bool winner = false;
                Random r = new Random();
                int number = r.Next(1, 76);

                Console.WriteLine("number {0} generated: {1}", n, number);
                for (int i = 0; i < card.GetLength(0); i++)
                {
                    
                    for (int j = 0; j < card.GetLength(1); j++)
                    {
                        if (card[i, j] == number)
                        {
                            nmatch++;
                            Console.WriteLine("match found value: {0}", card[i, j]);
                            Console.WriteLine("MATCH COUNTER: {0}", nmatch);

                            if(nmatch == 25)
                            {
                                Console.WriteLine("CONGRATULATIONS!!!! YOU WIN!!!");
                                winner = true;
                                break;
                            }
                        }
                    }
                    if(winner == true)
                    {
                        break;
                    }

                }
                if (winner == true)
                {
                    break;
                }
            }

            
        }
    }
    
}
