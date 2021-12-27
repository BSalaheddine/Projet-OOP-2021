using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    class Plante : FormeDeVie
    {
        private float ZoneDeSemis = 10;
        private float ZoneDeRacine = 10;
        public Plante(float x, float y) :
            base(x, y)
        {

        }
        public override int Mourir()
        {
            return 1;
        }
        public override int Interaction(Entité victime)
        {
            return 0;
        }
        public override int SeReproduire()
        {
            return 4;
        }
        public override int SeNourrir(Entité victime)
        {
            return 1;
        }
    }
}
