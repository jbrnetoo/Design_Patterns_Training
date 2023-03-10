using Design_Patterns_Training.Facade.Interfaces;
using System;

namespace Design_Patterns_Training.Facade
{
    public class FornecedorPizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando a Pizza Normal.");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando a Pizza Vegana.");
        }

        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo cobertura de pizza não vegetais.");
        }
    }
}
