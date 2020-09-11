using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Interfaces
{
    public interface IEngine
    {
        string EngineBrand { get; }
        string EngineModel { get; }
        int Power { get; }
        int Torque { get; }
        int Weight { get; }
    }
}
