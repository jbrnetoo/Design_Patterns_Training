using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
