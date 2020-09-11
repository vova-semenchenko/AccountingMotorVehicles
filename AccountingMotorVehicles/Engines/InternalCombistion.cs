using AccountingMotorVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines
{    
    [Serializable]
    public class InternalCombistion : IEngine
    {
        private string engineBrand;
        private string engineModel;
        private int power;
        private int torque;
        private double engineVolume;        
        private double fuelConsumption;
        private int cylinderCount;
        private string cylinderArrangement;
        private double cylinderDiameter;
        private bool isCompresor;
        private int weight;
        private int valvesCount;
        private double pistonStroke;        

        public string EngineBrand { get => engineBrand; set => engineBrand = value; } // марка двигателя 
        public string EngineModel { get => engineModel; set => engineModel = value; } // марка двигателя 
        public int Power { get => power; set => power = value; } // мощность 
        public int Torque { get => torque; set => torque = value; } // крутящий момент
        public double EngineVolume { get => engineVolume; set => engineVolume = value; } // объем двигателя        
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; } // расход топлива 
        public int CylinderCount { get => cylinderCount; set => cylinderCount = value; } // количество цилиндров
        public string CylinderArrangement { get => cylinderArrangement; set => cylinderArrangement = value; } // расположение цилиндров
        public double CylinderDiameter { get => cylinderDiameter; set => cylinderDiameter = value; } // диаметр цилиндров
        public bool IsCompresor { get => isCompresor; set => isCompresor = value; } // есть ли компресор
        public int Weight { get => weight; set => weight = value; } // масса 
        public double PistonStroke { get => pistonStroke; set => pistonStroke = value; } // ход поршня
        public int ValvesCount { get => valvesCount; set => valvesCount = value; }

        public override string ToString()
        {
            string compresor = isCompresor ? "Присутній" : "Відсутній";
            return $" Марка двигуна: {engineBrand} Модель: {engineModel} Потужність: {power} Об'єм: {engineVolume} Витрати палива: {fuelConsumption} Кількість циліндрів: {cylinderCount}" +
                $"Розміщення циліндрів: {cylinderArrangement} Діаметр циліндрів: {cylinderDiameter} Компресор: {compresor} Вага: {weight} Хід поршня: {pistonStroke}  Кількість клапанів: {valvesCount}";
        }
    }
}
