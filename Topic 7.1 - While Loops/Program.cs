using System.Security.Cryptography.X509Certificates;

namespace Topic_7._1___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinOutput;
            double bet, totalMoney;
            string gameChoice;
            
            Random generator;
            generator = new Random();

            Console.WriteLine("Flip (f) or quit (q)?");
            gameChoice = Console.ReadLine();


            while (gameChoice != "quit" || gameChoice != "q" && gameChoice == "f" || gameChoice == "flip")
            {
                Console.Clear();
                Console.Write("Enter Bet (Balance: " + totalMoney.ToString("c") + ")" );
                double.TryParse(Console.ReadLine(), out bet);
                Console.Clear();
                Console.WriteLine("You've bet " + bet.ToString("c"));

                Console.WriteLine("Flipping...");
                coinOutput = generator.Next(2);
                System.Threading.Thread.Sleep(1000);
                if (coinOutput == 0)
                {
                    Console.WriteLine("You Win! You flipped heads");

                }

       
                
            }

          

        }

      
    }

}
