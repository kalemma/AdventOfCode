using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("C:\\repos\\AdventOfCode\\DayThree\\Input-DayThree.txt");
        int summe = 0;

        /* Erster Teil
        for (int i = 0; i < data.Length; i++)
        {
            string index = data[i];


            summe += GetValue(index);


        }
        */

        for (int i = 0; i < data.Length; i += 3)
        {
            string index1 = data[i];
            string index2 = data[i+1];
            string index3 = data[i+2];


            summe += GetLetter(index1, index2, index3);


        }
        Console.WriteLine($"## --> {summe} ##");

    }

    // Erster Teil
    public static int GetValue(string index)
    {
        int seperator = index.Length / 2;
        int test = 0;
        bool gefunden = false;

        for (int i = 0; i < seperator; i++)
        {
            for (int j = seperator; j < index.Length; j++)
            {
                if (index[i] == index[j])
                {
                    gefunden = true;
                    Console.WriteLine(index[j]);
                    test += Konvertiere(index[j]);
                    break;

                }

            }
            if (gefunden == true)
            {
                break;
            }

        }
        Console.WriteLine(test);
        return test;


    }


    // Zweiter Teil
    public static int GetLetter(string index1, string index2, string index3)
    {
        for(int i = 0; i < index1.Length; i++)
        {
            for(int j = 0; j < index2.Length; j++)
            {
                for(int k = 0; k < index3.Length;k++)
                {
                    if ((index1[i] == index2[j]) && index2[j] == index3[k])
                    {
                        return Konvertiere(index2[j]);
                    }
                }
            }
        }
        return 0;
    }


    public static int Konvertiere(char a)
    {
        if (!char.IsUpper(a))
            return ((int)a) - 96;
        else
            return ((int)a) - 38;



    }






}