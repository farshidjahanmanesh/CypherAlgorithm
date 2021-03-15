using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Algo a = new Algo();
            Console.WriteLine(a.Decode(a.Encode()));
            Console.ReadLine();
        }
    }

    class Algo
    {
       
        public string Encode()
        {
            Console.WriteLine("encode start-----------------------------------");
            Console.WriteLine("enter your key:");
            var key = Console.ReadLine();
            var keyAsc = 0;
            foreach (var item in key)
            {
                keyAsc += item;
            }
            Console.WriteLine("enter your plaintext :");
            var text = Console.ReadLine();
            int i = 0, j = 0;
            bool rev = false;
            var keyRev = string.Concat(key.Reverse());
            StringBuilder sb = new StringBuilder();
            foreach (var item in text)
            {
                if (rev == false)
                {
                    sb.Append((char)(item ^ key[i]));
                    i++;
                    if (i == key.Length)
                    {
                        rev = true;
                        i = 0;
                    }
                }
                else
                {
                    sb.Append((char)(item ^ keyRev[j]));
                    j++;
                    if (j == keyRev.Length)
                    {
                        rev = false;
                        j = 0;
                    }
                }
               
            }

            StringBuilder sb2 = new StringBuilder();
            int loopCounter = 0;
            while (loopCounter != keyAsc%2)
            {
                int counter = 1;
                foreach (var item in sb.ToString())
                {
                    sb2.Append((char)(item ^ (keyAsc * counter)));
                    counter++;
                }
                loopCounter++;
            }
            Console.WriteLine("encode end-----------------------------------");
            return sb2.ToString();
        }

        public string Decode(string text)
        {
            Console.WriteLine("decode start-----------------------------------");
            Console.WriteLine("enter your key:");
            var key = Console.ReadLine();
            var keyAsc = 0;
            foreach (var item in key)
            {
                keyAsc += item;
            }

            StringBuilder sb = new StringBuilder();
            int loopCounter = 0;
            while (loopCounter != keyAsc % 2)
            {
                int counter= 1;
                foreach (var item in text)
                {
                    sb.Append((char)(item ^ (keyAsc * counter)));
                    counter++;
                }
                loopCounter++;
            }


            int i =0, j = 0;
            bool rev = false;
            var teststring = sb.ToString();
            StringBuilder sb2 = new StringBuilder();
            var keyRev = string.Concat(key.Reverse());
            foreach (var item in teststring)
            {
                if (rev == false)
                {
                    sb2.Append((char)(item ^ key[i]));
                    i++;
                    if (i == key.Length)
                    {
                        rev = true;
                        i = 0;
                    }
                }
                else
                {
                    sb2.Append((char)(item ^ keyRev[j]));
                    j++;
                    if (j == keyRev.Length)
                    {
                        rev = false;
                        j = 0;
                    }
                }

            }
            Console.WriteLine("decode end-----------------------------------");
            return sb2.ToString();
        }
    }
}
