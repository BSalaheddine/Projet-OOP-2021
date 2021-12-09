using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    class Nourriture : Entité
    {
        private int Fraicheur;
        public Nourriture(float x, float y, float ZoneDeContact, int Fraicheur) :
            base(x, y, ZoneDeContact)
        {
            this.Fraicheur = Fraicheur;
        }
        public bool ViandeOuDechetOrganique()
        {
            if (Fraicheur >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
