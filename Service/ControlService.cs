using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ControlService
    {
        public List<IActuator> Actuators;
        public List<Stage> Program;

        public async Task RunAsync()
        {
            var tasks = new List<Task>(Actuators.Count);
            foreach (var stage in Program)
            {
                tasks.Clear();
                foreach (var actuator in Actuators)
                {
                    foreach (var state in stage)
                    {
                        if (actuator.Type == state.ActuatorType)
                            tasks.Add(actuator.ChangeStateAsync(state));
                    }
                }
                await Task.WhenAll(tasks);
            }
        }
    }
}
