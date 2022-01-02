﻿using System;
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
                    if (distance <= (float)(i.getZoneDeContact() + game[j].getZoneDeContact()))
                    {
                        if (i.Interaction(game[j]) == 1)
                        {
                            FormeDeVie g = (FormeDeVie)game[j];
                            g.Guerison();
                            game.Remove(game[j]);
                        }
                        else if (i.Interaction(game[j]) == 2)
                        {
                            game.Add(new Carnivore((float)game[j].getX(), (float)game[j].getY(), now.Second > 30));
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
            foreach(Entité i in game)
            {
                try
                {
                    Animal ii = (Animal)i;
                    for (int j = game.IndexOf(i); j < game.Count(); j++)
                    {
                        float distance = (float)Math.Sqrt((Math.Pow(i.getX() - game[j].getX(), 2) + Math.Pow(i.getY() - game[j].getY(), 2)));
                        float m = (game[j].getY() - i.getY())/ (game[j].getX() - i.getX());
                        float a = (float)Math.Sqrt(1/(Math.Pow(m, 2) + 1));
                        if (distance <= ii.getZoneDeVision())
                        {
                            ii.SeDeplacer(a ,a*m);
                        }
                    }
                }
                catch
                {
                }
                try
                {
                    Plante ii = (Plante)i;
                    for (int j = game.IndexOf(i); j < game.Count(); j++)
                    {
                        try
                        {
                            Nourriture n = (Nourriture)game[j];
                            float distance = (float)Math.Sqrt((Math.Pow(i.getX() - game[j].getX(), 2) + Math.Pow(i.getY() - game[j].getY(), 2)));
                            if (distance <= ii.getZoneDeRacine())
                            {
                                game.Remove(game[j]);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
            }
        }
    }
}