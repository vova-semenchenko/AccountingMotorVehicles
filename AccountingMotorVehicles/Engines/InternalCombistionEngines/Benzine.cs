using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines.TypesInternalCombinationEngine
{
    [Serializable]
    public class Benzine : InternalCombistion
    {
        private double octaneValue;
        private string sparkPlug;       

        public double OcataneValue { get => octaneValue; set => octaneValue = value; }
        public string SparkLug { get => sparkPlug; set => sparkPlug = value; }        

        public override string ToString()
        {
            return base.ToString() + $" Октанове число: {octaneValue} Свічка запалювання: {sparkPlug} ";
        }
    }
}
