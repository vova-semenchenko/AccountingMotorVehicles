using AccountingMotorVehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines
{
    [Serializable]
    public class Hybrid : IEngine
    {
        private string engineBrand;
        private string engineModel;
        private int power;
        private int torque;
        private int weight;
        private string engineConnectionDiagram;
        private InternalCombistion internalCombEngine;
        private Electro electroEngine;

        private string EngineСonnectionDiagram { get => engineConnectionDiagram; set => engineConnectionDiagram = value; } // тип соединения двигателей        
        
        public string EngineBrand { get => engineBrand; set => engineBrand = value; }
        public string EngineModel { get => engineModel; set => engineModel = value; }
        public int Power { get => power; set => power = value; } // общая мощность двигателей
        public int Torque { get => torque; set => torque = value; } // общий крутящий момент   
        public int Weight { get => weight; set => weight = value; } // общая масса двигателя
       
        public InternalCombistion InternalCombEngine { get => internalCombEngine; set => internalCombEngine = value; }
        public Electro ElectroEngine { get => electroEngine; set => electroEngine = value; }

        public Hybrid() { }
        public Hybrid(InternalCombistion internalCombEngine, Electro electroEngine)
        {
            this.internalCombEngine = internalCombEngine;
            this.electroEngine = electroEngine;
            engineBrand = this.internalCombEngine.EngineBrand + "/" + this.electroEngine.EngineBrand;
            power = this.internalCombEngine.Power + this.electroEngine.Power;
            torque = this.internalCombEngine.Torque + this.electroEngine.Torque;
            weight = this.internalCombEngine.Weight + this.electroEngine.Weight;
        }

        public override string ToString()
        {
            return $" ДВС: {internalCombEngine} | Електро: {electroEngine} Тип зэднання: {engineConnectionDiagram} ";
        }
    }
}
