using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarmDrinkStation.Drinks;

namespace VarmDrinkStation.Factories
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
