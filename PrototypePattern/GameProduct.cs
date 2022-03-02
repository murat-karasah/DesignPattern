﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class GameProduct : Game
    {
        public override Game Clone()
        {
            return (Game) this.MemberwiseClone();
        }
    }
}
