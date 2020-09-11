using AccountingMotorVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AccountingMotorVehicles.Vehicles
{
    [Serializable]
    public class Car : IVehicle
    {
        private string brand;
        private string model;
        private IEngine engine;
        private string transmission;
        private string driveType;
        private double weight;
        private int seats;        
        private Dimensions vehicleDimensions;
        private int fuelTankVolume;
        private string carBodyType;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public IEngine Engine { get => engine; set => engine = value; }
        public string Transmission { get => transmission; set => transmission = value; }
        public string DriveType { get => driveType; set => driveType = value; }
        public double Weight { get => weight; set => weight = value; }        
        public int Seats { get => seats; set => seats = value; }
        public Dimensions VehicleDimensions { get => vehicleDimensions; set => vehicleDimensions = value; }
        public int FuelTankVolume { get => fuelTankVolume; set => fuelTankVolume = value; }
        public string CarBodyType { get => carBodyType; set => carBodyType = value; }       

        public override string ToString()
        {
            return $"Бренд: {Brand} Модель: {Model} Двигун: {Engine} Коробка передач: {Transmission} Привод: {DriveType} Маса: {Weight} Місця: {Seats} Габаритні розміри: {VehicleDimensions}" +
                $" Об'єм баку: {FuelTankVolume} Тип кузова: {CarBodyType}";
        }
    }
}
