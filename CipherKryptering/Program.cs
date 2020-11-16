using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherKryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereEncryption ve = new VigenereEncryption();
            
            Console.WriteLine("Your message:");
            string input = Console.ReadLine();
            ve.EncryptMessage(input);
            Console.WriteLine("Your key of choice:");
            string key = Console.ReadLine();
            Console.WriteLine(ve.vigenereChars.GetValue(1, 2));
            Console.ReadLine();
        }
    }
}
