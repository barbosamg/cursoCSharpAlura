﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpressaoRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}-[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
                            
            string texto = "Meu número é: 98127-6791";

            bool DeuMatch = Regex.IsMatch(texto, padrao);

            if (DeuMatch)
            {
                Match match = Regex.Match(texto, padrao);
                //Console.WriteLine(match); OU:
                Console.WriteLine(match.Value);
            }

            Console.ReadLine();
        }
    }
}
