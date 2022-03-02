using AbstractFactory.Class;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    class Program
    {
        //İlişkili sınıfların oluşturulmasında kullanılır. Farklı ürünlerin fabrikalarının soyutlanması olarak tanımlanabilir. Tekrar eden if else yapısından kurtarır.
        static void Main(string[] args)
        {
            ITeam besiktas = TeamFactory.GetTeam(new BesiktasFactory());
            Console.WriteLine("Beşiktaşın Stadı : {0}\nrenkleri : {1}",besiktas.getStadium(),besiktas.getTeamColor());
        }
    }
}
