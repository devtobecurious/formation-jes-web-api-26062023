﻿namespace SdA.Games.Core.Models
{
    public interface IMoyenDeDeplacement
    {
        void SeDeplacer();

        void Arreter()
        {
            Console.WriteLine("Comportement par defaut");
        }
    }
}
