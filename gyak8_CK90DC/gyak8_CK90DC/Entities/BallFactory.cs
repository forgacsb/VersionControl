﻿using gyak8_CK90DC.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8_CK90DC.Entities
{
    class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
