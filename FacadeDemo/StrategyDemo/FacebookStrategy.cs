using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class FacebookStrategy :IShareStrategy
    {
        public void Share(string message) {

            Console.WriteLine($"Sharing {message} to Facebook");
        }
    }
}
