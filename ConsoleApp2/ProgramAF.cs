﻿using System;

namespace AbstractFactory
{
    //Абстрактная фабрика — это порождающий паттерн
    //    проектирования, который позволяет создавать семейства
    //связанных объектов, не привязываясь к конкретным
    //    классам создаваемых объектов.
    internal class ProgramAF
    {
        private static void Main(string[] args)
        {
            //new Client().Main();

            var client = new Client();
            var prodA1 = client.Prod_A1();
            var prodB2 = client.Prod_B2();


            Console.WriteLine(prodA1);
            Console.WriteLine(prodB2);
            Console.ReadKey();
        }
    }
}