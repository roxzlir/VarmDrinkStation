using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks;

namespace VarmDrinkStation.Factories
{
    internal class HotChocolateFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot chocolate in your cup");
            return new Chocolate();
        }
    
    }
}
