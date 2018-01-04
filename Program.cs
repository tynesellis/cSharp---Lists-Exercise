using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwo = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(lastTwo);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            
            planetList.Remove("Pluto");


            Dictionary<int, string> Mariner10 = new Dictionary<int, string>();
            Mariner10.Add(0, "Mercury");
            Mariner10.Add(1, "Venus");

            Dictionary<int, string> Mariner2 = new Dictionary<int, string>();
            Mariner2.Add(0, "Venus");



            List<Dictionary<int, string>> spacecrafts = new List<Dictionary<int, string>>();

            spacecrafts.Add(Mariner10);
            spacecrafts.Add(Mariner2);


            foreach (string s in planetList) {
                foreach(Dictionary<int, string> d in spacecrafts) {
                    foreach(KeyValuePair<int, string> kvp in d) {
                        if (kvp.Value.Contains(s)) {
                            Console.WriteLine($"{s}: {kvp.Value} ");

                            //Pausing here
                        }
                    }

                    }
                }
            }
        }
    }

