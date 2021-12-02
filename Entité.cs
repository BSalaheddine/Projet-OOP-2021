using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
     public class Entité
    {
        private (float, float) coord;

        public Entité((float, float) coord)
        {
            this.coord = coord;
        }
    }
}
