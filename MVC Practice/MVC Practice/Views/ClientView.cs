using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Models;

namespace Views
{
    public static class ClientView
    {
        public static void showClient(Client client)
        {
            Console.Write($"|ID: {client.Id}|");
            Console.Write($" |Name: {client.Name}|");
            Console.Write($" |Email: {client.Email}|");
            Console.Write($" |Phone: {client.Phone}|");
            Console.Write($" |Adress: {client.Address}|");
        }
        public static Client LoadClient()
        {
            Console.Write("ID Of the client: ");
            string Id = Console.ReadLine();
            Console.Write("Name Of the client: ");
            string name = Console.ReadLine();
            Console.Write("Email Of the client: ");
            string Email = Console.ReadLine();
            Console.Write("Phone Of the client: ");
            string Phone = Console.ReadLine();
            Console.Write("Address Of the client: ");
            string Address = Console.ReadLine();

            Client temp = new Client(int.Parse(Id), name, Email, Phone, Address);
            return temp;
        }

    }
}
