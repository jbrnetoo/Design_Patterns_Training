using System;
using System.Threading;

namespace Design_Patterns_Training.Singleton
{
    public static class Singleton_Pattern
    {
        public static void Run()
        {
            Thread t1 = new Thread(() => 
            { 
                var instance = UploadService.GetInstance("Instance One");
                Console.WriteLine(instance.Message);
            });

            Thread t2 = new Thread(() =>
            {
                var instance = UploadService.GetInstance("Instance Two");
                Console.WriteLine(instance.Message);
            });

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.ReadKey();
        }
    }
}
