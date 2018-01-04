using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwo = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwo);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");



            List<Dictionary<string, List<string>>> spacecrafts = new List<Dictionary<string, List<string>>>();
            string mess = "MESSENGER";
            List<string> messengerDestinations = new List<string>() { "Mercury", "Venus" };
            Dictionary<string, List<string>> MESSENGER = new Dictionary<string, List<string>>();
            MESSENGER.Add(mess, messengerDestinations);

            string voyager1 = "Voyager 1";
            List<string> voyager1Destinations = new List<string>{"Jupiter", "Saturn"};
            Dictionary<string, List<string>> voyager1Dict = new Dictionary<string, List<string>>();
            voyager1Dict.Add(voyager1, voyager1Destinations);

            string mar10 = "Mariner 10";
            List<string> mar10destinations = new List<string>{"Mercury", "Venus"};
            Dictionary<string, List<string>> mar10Dict = new Dictionary<string, List<string>>();
            mar10Dict.Add(mar10, mar10destinations);

            spacecrafts.Add(MESSENGER);
            spacecrafts.Add(voyager1Dict);
            spacecrafts.Add(mar10Dict);


            foreach (string s in planetList)
            {
                string stringToWrite = $"{s}:";
                foreach (Dictionary<string, List<string>> d in spacecrafts)
                {
                    foreach (KeyValuePair<string, List<string>> kvp in d)
                    {
                        if (kvp.Value.Contains(s))
                        {
                            stringToWrite += $" {kvp.Key},";
                        }
                    }
                }
                stringToWrite = stringToWrite.Substring(0, (stringToWrite.Length - 1));
                if (stringToWrite.Contains(": "))
                Console.WriteLine(stringToWrite);

            }
        }
    }
}


