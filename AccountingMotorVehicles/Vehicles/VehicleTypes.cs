using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Vehicles
{
    public enum VehicleTypes
    {
        CAR,
        BUS,
        TRUCK
    }

    public class VehicleTypesConverter
    {
        public string ConvertTo(string type) => 
            (VehicleTypes)Enum.Parse(typeof(VehicleTypes), type.ToUpper()) switch
        {
            VehicleTypes.CAR => "Автомобіль",
            VehicleTypes.BUS => "Автобус",
            VehicleTypes.TRUCK => "Вантажный автомобіль",
            _ => ""
        };

        public VehicleTypes ConvertFrom(string type) => type switch
        {
            "Автомобіль" => VehicleTypes.CAR,
            "Автобус" => VehicleTypes.BUS,
            "Вантажный автомобіль" => VehicleTypes.TRUCK,
            _ => 0
        };
    }
}
