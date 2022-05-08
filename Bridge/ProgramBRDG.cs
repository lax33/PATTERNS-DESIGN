using System;

namespace Bridge
{
    internal class ProgramBRDG
    {
        //Мост — это структурный паттерн проектирования, который
        //разделяет один или несколько классов на две отдельные
        //иерархии — абстракцию и реализацию, позволяя изменять
        //их независимо друг от друга.
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            // Клиентский код должен работать с любой предварительно
            // сконфигурированной комбинацией абстракции и реализации.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
