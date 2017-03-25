using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public float Size { get; set; } //in centimeters
        public DateTime BirthDate { get; set; }
    }
}
