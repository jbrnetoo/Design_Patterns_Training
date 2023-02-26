using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory
{
    /// <summary>
    /// ProdutoA2
    /// </summary>
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
