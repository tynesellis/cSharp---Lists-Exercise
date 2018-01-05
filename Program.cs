using System.Collections.Generic;
using System;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of planet names
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //add some more planets
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //new list of the names of the last two full-size planets
            List<string> lastTwo = new List<string>() { "Uranus", "Neptune" };

            //ad the 'lastTwo' list to 'planetList'
            planetList.AddRange(lastTwo);
            //add two more full-sized planets...
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            //..and one fun-sized planet
            planetList.Add("Pluto");

            //create a list of the rocky planets, which are the first four strings in 'planetList'
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            //at the instruction of the !azon boss, get rid of Pluto
            planetList.Remove("Pluto");

            //create a list of dictionaries
            //each dictionary will hold the name of a spacecraft as the key and a list of the planets it has visited as value
            List<Dictionary<string, List<string>>> spacecrafts = new List<Dictionary<string, List<string>>>();

            //create three dictionaries...
            string mess = "MESSENGER";
            List<string> messengerDestinations = new List<string>() { "Mercury", "Venus" };
            Dictionary<string, List<string>> MESSENGER = new Dictionary<string, List<string>>();
            MESSENGER.Add(mess, messengerDestinations);

            string voyager1 = "Voyager 1";
            List<string> voyager1Destinations = new List<string> { "Jupiter", "Saturn" };
            Dictionary<string, List<string>> voyager1Dict = new Dictionary<string, List<string>>();
            voyager1Dict.Add(voyager1, voyager1Destinations);

            string mar10 = "Mariner 10";
            List<string> mar10destinations = new List<string> { "Mercury", "Venus" };
            Dictionary<string, List<string>> mar10Dict = new Dictionary<string, List<string>>();
            mar10Dict.Add(mar10, mar10destinations);

            //...and add those dictionaries to 'spacecrafts'
            spacecrafts.Add(MESSENGER);
            spacecrafts.Add(voyager1Dict);
            spacecrafts.Add(mar10Dict);

            //for each planet in 'planetList'
            foreach (string s in planetList)
            {
                //initialize a string that will be written to the console.
                string stringToWrite = $"{s}:";

                //for each dictionary in spacecrafts...
                foreach (Dictionary<string, List<string>> d in spacecrafts)
                {
                    //for each key value pair in that dictionary
                    foreach (KeyValuePair<string, List<string>> kvp in d)
                    {
                        //if the key value pair contains the list of the current planet in 'planetList'...
                        if (kvp.Value.Contains(s))
                        {
                            //add a space, the name of the space craft in the key, and a comma to the string that 
                            //will be written to the console
                            stringToWrite += $" {kvp.Key},";
                        }
                    }
                }
                //take the extra comma off of the end of the string
                stringToWrite = stringToWrite.Substring(0, (stringToWrite.Length - 1));
                //if the planet didn't have any spacecraft visited, the ':' will not have a space after
                //so only write to the console if the planet had visitors
                if (stringToWrite.Contains(": "))
                    Console.WriteLine(stringToWrite);

            }
        }
    }
}


