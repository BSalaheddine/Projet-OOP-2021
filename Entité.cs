using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
     public class Entité
    {
        private float x;
        private float y;
        private float ZoneDeContact;

        public Entité(float x, float y, float ZoneDeContact = (float) 10.0)
        {
            this.x = x;
            this.y = y;
            this.ZoneDeContact = ZoneDeContact;
        }
        public (float, float) Position()
        {
            (float, float) a = (1, 5);
            a.Item1 = 2;
            return a;
        }
    }
}
