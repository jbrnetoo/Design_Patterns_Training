using Design_Patterns_Training.Strategy.Interface;
using System;

namespace Design_Patterns_Training.Strategy
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class DebitCardPayment : IPaymentStrategy
    {
        public void Pay(Purchase purchase)
        {
            Console.WriteLine("Pagou no débito " + purchase.Value);
        }
    }
}
