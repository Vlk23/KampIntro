﻿using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1987,
                FirstName = "Volkan",
                LastName = "Gunel",
                IdentityNumber = 12345
            });
            Console.WriteLine("Merhaba!");
        }
    }
}
