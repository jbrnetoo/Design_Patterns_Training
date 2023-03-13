using Design_Patterns_Training.Strategy.Interface;

namespace Design_Patterns_Training.Strategy
{
    /// <summary>
    /// Context
    /// </summary>
    public class Purchase
    {
        public Purchase(decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; set; }

        public void ProcessPurchase(IPaymentStrategy paymentStrategy)
        {
            paymentStrategy.Pay(this);
        }
    }
}
