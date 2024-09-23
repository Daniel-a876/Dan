
using System;
using System.Collections.Generic;

class Lists
{
    public static void Lists1(string[] args)
    {
        List<String> fruit = new List<string> {" Apple", "Banana", "Orange",};

        fruit.Add("Grapes");
        fruit.Remove("Banana");
        fruit.IndexOf("Apple");

       // Console.WriteLine(fruit.Count);
        foreach(string fruits in fruit)
        {
            Console.WriteLine(fruits);
        }
    }
}







