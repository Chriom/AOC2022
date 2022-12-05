﻿using AdventOfCode2022.Helpers;
using AdventOfCode2022.Interfaces;
using AdventOfCode2022.Metier.Jours;

internal class Program
{
    private static void Main(string[] pArgs)
    {
        IJour lJour = new Jour05();

        
        string lResultatUn = lJour.DonneResultatUn();
        Console.WriteLine($"Numero 1 : {lResultatUn}");


        lJour = new Jour05();

        string lResultatDeux = lJour.DonneResultatDeux();
        Console.WriteLine($"Numero 2 : {lResultatDeux}");

        Console.Read();
    }
}