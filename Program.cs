using System;
using System.Collections.Generic;
using System.IO;

namespace Projet_OOP_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu Game = new Jeu();
            Game.startGame();
            foreach(Object i in Game.getGame())
            {
                //Console.WriteLine((List<Carnivore>)i);
            }
            
        }
    }
}
