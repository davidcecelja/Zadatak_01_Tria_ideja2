using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_01_Tria_ideja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] niz = new string[3][]
                {
                    new string[] {"ad3j40f", "ss4", "66jjjfg7a"},
                    new string[] {"d6d6", "", "-2jk" },
                    new string[] {"-3hj6", "ssf6h3", "i4"}
                };
            Console.WriteLine(suma(niz));
        }
        static int suma(string[][] lista)
        {
            int suma = 0;
            string[] flat = lista.SelectMany(a => a).ToArray();
            foreach (string s in flat)
            {
                char[] characters = s.ToCharArray();
                string snumber = "";
                int index = 0;
                bool add = false;
                foreach (char c in characters)
                {
                    if (c.Equals("-"))
                    {
                        snumber += c;
                    }
                    if (Char.IsDigit(c))
                    {
                        snumber += c;
                    }
                    else
                    {
                        add = true;
                    }
                    if (index == characters.Length)
                    {
                        add = true;
                    }
                    if (add)
                    {
                        try
                        {
                            int tempNumber = 0;

                            tempNumber = Int32.Parse(snumber);
                            suma += tempNumber;
                            snumber = "";
                            add = false;
                        }
                        catch (Exception)
                        {
                            
                        }

                    }
                    index++;
                }
            }
            return suma;
        }
    }
}
