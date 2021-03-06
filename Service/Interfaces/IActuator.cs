﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IActuator
    {
        int Priority { get; }
        Type Type { get; }
        Task ChangeStateAsync(IState state);
    }
}
