using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
        ISmartPhone _smartPhone;
        INormalPhone _normalPhone;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            _smartPhone = telemovelFactory.BuscarSmartPhone();
            _normalPhone = telemovelFactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return _smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalModeloDetalhes()
        {
            return _normalPhone.BuscarDetalhesModelo();
        }
    }
}
