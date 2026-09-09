using System;

namespace DPM235490_NguyenBaoTrong_AbstractPattern
{
    // Each Concrete Factory has a corresponding product variant.
    public class ConcreteFactory2 : IDPM235490_NguyenBaoTrong_GreationalDesignPatterns
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
