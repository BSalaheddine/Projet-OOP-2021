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
        public float getZoneDeSemis() { return ZoneDeSemis; }
        public float getZoneDeRacine() { return ZoneDeRacine; }
        public override int Mourir()
        {
            Console.WriteLine(this + "est morte");
            return 1;
        }
        public override int Interaction(Entité victime)
        {
            return 0;
        }
        public override int SeReproduire()
        {
            Console.WriteLine(this + "s\'est reproduit");
            return 4;
        }
        public override int SeNourrir(Entité victime)
        {
            Console.WriteLine(this + "s\'est nourrit");
            return 1;
        }
        public override void SeDeplacer(float x, float y)
        {

        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), la Plante {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
    }
}
