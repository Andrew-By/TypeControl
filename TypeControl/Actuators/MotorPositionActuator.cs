using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TypeControl.Actuators
{
    public class MotorPositionActuator : ActuatorBase<int>
    {
        public override int Priority => 1;

        private int _state;
        public override int State => _state;

        public override async Task ChangeStateAsync(int state)
        {
            Console.WriteLine($"Moving to position {state}...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            _state = state;
            Console.WriteLine($"Got to position {state}");
        }
    }
}
