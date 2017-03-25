using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.model
{
    public class ClothingSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Garment> Garments { get; set; }
    }
}
