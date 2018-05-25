using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeControl.Enums;
using TypeControl.States;

namespace TypeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new ControlService();
            Console.WriteLine("Registered actuators:");
            foreach (var actuator in cs.Actuators)
                Console.WriteLine(actuator);
            cs.Program = new List<Stage>
            {
                new Stage
                {
                    new HorizontalPositionState(HorizontalPosition.Left),
                    new VerticalPositionState(VerticalPosition.Top)
                },
                new Stage
                {
                    new VerticalPositionState(VerticalPosition.Bottom)
                },
                new Stage
                {
                    new HorizontalPositionState(HorizontalPosition.Center),
                    new VerticalPositionState(VerticalPosition.Top)
                }
            };
            cs.RunAsync().GetAwaiter().GetResult();
        }
    }
}
