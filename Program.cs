using System;
using System.Collections.Generic;
using System.Text;

interface IClient
{
    void GetMessage(string text);
}

interface IShop
{
    void AddClient(IClient c);
    void RemoveClient(IClient c);
    void SendMessage(string text);
}

class Client : IClient
{
    public string Name;

    public Client(string name)
    {
        Name = name;
    }

    public void GetMessage(string text)
    {
        Console.WriteLine(Name + " отримав(ла) SMS: " + text);
    }
}

class Shop : IShop
{
    public List<IClient> ClientsList = new List<IClient>();

    public void AddClient(IClient c)
    {
        ClientsList.Add(c);
    }

    public void RemoveClient(IClient c)
    {
        ClientsList.Remove(c);
    }

    public void SendMessage(string text)
    {
        Console.WriteLine("\n--- НОВА АКЦІЯ: " + text + " ---");

        foreach (IClient c in ClientsList)
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
        /*Shop myShop = new Shop();

        Client client1 = new Client("Христина");
        Client client2 = new Client("Арсен");

        myShop.AddClient(client1);
        myShop.AddClient(client2);

        myShop.SendMessage("Знижка -50% на все!");*/

    }
}