using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Actuators;
using TypeControl.Enums;

namespace TypeControl.States
{
    public class VerticalPositionState : StateBase<VerticalPositionActuator, VerticalPosition>
    {
        public VerticalPositionState(VerticalPosition state) : base(state) { }
    }
}
