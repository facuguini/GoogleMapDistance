using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_TFI_FacundoGuini.Entities
{
    public class Vehicle
    {
        public string Name { get; set; }
        public Dimension Dimension { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
    }

    public class Dimension
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
    }
}