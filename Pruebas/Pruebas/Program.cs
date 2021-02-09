using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "<[We]> both arrived at the <[garage]> this morning";
            string searchTerm1 = "<[";
            string searchTerm2 = "]>";
            List<string> palabras = new List<string>();
            string[] words = example.Split(' ');

            foreach(var word in words)
            { 
                if (word.Contains(searchTerm1) && word.Contains(searchTerm2)) {
                    string result = word.Replace(searchTerm1, "")
                    .Replace(searchTerm2, "");
                    palabras.Add(result);
                }
            }

            foreach(var palabra in palabras)
            {
                System.Console.WriteLine(palabra);
            }
        }
    }
}
