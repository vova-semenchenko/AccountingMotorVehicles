using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingMotorVehicles.Vehicles
{
    [Serializable]
    public class Dimensions
    {
        private int height;
        private int width;
        private int length;

        public Dimensions(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        public override string ToString()
        {
            return $"(Довжина: {length} Висота: {height} Ширина: {width})";
        }
    }
}
