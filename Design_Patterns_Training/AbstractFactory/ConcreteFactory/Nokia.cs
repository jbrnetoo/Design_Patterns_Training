using Design_Patterns_Training.AbstractFactory.Interfaces;

namespace Design_Patterns_Training.AbstractFactory.ConcreteFactory
{
    /// <summary>
    /// ConcreteFactory1
    /// </summary>
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
