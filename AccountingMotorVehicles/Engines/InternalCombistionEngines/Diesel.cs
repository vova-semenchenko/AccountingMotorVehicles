using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines.TypesInternalCombinationEngine
{
    [Serializable]
    public class Diesel : InternalCombistion
    {
        private double compressionRation;
        private string glowPlug;
        private int cetaneNumber;       

        public double CompressionRation { get => compressionRation; set => compressionRation = value; }
        public string GlowPlug { get => glowPlug; set => glowPlug = value; }
        public int CetaneNumber { get => cetaneNumber; set => cetaneNumber = value; }

        public override string ToString()
        {
            return base.ToString() + $" Коефіцієнт стиснення: {compressionRation} Свічка запалювання: {glowPlug} Цетанове число: {cetaneNumber}";
        }
    }
}
