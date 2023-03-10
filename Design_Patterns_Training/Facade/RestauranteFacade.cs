using Design_Patterns_Training.Facade.Interfaces;

namespace Design_Patterns_Training.Facade
{
    public class RestauranteFacade
    {
        private readonly IPizza _fornecedorPizza;
        private readonly IPao _fornecedorPao;

        public RestauranteFacade()
        {
            _fornecedorPizza = new FornecedorPizza();
            _fornecedorPao = new FornecedorPao();
        }

        public void BuscarPizzaNormal()
        {
            _fornecedorPizza.BuscarPizzaNormal();
        }

        public void BuscarPizzaVegana()
        {
            _fornecedorPizza.BuscarPizzaVegana();
        }

        public void BuscarPaoDeAlho()
        {
            _fornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            _fornecedorPao.BuscarPaoDeAlhoComQueijo();
        }
    }
}
