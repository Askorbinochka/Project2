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

class Shop
{
    public void AddClient(Client c)
    {

    }

    public void SendMessage(string text)
    {
        Console.WriteLine("\n НОВА АКЦІЯ: " + text);
    }
}

class Program
{
    static void Main()
    {

    }
}