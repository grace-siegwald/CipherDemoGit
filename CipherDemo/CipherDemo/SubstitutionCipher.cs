using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherDemo
{
    internal class SubstitutionCipher
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        string substitute = "opdefghiqrsxyzabcjklmntuvw";
        public SubstitutionCipher()
        {
            Console.WriteLine("Enter a string to encode.");

            Encode();
        }
        public void Encode()
        {
            string input = Console.ReadLine();

            foreach (char letter in input) 
            {
                Console.Write(substitute.IndexOf(alphabet, alphabet.IndexOf(letter)));

                alphabet.IndexOf(letter);
            }
        }

    }
}
