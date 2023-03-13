using System;

namespace Design_Patterns_Training.Strategy
{
    public static class StrategyPattern
    {
        public static void Run()
        {
            var value = Convert.ToDecimal(Console.ReadLine());

            Purchase purchase = new Purchase(value);

            Console.Write("----------------Pagar com Cartão de Crédito:----------------\n");
            purchase.ProcessPurchase(new CreditCardPayment());

            Console.Write("\n----------------Pagar com Cartão de Débito:----------------\n");
            purchase.ProcessPurchase(new DebitCardPayment());

            Console.ReadKey();
        }
    }
}
