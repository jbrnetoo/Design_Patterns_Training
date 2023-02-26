using Design_Patterns_Training.AbstractFactory.ConcreteFactory;
using Design_Patterns_Training.AbstractFactory.Interfaces;
using System;

namespace Design_Patterns_Training.AbstractFactory
{
    public static class Abstract_Factory_Pattern
    {
        public static void Run()
        {
            ITelemovel nokiaTelemovel = new Nokia();
            TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

            ITelemovel samsungTelemovel = new Samsung();
            TelemovelClient samsungClient = new TelemovelClient(samsungTelemovel);

            Console.WriteLine("****************** NOKIA *******************");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokiaClient.BuscarNormalModeloDetalhes());

            Console.WriteLine("****************** SAMSUNG *******************");
            Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(samsungClient.BuscarNormalModeloDetalhes());

            Console.ReadKey();
        }
    }
}
