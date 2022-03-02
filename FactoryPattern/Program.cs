using FactoryPattern.Ayakkabı.Interface;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ArabaMarkasi araba = ArabaFactory.factoryMethod(Markalar.BMW);
            var mecedes = ArabaFactory.factoryMethod(Markalar.MERCEDES);
            Console.WriteLine(araba);
            Console.WriteLine(mecedes);

            // ArabaMarkasi araba = ArabaFactory.
            var shoeFactory = new ShoeFactory();
            Ishoe Bot = shoeFactory.ProduceShoe(ShoeType.Bot);
            Ishoe cizme = shoeFactory.ProduceShoe(ShoeType.Cizme);
            Ishoe Sneakers = shoeFactory.ProduceShoe(ShoeType.Sneakers);
            Console.ReadLine();
        }
    }
}
