using Design_Patterns_Training.Factory.ConcretProduct;
using Design_Patterns_Training.Factory.Creator;
using Design_Patterns_Training.Factory.Product;

namespace Design_Patterns_Training.Factory.ConcretCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private readonly int _limiteCredito;
        private readonly int _cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            _limiteCredito = limiteCredito;
            _cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}
