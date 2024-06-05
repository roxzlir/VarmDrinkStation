using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarmDrinkStation.Drinks
{
    internal class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm chocolate is served.");
        }
    }
}
