using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Mercedes : ArabaMarkasi
    {
        public override void MarkaAdi()
        {
            Console.WriteLine("Arabanın markası MERCEDES");
        }

        public override string ToString()
        {
            return "Arabanın markası MERCEDES";
        }
    }
}