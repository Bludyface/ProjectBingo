using System;
using System.Text;


namespace KataBingo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";

            do
            {
                Console.WriteLine("Bingo Kata");
                ImprimeMenu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        //Generating Card
                        BingoCard card = new BingoCard();

                        //Generating numbers and validate match 
                        Number number = new Number();
                        number.GenerateNumbers(card.GenerateCard());    
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Not valid");
                        break;
                }

            } while (opcion != "2");

            static void ImprimeMenu()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("1. Generate Card");
                sb.AppendLine("2. Leave");
                sb.Append("Choose an opcion: ");

                Console.Write(sb.ToString());
            }

        }   
    }
}
