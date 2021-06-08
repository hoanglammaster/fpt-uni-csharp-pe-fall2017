using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new Payment() { Amount = 1000 };
            payment.AmountChanged += notifyAmountChanged; // your handling function
            payment.Amount = 990;
            Console.WriteLine("Tax : " + payment.ComputeTax());
            Console.ReadKey();
        }

        private static void notifyAmountChanged(object sender, float newValue)
        {
            Payment payment = (Payment)sender;
            Console.WriteLine("Amount changed - old value: {0}, new value: {1}", payment.Amount, newValue);
        }
    }
}

