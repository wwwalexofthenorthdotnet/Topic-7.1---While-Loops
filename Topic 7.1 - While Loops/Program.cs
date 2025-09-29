using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Topic_7._1___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coinOutput;
            double bet, totalMoney = 100.00;
            string gameChoice = "", coinChoice;
            bool done = false, coinPicked = false, validBet = false;

            Random generator;
            generator = new Random();

            Console.WriteLine("Type ENTER to start");
            Console.ReadLine();
            Console.Clear();

            while (!done)
            {
                Console.WriteLine("Flip (f) or Quit (q)?");
                gameChoice = Console.ReadLine();

                
                
                
                if (gameChoice.ToLower() == "quit" || gameChoice.ToLower() == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    done = true;
                }
                else if (gameChoice.ToLower() == "flip" || gameChoice.ToLower() == "f")
                {
                    Console.Write("Heads (h) or Tails (t)? ");
                    coinChoice = Console.ReadLine();

                    if (coinChoice.ToLower() == "t" || coinChoice.ToLower() == "tails")
                        coinPicked = true;

                    else if (coinChoice.ToLower() == "h" || coinChoice.ToLower() == "heads")
                        coinPicked = true;

                    while (coinPicked == false)
                    {
                        Console.Write("Heads (h) or Tails (t)? ");
                        coinChoice = Console.ReadLine();

                        if (coinChoice.ToLower() == "t" || coinChoice.ToLower() == "tails")
                            coinPicked = true;

                        else if (coinChoice.ToLower() == "h" || coinChoice.ToLower() == "heads")
                            coinPicked = true;
                    }

                    


                        Console.Clear();
                    Console.Write("Enter Bet (Balance: " + totalMoney.ToString("c") + ") ");
                    double.TryParse(Console.ReadLine(), out bet);
                    
                    while (bet <= 0 || bet > totalMoney)
                    {
                        Console.Write("Enter Bet (Balance: " + totalMoney.ToString("c") + ") ");
                        double.TryParse(Console.ReadLine(), out bet);
                    }

                    Console.Clear();
                    Console.WriteLine("You've bet " + bet.ToString("c"));
                    validBet = false;

                    if (coinChoice.ToLower() == "heads" || coinChoice.ToLower() == "h")
                        Console.WriteLine("You bet on heads");
                    else if (coinChoice.ToLower() == "tails" || coinChoice.ToLower() == "t")
                        Console.WriteLine("You bet on tails");

                        Console.WriteLine("Flipping...");
                    coinOutput = generator.Next(2);
                    System.Threading.Thread.Sleep(2000);

                    if (coinOutput == 0)
                    {
                        Console.WriteLine("You flipped heads!");
                        if (coinChoice == "h" || coinChoice == "heads")
                        {
                            Console.WriteLine("You Win!");
                            if (bet != 0)
                                totalMoney = (totalMoney + (bet * 1.5));
                            coinPicked = false;
                            
                        }

                        else
                        {
                            Console.WriteLine("You Lose!");
                            totalMoney = (totalMoney - bet);
                            if (totalMoney <= 0)
                            {
                                totalMoney = 0;
                                done = true;
                            
                            }
                            coinPicked = false;


                        }
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (coinOutput == 1)
                    {
                        Console.WriteLine("You flipped Tails!");
                        if (coinChoice.ToLower() == "t" || coinChoice.ToLower() == "tails")
                        {
                            Console.WriteLine("You Win!");
                            if (bet != 0)
                                totalMoney = (totalMoney + (bet * 1.5));
                            coinPicked = false;


                        }

                        else
                        {
                            Console.WriteLine("You Lose!");
                            totalMoney = (totalMoney - bet);
                            if (totalMoney <= 0)
                            {
                                totalMoney = 0;
                                done = true;
                            }
                            coinPicked = false;

                        }
                        Console.ReadLine();
                        Console.Clear();

                        Console.Clear();
                    }
                    if (totalMoney == 0)
                    {
                        Console.WriteLine("You are out of money.  Come again soon");
                        done = true;
                    }
                }

               
               
                
            }
            Console.WriteLine("Your total balance is " + totalMoney.ToString("c"));
            Console.ReadLine();



        }

   
    }

}
