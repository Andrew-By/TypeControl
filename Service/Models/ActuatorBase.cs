using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public abstract class ActuatorBase<T> : IActuator
    {
        public abstract int Priority { get; }
        public abstract T State { get; }
        public abstract Task ChangeStateAsync(T state);
        public Type Type => GetType();

        public Task ChangeStateAsync(IState state)
        {
            if (state.ActuatorType == Type)
            {
                var newState = (T)state.State;
                return ChangeStateAsync(newState);
            }
            return Task.CompletedTask;
        }
    }
}
