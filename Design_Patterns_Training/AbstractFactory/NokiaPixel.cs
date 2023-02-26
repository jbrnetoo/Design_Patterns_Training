using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory
{
    /// <summary>
    /// ProdutoA1
    /// </summary>
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
