using Design_Patterns_Training.Facade.Interfaces;
using System;

namespace Design_Patterns_Training.Facade
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Buscando o Pão de Alho.");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Buscando o Pão de Alho com Queijo.");
        }

        private void ObterQueijo()
        {
            Console.WriteLine("Obtendo Queijo.");
        }
    }
}
