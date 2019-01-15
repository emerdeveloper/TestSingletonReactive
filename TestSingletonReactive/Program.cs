using System;

namespace TestSingletonReactive
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
             * First case "Reactive"
             **/
             Singleton.Instance.PropertyChanged += Instance_PropertyChanged;

            Console.WriteLine("Init::::::::::::::");
            System.Threading.Thread.Sleep(5000);
            Singleton.Instance.Name = "Emerson";
            Console.WriteLine("Finish thread sleep");
            Console.WriteLine("Finish::::::::::::::");

            //Second case "Secuencialy"
            /*Console.WriteLine("Init::::::::::::::");
            Singleton.Instance.Name = "Emerson";
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Finish thread sleep");
            Console.WriteLine("Name" + " : " + Singleton.Instance.Name);
            Console.WriteLine("Finish::::::::::::::");*/
        }

        static void Instance_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName +" : "+ Singleton.Instance.Name);
        }

    }
}
