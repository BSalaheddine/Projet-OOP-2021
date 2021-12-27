using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
     public abstract class Entité
    {
        private float x;
        private float y;
        private float ZoneDeContact = 10;


        public Entité(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX() { return x; }
        public float getY() { return y; }
        public float getZ() { return ZoneDeContact; }
        public abstract int Interaction(Entité victime);
        //public abstract int Actualisation(Entité entity);
    }
}
