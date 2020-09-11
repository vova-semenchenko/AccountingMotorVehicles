using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Engines
{
    public enum EngineTypes
    {
        ELECTRO,
        HYBRID,
        BENZINE,
        DIESEL,
        GAS
    }

    public class EngineTypesConverter
    {               
        public string ConvertTo(string type) => 
            (EngineTypes)Enum.Parse(typeof(EngineTypes), type.ToUpper()) switch
        {
            EngineTypes.BENZINE => "Бензин",
            EngineTypes.DIESEL => "Дизель",
            EngineTypes.GAS => "Газ",
            EngineTypes.ELECTRO => "Електро",
            EngineTypes.HYBRID => "Гібрид",
            _ => ""
        };
    }
}
