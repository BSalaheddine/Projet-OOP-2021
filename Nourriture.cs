using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    public class Nourriture : Entité
    {
        private int Fraicheur;
        public Nourriture(float x, float y, int Fraicheur) :
            base(x, y)
        {
            this.Fraicheur = Fraicheur;
        }
        /*public bool ViandeOuDechetOrganique()
        {
            if (Fraicheur >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public override int Interaction(Entité victime)
        {
            return 0;
        }
        public int getFraicheur() { return Fraicheur; }
    }
}
