using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Actuators;
using TypeControl.Models;

namespace TypeControl.States
{
    public class MotorPositionState : StateBase<MotorPositionActuator, int>
    {
        public MotorPositionState(int state) : base(state) { }
    }
}
