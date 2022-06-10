using System;

namespace Command
{
    internal class ProgramCommand
    {
        private static void Main(string[] args)
        {
            //https://refactoring.guru/ru/design-patterns/command/csharp/example
            //Команда — это поведенческий паттерн проектирования,
            //который превращает запросы в объекты, позволяя
            //передавать их как аргументы при вызове методов, ставить
            //запросы в очередь, логировать их, а также поддерживать
            //отмену операций.
            // Клиентский код может параметризовать отправителя любыми
            // командами.
            Invoker invoker = new Invoker();
            //invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();

            Console.ReadKey();
        }
    }
}