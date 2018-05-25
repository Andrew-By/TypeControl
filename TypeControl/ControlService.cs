using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeControl
{
    public class ControlService : Service.ControlService
    {
        public ControlService()
        {
            var actuators = new List<IActuator>
            {
                new Actuators.MotorPositionActuator()
            };
            Actuators = actuators.OrderBy(a => a.Priority).ToList();
        }
    }
}
