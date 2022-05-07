using System;

namespace Adapter
{
    //Адаптер — это структурный паттерн проектирования,
    //который позволяет объектам с несовместимыми
    //интерфейсами работать вместе.
    //преобразует интерфейс одного класса в интерфейс другого, который
    //ожидают клиенты.Адаптер делает возможной совместную работу классов с несовместимыми интерфейсами.
    internal class ProgramADPTR
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());

            Console.ReadLine();
        }
    }
}
