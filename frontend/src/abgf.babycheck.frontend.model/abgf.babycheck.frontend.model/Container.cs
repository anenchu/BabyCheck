using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.model
{
    public class Container
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int IdRoom { get; set; }
        public Room Room { get; set; }

        public List<Garment> Garments { get; set; }
    }
}
