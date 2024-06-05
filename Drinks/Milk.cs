using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Drinks
{
    internal class Milk : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm milk is served.");
        }
    }
}
