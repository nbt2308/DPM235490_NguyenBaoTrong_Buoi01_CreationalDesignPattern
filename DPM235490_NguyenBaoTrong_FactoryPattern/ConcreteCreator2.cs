using System;

namespace DPM235490_NguyenBaoTrong_FactoryPattern
{
    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
