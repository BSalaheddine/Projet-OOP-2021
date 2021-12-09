using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    class Plante : FormeDeVie
    {
        private float ZoneDeSemis;
        private float ZoneDeRacine;
        public Plante(int PointsDeVie, int ReserveEnergie, float x, float y, float ZoneDeContact, float ZoneDeSemis, float ZoneDeRacine) :
            base(PointsDeVie, ReserveEnergie, x, y, ZoneDeContact)
        {
            this.ZoneDeSemis = ZoneDeSemis;
            this.ZoneDeRacine = ZoneDeRacine;
            
        }
    }
}
