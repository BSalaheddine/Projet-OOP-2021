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
                return SeNourrir (v1);
            }
            catch
            {
            }
            try
            {
                Herbivore v = (Herbivore)victime;
                if (v.getGenre() == false)
                {
                    return SeReproduire ();
                }
            }
            catch
            {
            }
            return 0;
        }
        public override int SeNourrir(Entité victime)
        {
            Console.WriteLine(this + "s\'est nourri");
            return 1;
        }
        public override int SeReproduire()
        {
            Console.WriteLine(this + "s\'est reproduit");
            return 3;
        }
        public override int Mourir()
        {
            Console.WriteLine(this + "est mort");
            return 1;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), l'Herbivore {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
    }
}
