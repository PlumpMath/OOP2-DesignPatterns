using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message to share");
            var msg = Console.ReadLine();
            do {
                Console.WriteLine("Enter service to share to");
                Console.WriteLine("1. Facebook");
                Console.WriteLine("2. Twitter");
                Console.WriteLine("3. Facebook & Twitter");


                var straegyNumber = int.Parse(Console.ReadLine());
                switch (straegyNumber)
                {
                    case 1:
                        Share(msg, new FacebookStrategy());
                        break;
                    case 2:
                        Share(msg, new TwitterStrategy());
                        break;
                    case 3:
                        Share(msg, new FacebookStrategy(), new TwitterStrategy());
                        break;
                }
            } while (true);
        }

        static void Share(string message, params IShareStrategy[] strategies) {
            foreach (var strategy in strategies) {
                strategy.Share(message);
            }
        }
    }
}
