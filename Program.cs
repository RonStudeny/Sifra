using System;
using System.IO;

namespace Sifra
{
    class Program
    {
        static void Main()
        {

            


            /*
            string name, key;
            Sifrovani s = new Sifrovani();
            
            Console.WriteLine("Input file name (include file type)...");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input encryption key...");
            key = Console.ReadLine();
           
            s.StreamEncrypt("unecrypted.txt", "amogus");
             */
        }
    }

    public class Sifrovani
    {
        string klic, output;
        int[] sifra;
        public Sifrovani()
        {
            klic = "amogus";
        }
        public string Zasifrovat(string input)
        {
            sifra = new int[input.Length];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {            
                sifra[i] = (int)input[i] ^ (int)klic[index];
                if(i == klic.Length - 1) index = 0;
                else index++;
            }

            foreach (var item in sifra)
            {
                output += item;
            }
            return output;
        }

        public void StreamEncrypt(string fileName, string key)
        {
            StreamReader reader = new StreamReader(fileName);
            string input = reader.ReadToEnd();
            


            StreamWriter writer = new StreamWriter("unecrypted.cry");

            
        }
    }
}
