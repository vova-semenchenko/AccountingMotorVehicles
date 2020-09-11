using AccountingMotorVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines
{
    [Serializable]
    public class Electro : IEngine
    {
        private string engineBrand;
        private string engineModel;
        private int power;
        private int torque;
        private int weight;
        private string electroEngineType;
        private int powerReserve;

        public string EngineBrand { get => engineBrand; set => engineBrand = value; }
        public string EngineModel { get => engineModel; set => engineModel = value; }
        public int Power { get => power; set => power = value; }
        public int Torque { get => torque; set => torque = value; }
        public int Weight { get => weight; set => weight = value; }
        
        public string ElectroEngineType { get => electroEngineType; set => electroEngineType = value; } // тип электродвигателя
        public int PowerReserve { get => powerReserve; set => powerReserve = value; } // запас хода        

        public override string ToString()
        {
            return $" Марка двигуна: {engineBrand} Модель: {engineModel} Потужність: {power} Крутний момент: {torque} Вага: {weight}" +
                $" Тип електро двигуна: {electroEngineType} Запас потужності: {powerReserve}";
        }
    }
}
