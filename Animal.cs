using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public abstract class Animal : FormeDeVie
    {
        private bool Genre;
        private float ZoneDeVision = 20;
        public Animal(float x, float y, bool Genre) :
            base(x, y)
        { 
            this.Genre = Genre;
        }
        public bool getGenre() { return Genre; }
        public float getZoneDeVision() { return ZoneDeVision; }
        public int Defequer()
        {
            Console.WriteLine(this + "a defequé");
            return 2;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), l'Animal {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
        public override int Actualisation()
        {
            return Defequer();
        }
    }
}
