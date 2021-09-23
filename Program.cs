using System;
using System.IO;

namespace Sifra
{
    class Program
    {
        static void Main()
        {
            
            string name, key;

            
            Console.WriteLine("Input file name (include file type)...");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input encryption key...");
            key = Console.ReadLine();
            Sifrovani s = new Sifrovani(key);
            s.StreamEncrypt("unecrypted.txt", "amogus");
             
        }
    }

    public class Sifrovani
    {
        string klic, output;
        int[] sifra;

        public Sifrovani(string input)
        {
            klic = input;
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
            StreamWriter writer = new StreamWriter("unecrypted.cry");
            
            writer.Write(Zasifrovat(reader.ReadToEnd()));
        }
    }
}
