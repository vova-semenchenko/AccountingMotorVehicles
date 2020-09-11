using AccountingMotorVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Vehicles
{
    [Serializable]
    class Bus : IVehicle
    {
        private string brand;
        private string model;
        private IEngine engine;
        private string transmission;
        private string driveType;
        private double weight;
        private int seats;
        private int passengarsSeats;
        private Dimensions vehicleDimensions;
        private bool isLuggageCompartments;
        private int fuelTankVolume;
        private int doorCount;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public IEngine Engine { get => engine; set => engine = value; }
        public string Transmission { get => transmission; set => transmission = value; }
        public string DriveType { get => driveType; set => driveType = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Seats { get => seats; set => seats = value; }
        public int PassengarsSeats { get => passengarsSeats; set => passengarsSeats = value; }
        public Dimensions VehicleDimensions { get => vehicleDimensions; set => vehicleDimensions = value; }
        public bool IsLuggageCompartments { get => isLuggageCompartments; set => isLuggageCompartments = value; }
        public int FuelTankVolume { get => fuelTankVolume; set => fuelTankVolume = value; }
        public int DoorCount { get => doorCount; set => doorCount = value; }

        public override string ToString()
        {
            string lagguage = isLuggageCompartments ? "Присутній" : "Відсутній";
            return $"Бренд: {Brand} Модель: {Model} Двигун: {Engine} Коробка передач: {Transmission} Привод: {DriveType} Маса: {Weight} Місця: {Seats} Габаритні розміри: {VehicleDimensions}" +
                $" Об'єм баку: {FuelTankVolume} Трейлер: {lagguage} Місць для пасажирів: {passengarsSeats} Кількість дверей (для пасажирів) {doorCount}";
        }
    }
}
