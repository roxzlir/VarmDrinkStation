using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks;

namespace VarmDrinkStation.Factories
{
    internal class HotMilkFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot milk in your cup");
            return new Milk();
        }
    }
}
