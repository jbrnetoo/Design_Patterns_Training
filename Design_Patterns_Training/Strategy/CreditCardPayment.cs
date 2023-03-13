using Design_Patterns_Training.Strategy.Interface;
using System;

namespace Design_Patterns_Training.Strategy
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(Purchase purchase)
        {
            Console.WriteLine("Pagou no crédito " + purchase.Value);
        }
    }
}
