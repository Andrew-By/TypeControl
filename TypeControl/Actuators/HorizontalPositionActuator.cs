using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Enums;

namespace TypeControl.Actuators
{
    public class HorizontalPositionActuator : ActuatorBase<HorizontalPosition>
    {
        public override int Priority => 1;

        private HorizontalPosition _state;
        public override HorizontalPosition State => _state;

        public override async Task ChangeStateAsync(HorizontalPosition position)
        {
            Console.WriteLine($"Moving to horizontal position {position.ToString()}...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            _state = position;
            Console.WriteLine($"Got into horizontal position {position.ToString()}");
        }
    }
}
