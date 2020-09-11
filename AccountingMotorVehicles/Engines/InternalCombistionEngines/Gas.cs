using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines.TypesInternalCombinationEngine
{
    [Serializable]
    public class Gas : Benzine
    {
        private int gasTankVolume;
        private string fuelSwitch;
        private string evaporatorGear;
        private string gasValve;
        private string gasMixer;
        private string multivave;

        public int GasTankVolume { get => gasTankVolume; set => gasTankVolume = value; } // объем газового бака
        public string FuelSwitch { get => fuelSwitch; set => fuelSwitch = value; } // топлевный переключатель
        public string EvaporatorGear { get => evaporatorGear; set => evaporatorGear = value; } // редуктор-исправитель
        public string GasValve { get => gasValve; set => gasValve = value; } // газовый клапан  
        public string GasMixer { get => gasMixer; set => gasMixer = value; } // смеситель газа 
        public string Multivave { get => multivave; set => multivave = value; } // мультиклапан
       
        public override string ToString()
        {
            return base.ToString() + $" Об'єм газ. бака: {gasTankVolume} Палевний перемикач: {fuelSwitch} Редуктор-виправник: {evaporatorGear} " +
                $"Газовий клапан: {gasValve} Змішувач газу: {gasMixer} Мультиклапан: {multivave}";
        }
    }
}
