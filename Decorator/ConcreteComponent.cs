﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Component";
        }
    }
}
