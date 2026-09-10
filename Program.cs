using System;
using System.Collections.Generic;

class Client
{
    public string Name { get; set; }

    public Client(string name)
    {
        Name = name;
    }

    public void GetMessage(string text)
    {
        Console.WriteLine(Name + " отримав(ла) SMS: " + text);
    }
}

class Program
{
    static void Main()
    {

    }
}