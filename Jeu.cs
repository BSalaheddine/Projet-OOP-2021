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
        public Jeu(int carni = 5, int herbi = 5, int nouri = 5, int plante = 5)
        {
            var rand = new Random();
            for(int i = 0; i < carni; i++)
            {
                game.Add(new Carnivore(rand.Next(10, 20), rand.Next(10, 20), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), 10, i % 2 == 0, 5));
            }
            for (int i = 0; i < herbi; i++)
            {
                game.Add(new Herbivore(rand.Next(10, 20), rand.Next(10, 20), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), 10, i % 2 == 0, 5));
            }
            for (int i = 0; i < nouri; i++)
            {
                game.Add(new Nourriture((float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), 10, 5));
            }
            for (int i = 0; i < plante; i++)
            {
                game.Add(new Plante(rand.Next(10, 20), rand.Next(10, 20), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10), (float)(rand.NextDouble() * 10)));
            }
        }
        public void startGame()
        {
            foreach(Entité i in game)
            {
                int n = game.IndexOf(i);
                int t = game.Count() - n;
                for(int j = 0; j < t; j++)
                {
                    //algo qui fait les contacts etc..
                }
            }
        }
    }
}