using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public abstract class FormeDeVie : Entité
    {
        private int PointsDeVie = 50;
        private int ReserveEnergie = 50;
        public FormeDeVie(float x, float y) :
            base(x, y)
        {

        }
        public int getPV() { return PointsDeVie; }
        public int getNRJ() { return ReserveEnergie; }
        public abstract int SeNourrir(Entité victime);
        public abstract int SeReproduire();
        public abstract int Mourir();
        public void Degats()
        {
            PointsDeVie -= 10;
        }
        public void guerison()
        {
            PointsDeVie += 10;
        }
    }
}
