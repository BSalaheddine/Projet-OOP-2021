using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Animal : FormeDeVie
    {
        private bool Sexe;
        private float ZoneDeVision;
        public Animal(int PointsDeVie, int ReserveEnergie, float x, float y, float ZoneDeContact, bool Sexe, float ZoneDeVision) :
            base(PointsDeVie, ReserveEnergie, x, y, ZoneDeContact)
        { 
            this.Sexe = Sexe;
            this.ZoneDeVision = ZoneDeVision;
        }
        public void Defequer()
        {
            
        }
        public void Attaquer()
        {

        }
        public void SeDeplacer()
        {

        }
    }
}
