using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string[] werte = File.ReadAllLines("M:\\privat\\Advent of Code\\DayOne\\Input-DayOne.txt");


        int[] array = new int[werte.Length];
        int test = 0;

        for (int i = 0; i < werte.Length; i++)
        {

            if (werte[i] != string.Empty)
            {
                test += int.Parse(werte[i]);
            }
            else
            {
                array[i] = test;
                Console.WriteLine(array[i]);
                test = 0;

                continue;
            }



        }
        Console.WriteLine();
        Console.WriteLine();

        int merken = 0;
        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > merken)
            {
                merken = array[i];
            }
            
        }
        Console.WriteLine(merken);


        // Part 2
        for(int position = 0; position < array.Length; position++)
        {
            int momentaneZahl = array[position];                     
            int i = position;

            while (i > 0 && array[i - 1] > momentaneZahl)            
            {                                                       
                array[i] = array[i - 1];                              
                i--;                                                
            }
            array[i] = momentaneZahl;
        }

        long erg = (array[array.Length - 1]) + (array[array.Length - 2]) + (array[array.Length - 3]);
        Console.WriteLine(erg);

    }
}