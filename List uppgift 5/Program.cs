using System;
using System.Collections.Generic;
using System.Net.Mime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in dina senaste månadslöner, avsluta med 0");

        List<int> löner = new List<int>();

        int lön = -1;
        while (lön != 0)
        {
            Console.WriteLine("Skriv in en lön");
            lön = int.Parse(Console.ReadLine());
            if (lön != 0)
            {
                löner.Add(lön);
            }
        }

        löner.Sort();

        double median = 0;
        if (löner.Count % 2 == 1)
        {
            median = löner[löner.Count / 2];
        }
        else
        {
            median = (löner[(löner.Count / 2) - 1] + löner[löner.Count / 2]) / 2.0;
        }

        int sum = 0;

        foreach (int item in löner)
        {
            sum += item;
        }

        double medel = sum / (double)löner.Count;

        Console.WriteLine($"Medellön: {medel} kr");
        Console.WriteLine($"Medianlön: {median} kr");
    }
}