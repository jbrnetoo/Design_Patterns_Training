using System;

namespace Design_Patterns_Training.Facade
{
    public static class FacadePattern
    {
        public static void Run()
        {
            var facade = new RestauranteFacade();

            Console.WriteLine("---------------------PEDIDOS DE PIZZA DO CLIENTE---------------------\n");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            Console.WriteLine("\n---------------------PEDIDOS DE PÃO DO CLIENTE---------------------\n");
            facade.BuscarPaoDeAlho();
            facade.BuscarPaoDeAlhoComQueijo();
        }
    }
}
