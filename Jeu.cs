using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_OOP_2021
{
    class Jeu
    {
        private List<Entité> game = new List<Entité>();
        /*private List<Carnivore> carniList = new List<Carnivore>();
        private List<Herbivore> herbiList = new List<Herbivore>();
        private List<Nourriture> nourriList = new List<Nourriture>();
        private List<Plante> planteList = new List<Plante>();*/
        public Jeu(int carni = 5, int herbi = 5, int nouri = 5, int plante = 5)
        {
            /*game.Add(carniList);
            game.Add(herbiList);
            game.Add(nourriList);
            game.Add(planteList);*/
            var rand = new Random();
            for(int i = 0; i < carni; i++)
            {
                game.Add(new Carnivore((float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), i % 2 == 0));
            }
            for (int i = 0; i < herbi; i++)
            {
                game.Add(new Herbivore((float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), i % 2 == 0));
            }
            for (int i = 0; i < nouri; i++)
            {
                game.Add(new Nourriture((float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), 10));
            }
            for (int i = 0; i < plante; i++)
            {
                game.Add(new Plante((float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10)));
            }
        }
        public List<Entité> getGame() { return game; }
        public void startGame()
        {
            DateTime now = DateTime.Now;
            foreach (Entité i in game)
            {
                for(int j = game.IndexOf(i); j < game.Count(); j++)
                {
                    float distance = (float)Math.Sqrt((Math.Pow(i.getX() - game[j].getX(), 2) + Math.Pow(i.getY() - game[j].getY(), 2)));
                    if (distance < (float)(i.getZ() + game[j].getZ()))
                    {
                        if (i.Interaction(game[j]) == 1)
                        {
                            game.Remove(game[j]);
                        }
                        else if (i.Interaction(game[j]) == 2)
                        {
                            game.Add(new Carnivore((float) game[j].getX(), (float)game[j].getY(), now.Second > 30));
                        }
                        else if (i.Interaction(game[j]) == -10)
                        {
                            FormeDeVie g = (FormeDeVie) game[j];
                            g.Degats();
                        }
                        else if (i.Interaction(game[j]) == 3)
                        {
                            game.Add(new Herbivore((float)game[j].getX(), (float)game[j].getY(), now.Second > 30));
                        }
                        else if (i.Interaction(game[j]) == 4)
                        {
                            game.Add(new Plante((float)game[j].getX() + 2, (float)game[j].getY() + 2));
                        }

                    }
                }
            }
        }
    }
}