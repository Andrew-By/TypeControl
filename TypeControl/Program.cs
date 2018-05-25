using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Models;
using TypeControl.States;

namespace TypeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new ControlService();
            cs.Program = new List<Stage>
            {
                new Stage
                {
                    new MotorPositionState(0)
                },
                new Stage
                {
                    new MotorPositionState(100)
                },
                new Stage
                {
                    new MotorPositionState(10)
                }
            };
            cs.RunAsync().GetAwaiter().GetResult();
        }
    }
}
