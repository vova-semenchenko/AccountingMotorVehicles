using AccountingMotorVehicles.Vehicles;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; }
        string Model { get;  }
        IEngine Engine { get; }
        string Transmission { get; }
        string DriveType { get; }
        double Weight { get; }
        int Seats { get; }
        Dimensions VehicleDimensions { get; }
        int FuelTankVolume { get; }
    }
}
