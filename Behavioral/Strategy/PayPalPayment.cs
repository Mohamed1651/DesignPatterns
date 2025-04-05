using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }
}
