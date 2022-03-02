using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
   abstract class Game
    {
        public string GameName { get; set; }
        public string Category { get; set; }
        public List<string> Material { get; set; }
        public List<string> PlayerTypes { get; set; }
        public string Format { get; set; }
        public string Age { get; set; }
        public abstract Game Clone();
    }
}
