using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Food f = new Food() { Amount = 1000 };
            f.AmountChanged += notifyAmountChanged; // your handling function
            f.Amount = 990;
            Console.WriteLine( "Calory:" +f.ComputeCalory());
            Console.ReadKey();
        }
        private static void notifyAmountChanged(object sender, float newValue)
        {
            Food food = (Food)sender;
            Console.WriteLine("Amount changed – old value: {0}, new value : {1}", food.Amount, newValue);
        }
    }
}
