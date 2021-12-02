using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Animal : FormeDeVie
    {
        public Animal(int PointsDeVie, int ReserveEnergie, (float, float) coord) :
            base(PointsDeVie, ReserveEnergie, coord)
        { 
        }
    }
}
