using Design_Patterns_Training.Factory.ConcretCreator;
using Design_Patterns_Training.Factory.Creator;
using Design_Patterns_Training.Factory.Product;
using System;

namespace Design_Patterns_Training.Factory
{
    public static class Factory_Pattern
    {
        public static void Run()
        {
            Console.Write("Digite o tipo do cartão que gostaria de obter: ");
            var console = Console.ReadLine();

            var cartaoFactory = CreateCartaoFactory(console);

            CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();

            Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");

            Console.WriteLine($"Tipo do cartão: {cartaoCredito.TipoCartao}\n" +
                              $"Crédito limite: {cartaoCredito.LimiteCredito}\n" +
                              $"Cobrança anual: {cartaoCredito.CobrancaAnual}");
        }

        private static CartaoFactory CreateCartaoFactory(string input)
        {
            CartaoFactory cartaoFactory = null;

            switch (input.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(100000, 500);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            return cartaoFactory;
        }
    }
}
