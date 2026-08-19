using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace day14
{
    internal class TruckCar : car
    {
        public TruckCar(string path, JsonSerializerOptions jsonOpt) : base(path, jsonOpt)
        {
        }
    }
}
