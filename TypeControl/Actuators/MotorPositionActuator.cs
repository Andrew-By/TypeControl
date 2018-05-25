using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Models;

namespace TypeControl.Actuators
{
    public class MotorPositionActuator : ActuatorBase<int>
    {
        public override int Priority => 1;

        private int _state;
        public override int State => _state;

        public override async Task ChangeStateAsync(int state)
        {
            Console.WriteLine($"Едем в положение {state}...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            _state = state;
            Console.WriteLine($"Приехали в положение {state}...");
        }
    }
}
