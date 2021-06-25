﻿using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Linux Torvalds");
            Names.Add("Doanld Knuth");
            Names.Add("Grace Hopper");
            Names.Add("Donald Knuth");
            Names.Add("Jean Bartik");
            Names.TrimExcess();
            Names.RemoveAt(3);
            Names.Remove("Donald Knuth");
            //For some reason this remove funtion is not removing Donald?

            for (int i = 0; i < Names.Count; ++i)
            {
                Console.WriteLine(Names[i]);
            }

            Console.WriteLine("Count of list: " + Names.Count.ToString());
            Console.WriteLine("Capacity of list: " + Names.Capacity.ToString());

            DisplayNames(Names);
            



        }

        private static void DisplayNames(List<string> Names)
        {
            for (int i = 0; i < Names.Count; ++i)
            {
                Console.WriteLine(i + 1+"; " + Names[i]);
            }

            Console.WriteLine();
        }
    }
}
