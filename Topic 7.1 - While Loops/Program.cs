using System.Security.Cryptography.X509Certificates;

namespace Topic_7._1___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinOutput;
            double bet, totalMoney = 100.00;
            string gameChoice = "";
            bool done = false;

            Random generator;
            generator = new Random();

            Console.WriteLine("Type ENTER to start");
            Console.ReadLine();
            Console.Clear();


            while (!done)
            {
                Console.WriteLine("Flip (f) or Quit (q)?");
                gameChoice = Console.ReadLine();
                if (gameChoice == "quit" || gameChoice == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                }
                else
                {


                    Console.Clear();
                    Console.Write("Enter Bet (Balance: " + totalMoney.ToString("c") + ") ");
                    double.TryParse(Console.ReadLine(), out bet);
                    while (bet > totalMoney || bet < 0)
                    {
                        Console.Write("Enter Bet (Balance: " + totalMoney.ToString("c") + ") ");
                        double.TryParse(Console.ReadLine(), out bet);
                    }
                    Console.Clear();
                    Console.WriteLine("You've bet " + bet.ToString("c"));

                    Console.WriteLine("Flipping...");
                    coinOutput = generator.Next(2);
                    System.Threading.Thread.Sleep(1000);

                    if (coinOutput == 0)
                    {
                        Console.WriteLine("You Win! You flipped heads");
                        Console.ReadLine();
                        if (bet != 0)
                            totalMoney = (totalMoney + (bet * 1.5));
                        Console.Clear();
                    }
                    else if (coinOutput == 1)
                    {
                        Console.WriteLine("You Lose! You flipped tails.");
                        Console.ReadLine();
                        totalMoney = (totalMoney - bet);
                        if (totalMoney < 0)
                            totalMoney = 0;
                        Console.Clear();
                    }
                    if (totalMoney == 0)
                    {
                        Console.WriteLine("You are out of money.  Come again soon");
                        done = true;
                    }
                }

                Console.WriteLine("Your winnings are " + totalMoney.ToString("c"));
                Console.ReadLine();
                
            }

          

        }

      
    }

}
