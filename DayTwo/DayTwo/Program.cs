using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = File.ReadAllLines("C:\\repos\\AdventOfCode\\DayTwo\\Input-DayTwo.txt");

        int win = 6;
        int draw = 3;
        int lost = 0;

        int rock = 1;
        int paper = 2;
        int scissors = 3;

        int points = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string erste = input[i].Split(' ')[0];
            string zweite = input[i].Split(' ')[1];
            Console.WriteLine(erste + " / " + zweite);

            /* Erstes Beispiel
            switch (erste)
            {
                case "A":
                    Points(zweite, rock, paper, scissors, draw, win, lost, ref points);
                    break;
                case "B":
                    Points(zweite, rock, paper, scissors, lost, draw, win, ref points);
                    break;
                case "C":
                    Points(zweite, rock, paper, scissors, win, lost, draw, ref points);
                    break;
            }
            */

            // Zweites Beispiel
            switch (erste)
            {
                case "A":
                    Points(zweite, scissors, rock, paper, lost, draw, win, ref points);
                    break;
                case "B":
                    Points(zweite, rock, paper, scissors, lost, draw, win, ref points);
                    break;
                case "C":
                    Points(zweite, paper, scissors, rock, lost, draw, win, ref points);
                    break;
            }
        }
    }

    /* Erstes Beispiel
    public static void Points(string zweite, int rock, int paper, int scissors, int d, int w, int l, ref int points)
    {
        if(zweite == "X")
        {
            points += rock + d; 
        }
        else if(zweite == "Y")
        {
            points += paper + w;
        }
        else
        {
            points += scissors + l;
        }
        Console.WriteLine(points);
    }
    */

    // Zweites Beispiel
    public static void Points(string zweite, int rock, int paper, int scissors, int d, int w, int l, ref int points)
    {
        if (zweite == "X")
        {
            points += rock + d;
        }
        else if (zweite == "Y")
        {
            points += paper + w;
        }
        else
        {
            points += scissors + l;
        }
        Console.WriteLine(points);
    }


}