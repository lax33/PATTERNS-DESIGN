using System;

namespace FactoryMethod
{
    // Фабричный метод — это порождающий паттерн
    //проектирования, который определяет общий интерфейс для
    //создания объектов в суперклассе, позволяя подклассам
    //изменять тип создаваемых объектов.
    internal class ProgramFM
    {
        static void Main(string[] args)
        {
            new Client().Main();

            Console.ReadKey();
        }
    }
}
