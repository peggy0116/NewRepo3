﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a test sentence.";
            string[] words = sentence.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
