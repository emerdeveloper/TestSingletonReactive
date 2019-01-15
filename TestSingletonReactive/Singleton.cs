using System;
namespace TestSingletonReactive
{
    public class Singleton
    {
        private static Customer customer;
        public static Customer Instance
        {
            get
            {
                return customer ?? (customer = new Customer());
            }
            set
            {
                customer = value;
            }
        }
    }
}
