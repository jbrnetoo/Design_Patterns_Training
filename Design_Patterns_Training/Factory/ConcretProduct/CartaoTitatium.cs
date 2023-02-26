using Design_Patterns_Training.Factory.Product;

namespace Design_Patterns_Training.Factory.ConcretProduct
{
    public class CartaoTitanium : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoTitanium(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = "Titanium";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao { get => _tipoCartao; }
        public override int LimiteCredito { get => _limiteCredito; set => _limiteCredito = value; }
        public override int CobrancaAnual { get => _cobrancaAnual; set => _cobrancaAnual = value; }
    }
}
