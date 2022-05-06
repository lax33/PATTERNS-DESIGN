namespace Builder
{
    public interface IBuilder
    {
        // Интерфейс Строителя объявляет создающие методы для различных частей
        // объектов Продуктов.
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}