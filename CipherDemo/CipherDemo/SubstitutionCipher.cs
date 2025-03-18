using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDemo
{
    internal class SubstitutionCipher
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string substitute = "opdefghiqrsxyzabcjklmntuvw";
        public SubstitutionCipher()
        {
            Console.WriteLine("Enter a string to encode.");

            Encode();
        }
        public void Encode()
        {
            string input = Console.ReadLine();
            string output = "";
            foreach (char letter in input) 
            {
                int index = alphabet.IndexOf(letter);
                // Next, find the location of the letter within "Substitute" at the Index location.
                output += substitute[index];
            }
            Console.WriteLine(output);
        }
    }
}
