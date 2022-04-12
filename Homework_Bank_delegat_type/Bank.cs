using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class Bank
    {
        public int size;
        public Client[] clients;

        public Bank()
        {
            this.size = 0;
            clients = new Client[10];
        }

        public void Addclient(Client client)
        {
            clients[size] = client;
            this.size++;
        }

        public void Addclientcard(Client client)
        {
            Console.WriteLine(" Выберите валюту:\n 1-гривна,\n 2 - usd");
            int usd = int.Parse(System.Console.ReadLine());
            Card second = new Card(client.Surname, client.Name, client.Father_Name, usd);
            client.Addcard(second);
        }

        public void CardtoCard_Client(Client client)
        {
            Console.WriteLine(" Выберите карту с которой отправить перевод: ");

            for (int i = 0; i < client.size; i++)
            {
                Console.WriteLine($" {i}  - {client.cards[i].CardNumber.ToString()}");
            }

            int ch = int.Parse(System.Console.ReadLine());

            Console.WriteLine(" Выберите карту на которую отправить перевод: ");

            for (int i = 0; i < client.size; i++)
            {
                Console.WriteLine($" {i}  - {client.cards[i].CardNumber.ToString()}");
            }

            int Card2 = int.Parse(System.Console.ReadLine());

            Console.WriteLine(" Введите сумму для перевода: ");
            double sum = double.Parse(System.Console.ReadLine());

            client[ch].Pay(client.cards[Card2], sum);


        }
        public Card Find_card(string Client_card)
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < clients[i].size; j++)
                {
                    if (clients[i].cards[j].CardNumber.ToString() == Client_card)
                    {
                        return clients[i].cards[j];
                    }

                }
            }
            return new Card("Erorr", "Erorr", "Erorr", 1);
        }
        public void Bunkomat_to_Client()
        {
            Func<string, Card> operation = this.Find_card;

            Console.WriteLine(" Введите номер карты для перевода : ");

            string Client_card2 = System.Console.ReadLine();

            Console.WriteLine(" Введите сумму для перевода: ");
            double sum = double.Parse(System.Console.ReadLine());

            this.Pay(operation(Client_card2), sum);

        }
        public void Pay(Card card2, double sum)
        {
            if (card2.Usd == 2)
            {
                sum /= 29.90;

                card2.Cash += sum;

            }
            else
            {
                card2.Cash += sum;
            }

        }


        public void Client_to_Client(Client client1, Client client2)
        {
            Console.WriteLine(" Выберите карту с которой отправить перевод: ");

            for (int i = 0; i < client1.size; i++)
            {
                Console.WriteLine($" {i}  - {client1.cards[i].CardNumber.ToString()}");
            }

            int ch = int.Parse(System.Console.ReadLine());
            Console.WriteLine(" Выберите карту на которую отправить перевод: ");

            for (int i = 0; i < client2.size; i++)
            {
                Console.WriteLine($" {i}  - {client2.cards[i].CardNumber.ToString()}");
            }

            int Card2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine(" Введите сумму для перевода: ");
            double sum = double.Parse(System.Console.ReadLine());

            client1[ch].Pay(client2.cards[Card2], sum);

        }

        public void PrintAll()
        {
            for (int i = 0; i < this.size; i++)
            {
                clients[i].Print();
            }
        }
    }
}
