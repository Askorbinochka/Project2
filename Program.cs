using System;
using System.Collections.Generic;

interface IClient
{
    void GetMessage(string text);
}

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
    public List<Client> ClientsList = new List<Client>();
    public void AddClient(Client c)
    {
        ClientsList.Add(c);
    }

    public void SendMessage(string text)
    {
        Console.WriteLine("\n НОВА АКЦІЯ: " + text);
        foreach (Client c in ClientsList)
        {
            c.GetMessage(text);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Shop myShop = new Shop();

        Client client1 = new Client("Христина");
        Client client2 = new Client("Арсен");

        myShop.AddClient(client1);
        myShop.AddClient(client2);

        myShop.SendMessage("Знижка -50% на все!");

    }
}