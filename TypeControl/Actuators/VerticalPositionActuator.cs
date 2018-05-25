using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Enums;

namespace TypeControl.Actuators
{
    public class VerticalPositionActuator : ActuatorBase<VerticalPosition>
    {
        public override int Priority => 2;

        private VerticalPosition _state;
        public override VerticalPosition State => _state;

        public override async Task ChangeStateAsync(VerticalPosition position)
        {
            Console.WriteLine($"Moving to vertical position {position.ToString()}...");
            await Task.Delay(TimeSpan.FromSeconds(3));
            _state = position;
            Console.WriteLine($"Got into vertical position {position.ToString()}");
        }
    }
}
