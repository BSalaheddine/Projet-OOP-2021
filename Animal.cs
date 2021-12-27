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
        public int Defequer()
        {
            return 2;
        }
        public int SeDeplacer()
        {
            return 1; 
        }
    }
}
