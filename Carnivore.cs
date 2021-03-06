using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Carnivore : Animal
    {
        public Carnivore(float x, float y, bool Genre) :
            base(x, y, Genre)
        {

        }
        public int Attaquer(Animal victime)
        {
            Console.WriteLine(this + "a attaqué");
            return -10;
        }
        public override int SeNourrir(Entité victime)
        {
            Nourriture v = (Nourriture)victime;
            if (v.getFraicheur() >= 0)
            {
                Console.WriteLine(this + "s\'est nourri");
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public override int Mourir()
        {
            Console.WriteLine(this + "est mort");
            return 1;
        }
        public override int SeReproduire()
        {
            Console.WriteLine(this + "s\'est reproduit");
            return 2;
        }
        public override int Interaction(Entité victime)
        {
            try
            {
                Nourriture v1 = (Nourriture)victime;
                return SeNourrir(v1);
            }
            catch
            {
            }
            try
            {
                Carnivore v2 = (Carnivore)victime;
                if(v2.getGenre() == false)
                {
                    return SeReproduire();
                }
                else if (v2.getGenre() == true)
                {
                    return Attaquer(v2);
                }
            }
            catch
            {
            }
            try
            {
                Animal v3 = (Animal)victime;
                if (v3.getGenre() == true )
                {
                    return SeReproduire ();
                }
            }
            catch
            {
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), le Carnivore {2} ",this.getX() ,this.getY() ,this.GetHashCode());
        }
    }
}
