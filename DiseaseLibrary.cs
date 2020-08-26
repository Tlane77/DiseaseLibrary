// "using" statements give us access to external libraries
// Specifically for our DiseaseLibrary class...
//   "System" gives us access to "DateTime"
//   "System.Collections.Generic" gives us access to "Dictionary" and "List"
using System;
using System.Collections.Generic;

// A "class" should be declared inside a "namespace"
// The same namespace may e used in more than one file
// Each class in this program is in the "Library" namespace
namespace Library
{

    // To declare a class use the "public" and "class" keywords followed by a name for the class
    //  NOTE: it is possible to create "private" classes, but they are less common.
    // Inside the "body" of the class we declare methods and properties
    // A class becomes a new "type" in our application.
    //  For example the class below gives us the power to create a variable of type, "DiseaseLibrary"
    // Classes are "instantiated" to form "objects" using the "new" keywords
    //  The class is the blueprint that describes the properties and methods the object will have
    public class DiseaseLibrary
    {
        // "Properties" in a class describe the data that can be held inside the object created from the class
        // Properties are like variables. They are "names" that can refer to values.

        // Here are a few "public" "properities".
        // The "{ get; set; }" after the name signifies that this is a property
        // When you declare a property you must specify it's "type"
        public string Name { get; set; }
        public string Symptoms { get; set; }

        // Here are a couple of "private" properties
        // They can only be accessed within the body of the class

        // A dictionary is a collection of "keys" and "values" (a.k.a KeyValuePairs)
        private Dictionary<string, Disease> Inventory { get; set; }
        private List<Vitamin> History { get; set; }

        // A "constructor" is a special method that is run when a class is instantiated
        //  Meaning when some other code says "new DiseaseLibrary()" the DiseaseLibrary constructor is executed
        public DiseaseLibrary()
        {
            // Here we create "instances" of a dictionary and a list and assign those "values"
            //  to the Inventory and VitaminHistory properties
            Inventory = new Dictionary<string, Disease>();
            History = new List<Vitamin>();
        }

        // A public "method" can be called from outside the class and can access either public or private properties and methods
        // This method accepts a "parameter" of type "Bike" and adds it to the private Inventory dictionary
        public void AddDisease(Disease aDisease)
        {
            Inventory.Add(aDisease.Name, aDisease);
        }

        // Display all the bikes in our inventory
        public void ListDisease()
        {
            // Iterate over the keys and values that are stored in the Inventory dictionary
            foreach (KeyValuePair<string, Disease> item in Inventory)
            {
                // Each "KeyValuePair" has a "Key" property and a "Value" property
                // Here we use the Value property to access a Bike object
                Console.WriteLine($"{item.Value.Name}: ${item.Value.History}");
            }
        }

        // get a vitamin with a given "name"
        // The vitmain's name is passed in as a parameter
        public void GetVitamin(string name)
        {
            // Use the square bracket notation to get the bike from the dictionary
            Disease aDisease = Inventory[name];

            // We want to record the vitamin def associated with a disease, so we create new "Vitamin" object and set it's properties
            Vitamin aVitamin = new Vitamin();
            aVitamin.VitaminName = aVitamin.Name;
            aVitamin.VitaminHistory = aDisease.History;
            aVitamin.DiseaseName = aDisease.Name;

            // "Record" the vitamin, by adding it to our VitaninHistory list
            VitaminHistory.Add(aVitamin);

            // We've sold the bike so it's no longer in our inventory
            Inventory.Add(name);
        }

        // Print a simple report that displays all sales information
        public void PrintSalesReport()
        {
            foreach (Vitamin aVitamin in VitaminHistory)
            {
                Console.WriteLine($"{aVitamin.VitaminName} {aVitamin.DiseaseName}, {aVitamin.VitaminHistory}");
            }
        }
    }
}