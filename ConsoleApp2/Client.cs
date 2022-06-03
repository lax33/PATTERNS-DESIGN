using System;

namespace AbstractFactory
{
    public class Client
    {

        //-------------Продукты фабрики 1---------------------------
        public string Prod_A1()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            return ClientMethod_A(new ConcreteFactory1());

            Console.WriteLine();
        }
        public string Prod_B1()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            return ClientMethod_B(new ConcreteFactory1());

            Console.WriteLine();
        }

        //----------------------Продукты фабрики 2----------------------
        public string Prod_A2()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            //Console.WriteLine("Client: Testing client code with the first factory type...");

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            return ClientMethod_A(new ConcreteFactory2());
        }

        public string Prod_B2()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            //Console.WriteLine("Client: Testing client code with the first factory type...");

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            return ClientMethod_B(new ConcreteFactory2());
        }

        //--------------------------------------------------------------
        private string ClientMethod_A(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA().UsefulFunctionA();
            return productA;

            //Console.WriteLine(productB.UsefulFunctionB());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }

        private string ClientMethod_B(IAbstractFactory factory)
        {
            var productB = factory.CreateProductB().UsefulFunctionB();
            return productB;

            //Console.WriteLine(productB.UsefulFunctionB());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
