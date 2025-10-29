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
            {
                while (true)
                {
                    // första meny till bloggen
                    Console.Clear();
                    Console.Write("\n\t------- VÄLJ VAD DU VILL GÖRA-------");
                    Console.WriteLine("\n\t[1] MENY TILL BLOGGEN");
                    Console.WriteLine("\n\t[2] STÄNG NER PROGRAMMET");
                    string meny = Console.ReadLine();
                    if (meny == "2" || meny == "d" || meny == "D")
                    {
                        Console.Write("HEJ DÅ");
                        //stänger ner programmet, break; 
                        break;
                    }

                    if (meny == "1") { }
                    //lista som allt sparas i, arraylist, första del av algoritm(sökalgoritm, linjär sökning)
                    List<string> inlägg = new List<string>();
                    bool minBool = true;





                    while (minBool)
                    {
                        // Rensar skärmen så att det inte bli oklart med mycket text.
                        Console.Clear();
                        //meny till bloggen

                        Console.Write("\n\t--------VÄLKOMMEN TILL BLOGGEN--------");

                        Console.WriteLine("\n\tVAL TILL BLOGGEN");

                        Console.WriteLine("\n\t[A] SKAPA ETT INLÄGG");

                        Console.WriteLine("\n\t[B] SKRIV UT ALLA INLÄGG");

                        Console.WriteLine("\n\t[C] SÖK INLÄGG");
                        Console.WriteLine("\n\t[D] GÅ TILLBAKA TILL FÖRSTA MENY");

                        string val = Console.ReadLine().ToLower();


                        switch (val)
                        {
                            case "a":
                                Console.WriteLine("\n\tVAR VÄNLIG SKRIV IN ETT INLÄGG TILL DIN BLOGG");
                                string inläggText = Console.ReadLine();
                                //spara inlägget och lägger till det i listan
                                inlägg.Add(inläggText);
                                Console.WriteLine("\n\tDIN BLOGG HAR SPARATS");
                                Console.ReadLine();


                                break;

                            case "b":
                                Console.WriteLine("\n\tHÄR ÄR ALLA SPARADE BLOGGAR:");
                                //om det inte finns något sparat (count==0), kommer det upp ett meddelande
                                if (inlägg.Count == 0)
                                {
                                    Console.WriteLine("\n\tDET FINNS INGET SPARAT");
                                }
                                else
                                {
                                    for (int i = 0; i < inlägg.Count; i++)
                                    {
                                        Console.WriteLine($"\t[{i + 1}] {inlägg[i]}");
                                    }
                                }
                                Console.ReadLine();
                                break;

                            case "c":
                                Console.WriteLine("\n\tSKRIV IN ETT SÖKORD");
                                string sökord = Console.ReadLine().ToLower();
                                bool hittad = false;

                                for (int i = 0; i < inlägg.Count; i++)
                                {
                                    // ger möjlighet att kunna söka efter ett inlägg, som sparats i array, ToLower för att det ska kunna söka oavsett stor eller liten bokstav 
                                    if (inlägg[i].ToLower().IndexOf(sökord) >= 0)
                                    {
                                        Console.WriteLine($"\t[{i + 1}] {inlägg[i]}");
                                        hittad = true;
                                    }
                                }

                                if (!hittad)
                                {
                                    Console.WriteLine("\n\tINGET INLÄGG MATCHAR DITT SÖKORD");
                                }

                                Console.ReadLine();
                                break;

                            case "d":
                                //går tillbaka till första meny, där man kan stänga ner programmet, minBool = flase

                                Console.WriteLine("\n\tVÄLKOMMEN TILLBAKA/STÄNG NER PROGRAMMET");
                                minBool = false;

                                break;


                            //om man skulle göra ett val som inte presenterats i menyn så kommer ett meddelande upp i stället för att programmet ska kracha 
                            default:
                                Console.WriteLine("\n\tOGILTIGT VAL, VÄLJ NÅGOT ANNAT");
                                Console.ReadLine();
                                break;
                        }
                    }
                }
            }

        }












    }




}





            
        
    

    