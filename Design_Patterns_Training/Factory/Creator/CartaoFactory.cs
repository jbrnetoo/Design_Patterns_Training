using Design_Patterns_Training.Factory.Product;

namespace Design_Patterns_Training.Factory.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
