using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robbans_blogg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> inlägg = new List<string>();
            bool minBool = true;
            while (minBool)
            {


                {



                    //meny till bloggen, användare får välja 
                    Console.WriteLine("\n\t VAL TILL BLOGGEN");
                    Console.WriteLine("\n\t[A] SKAPA ETT INLÄGG");
                    Console.WriteLine("\n\t[B] SKRIV UT ALLA INLÄGG");
                    Console.WriteLine("\n\t[C] SÖK INLÄGG");
                    Console.WriteLine("\n\t[D] AVSLUTA");
                    string val = Console.ReadLine();


                    if (val == "A" || val == "a")
                    {
                        Console.WriteLine("\n\tVAR VÄNLIG SKRIV IN ETT INLÄGG TILL DIN BLOGG");

                        // kod till att skapa ett innlägg, som sparas i en lista
                        string inläggText = Console.ReadLine();
                        inlägg.Add(inläggText);
                        Console.WriteLine("\n\tDIN BLOGG HAR SPARATS");
                        Console.ReadLine();
                    }

                    if (val == "D" || val == "d")
                    {
                        Console.WriteLine("\n\tHEJDÅ");
                        minBool = false;
                        break;
                    }


                    else if (val == "B" || val == "b")
                    {
                        Console.WriteLine("\n\tHÄR ÄR ALLA SPARADE BLOGGAR:");
                        if (inlägg.Count == 0) { Console.WriteLine("\n\tDET FINNS INGET SPARAT"); }
                        else
                        {
                            for (int i = 0; i < inlägg.Count; i++)
                            { Console.WriteLine($"\t[{i + 1}]{inlägg[i]}"); }
                        }
                        Console.ReadLine(); //kod till skriva ut alla inlägg(lista)  
                    }

                    else if (val == "C" || val == "c")
                    {
                        Console.WriteLine("\n\tSKRIV IN ETT SÖKORD");
                        string sökord = Console.ReadLine().ToLower();
                        bool hittad = false;

                        for (int i = 0; i < inlägg.Count; i++)
                        {

                            if (inlägg[i].ToLower().Contains(sökord))
                            {
                                Console.WriteLine($"\t[{i + 1}] {inlägg[i]}");
                                hittad = true;
                                // måste ändras till att söka på siffror istället för ord, 

                            }
                        }
                        //kod till att söka bland alla inlägg, stoppa alla inlägg i nummer (lista)
                    }













                }




            }
        }
    }
}
    

    