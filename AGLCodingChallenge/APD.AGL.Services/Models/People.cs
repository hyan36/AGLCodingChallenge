using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APD.AGL.Services.Models
{
    public class People
    {
        public String Name { get; set; }

        public String Gender { get; set; }

        public int Age { get; set; }

        public List<Pet> Pets { get; set; }
    }
}
