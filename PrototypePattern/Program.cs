using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    class Program
    { //bir objenin özelliklerine sahip olan aynı tipte bir obje yaratmak istiyorsak kullanırız. Yeni clonelanacak nesne orjinal nesnenin özelliklerini etkilemez.
        static void Main(string[] args)
        {
            var dailymeetingmorning = new DailyMeeting() { 
            StarTime=Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 08:00")),
            EndTime=Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 08:15")),
            Location="Balat-302",
            Materials=new List<string>
            {
                "projeksiyon cihazı","laptop","notepad"
            },
            Participants= new List<string>
            {
                    "Eda","Leyla","Sinem","Mehmet"
            },
            Summary="Toplantıda alınan kararlar..."
            
            };

            var dailymeetingmoon = dailymeetingmorning.Clone();
            dailymeetingmoon.StarTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 12:00"));

            dailymeetingmoon.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 12:15"));
            var dailymeetingNight = dailymeetingmorning.Clone();
            dailymeetingNight.StarTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 20:00"));

            dailymeetingNight.EndTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy.MM.dd 20:15"));

            Console.WriteLine(string.Format("Sabah oturumu :{0}-{1}", dailymeetingmorning.StarTime, dailymeetingmorning.EndTime));
            Console.WriteLine(string.Format("Öğlen oturumu :{0}-{1}", dailymeetingmoon.StarTime, dailymeetingmoon.EndTime));
            Console.WriteLine(string.Format("Akşam oturumu :{0}-{1}", dailymeetingNight.StarTime, dailymeetingNight.EndTime));

            Console.WriteLine("################################");
            var myFirstGame = new GameProduct()
            {
                GameName = "WoW",
                Category = "MMORPG",
                Material = new List<string>
                {
                    "DvD", "Digital"
                },
                PlayerTypes = new List<string>
                { "Multi player" },
                Format = "PC",
                Age = "+13"
            };
            var mySecondGame = myFirstGame.Clone();
            mySecondGame.GameName = "Monopoly";
            mySecondGame.Category = "Finance";
            mySecondGame.Age ="+7";
            mySecondGame.Format = "Box-Table Game";
            mySecondGame.PlayerTypes = new List<string> { "Multi Player" };
            mySecondGame.Material = new List<string> { "Map", "Money", "Pin" };

            Console.WriteLine(string.Format("########\n#Oyun Adı : {0}\n#Kategori : {1} \n#Yaş Sınırı : {2} \n#Format : {3} \n#Material : ", myFirstGame.GameName, myFirstGame.Category, myFirstGame.Age, myFirstGame.Format));
           
            foreach (var item in myFirstGame.Material)
            {
                Console.WriteLine("     >" + item);
            }
            Console.WriteLine("#Oyuncu Tipi");
            foreach (var item in myFirstGame.PlayerTypes)
            {
                Console.WriteLine("     >" + item);
            }



            Console.WriteLine(string.Format("########\n#Oyun Adı : {0}\n#Kategori : {1} \n#Yaş Sınırı : {2} \n#Format : {3} \n#Material : ", mySecondGame.GameName,mySecondGame.Category,mySecondGame.Age,mySecondGame.Format));

            foreach (var item in mySecondGame.Material)
            {
                Console.WriteLine("     >"+item);
            }

            Console.WriteLine("#Oyuncu Tipi :");
            foreach (var item in mySecondGame.PlayerTypes)
            {
                Console.WriteLine("     >" + item);
            }



        }
    }
}
