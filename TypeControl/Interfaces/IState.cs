﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeControl.Interfaces
{
    public interface IState
    {
        object State { get; }
        Type ActuatorType { get; }
    }
}
