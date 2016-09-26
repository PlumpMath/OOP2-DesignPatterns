using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class TwitterStrategy :IShareStrategy
    {
        public void Share(string message) {

            Console.WriteLine($"Sharing {message} to Twitter");
        }
    }
}
