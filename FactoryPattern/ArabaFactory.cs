using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class ArabaFactory
    {
        internal static ArabaMarkasi factoryMethod(Markalar arabaMarkasi)
        {
            ArabaMarkasi araba = null;
            switch (arabaMarkasi)
            {
                case Markalar.BMW:
                    araba = new Bmw();
                    break;
                case Markalar.MERCEDES:
                    araba = new Mercedes();
                    break;
                default:
                    break;
            }

            return araba;
        }
    }
}
