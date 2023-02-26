using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory
{
    /// <summary>
    /// ProdutoB2
    /// </summary>
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
