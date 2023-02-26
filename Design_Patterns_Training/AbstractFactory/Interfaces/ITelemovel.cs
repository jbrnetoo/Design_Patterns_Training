namespace Design_Patterns_Training.AbstractFactory.Interfaces
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();
    }
}
