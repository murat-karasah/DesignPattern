using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Bmw : ArabaMarkasi
    {
        public override void MarkaAdi()
        {
            Console.WriteLine("Arabanın markası BMW");
        }

        public override string ToString()
        {
            return "Arabanın markası BMW";
        }
    }
}
