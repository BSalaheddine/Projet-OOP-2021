using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Herbivore : Animal
    {
        public Herbivore(float x, float y, bool Genre) :
            base(x, y, Genre)
        {

        }
        public override int Interaction(Entité victime)
        {
            try
            {
                Plante v1 = (Plante)victime;
                SeNourrir(v1);
            }
            catch
            {
            }
            try
            {
                Herbivore v = (Herbivore)victime;
                if (v.getGenre() == false)
                {
                    SeReproduire();
                }
            }
            catch
            {
            }
            return 0;
        }
        public override int SeNourrir(Entité victime)
        {
            return 1;
        }
        public override int SeReproduire()
        {
            return 3;
        }
        public override int Mourir()
        {
            return 1;
        }
    }
}
