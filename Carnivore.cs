﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Carnivore : Animal
    {
        public Carnivore(int PointsDeVie, int ReserveEnergie, float x, float y, float ZoneDeContact, bool Sexe, float ZoneDeVision) :
            base(PointsDeVie, ReserveEnergie, x, y, ZoneDeContact, Sexe, ZoneDeVision)
        {

        }
    }
}
