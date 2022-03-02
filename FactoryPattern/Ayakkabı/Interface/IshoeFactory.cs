using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern.Ayakkabı.Products;

namespace FactoryPattern.Ayakkabı.Interface
{
    public enum ShoeType
    {
        Bot = 0,
        Sneakers = 1,
        Cizme = 2,
    }
    public interface IshoeFactory
    {
        Ishoe ProduceShoe(ShoeType type);
    }

    public class ShoeFactory : IshoeFactory
    {
        public Ishoe ProduceShoe(ShoeType type)
        {
            switch (type)
            {
                case ShoeType.Bot:
                    return new Bot();
                case ShoeType.Sneakers:
                    return new Sneakers();
                case ShoeType.Cizme:
                    return new Cizme();
                default:
                    return new Bot();
            }
        }
    }
}
