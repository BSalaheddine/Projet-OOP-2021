using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Animal : FormeDeVie
    {
        public Animal(int PointsDeVie, int ReserveEnergie, float x, float y) :
            base(PointsDeVie, ReserveEnergie, x, y)
        { 
        }
    }
}
