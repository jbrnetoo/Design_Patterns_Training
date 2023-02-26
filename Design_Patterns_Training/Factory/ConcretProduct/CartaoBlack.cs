using Design_Patterns_Training.Factory.Product;

namespace Design_Patterns_Training.Factory.ConcretProduct
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;

        public CartaoBlack(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = "Black";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao { get => _tipoCartao; }
        public override int LimiteCredito { get => _limiteCredito; set => _limiteCredito = value; }
        public override int CobrancaAnual { get => _cobrancaAnual; set => _cobrancaAnual = value; }
    }
}
