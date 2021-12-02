﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class FormeDeVie : Entité
    {
        private int PointsDeVie;
        private int ReserveEnergie;
        public FormeDeVie(int PointsDeVie, int ReserveEnergie, (float, float) coord) :
            base(coord)
        {
            this.PointsDeVie = PointsDeVie;
            this.ReserveEnergie = ReserveEnergie;
        }
    }
}