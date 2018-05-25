using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Interfaces;

namespace TypeControl.Models
{
    public abstract class StateBase<TActuator, TState> : IState where TActuator : ActuatorBase<TState>
    {
        public StateBase(TState state)
        {
            ActuatorType = typeof(TActuator);
            State = state;
        }

        public Type ActuatorType { get; private set; }

        public object State { get; }
    }
}
