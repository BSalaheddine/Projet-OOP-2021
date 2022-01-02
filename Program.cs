using System;
using System.Collections.Generic;
using System.IO;

namespace Projet_OOP_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Jeu Game = new Jeu();
                Game.startGame();
            }
        }
    }
}
