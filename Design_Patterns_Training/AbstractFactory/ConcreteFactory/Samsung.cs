using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory.ConcreteFactory
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
