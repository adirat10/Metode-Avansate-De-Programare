using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baze_OOP
{
    // Generice
    internal class Zoo
    {
        public List<Habitat<Animal>> habitate;
        public Zoo()
        {
            habitate = new List<Habitat<Animal>>();
        }
    }
}
