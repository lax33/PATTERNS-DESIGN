namespace AbstractFactory
{
    public interface IAbstractProductB
    {
        // Продукт B способен работать самостоятельно...
        string UsefulFunctionB();
        
    }

    internal class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }

    internal class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}