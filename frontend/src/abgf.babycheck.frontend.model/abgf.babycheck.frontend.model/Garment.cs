using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.model
{
    public class Garment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Size { get; set; } // in centimeters
        public int DestinationAge { get; set; } //in Months
        public string Colour { get; set; }
        
        public int IdGarmentType { get; set; }
        public GarmentType GarmentType { get; set; }

        public int IdContainer { get; set; }
        public Container Container { get; set; }

        public int IdClothesSet { get; set; }
        public ClothesSet ClothesSet { get; set; }
    }
}
