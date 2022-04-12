using System;

namespace Homework_Bank
{
    class Program
    {


        static void Main(string[] args)
        {

            Client Afonya = new Client(" Afonya ", " Afonasiy ", "Afonovich", 1);
            Client Izya = new Client(" Izya ", " Izya ", "Izevich", 2);

            Bank Alfa = new Bank();

            Func<string, Card> operation = Alfa.Find_card;

            Action bunkomat = Alfa.Bunkomat_to_Client;

            static void Function(Client client, Action<Client> action) => action(client);

            Action<Client, Client> another = Alfa.Client_to_Client;
            int chose;
            do
            {
                Console.WriteLine(" Меню: \n 0 - Добавить клиента \n 1 - Добавить карту клиенту \n 2 - Перевод между своими картами  \n 3 - Пополнение карты с банкомата\n 4 - Перевод на карту другого клиента \n 5 - Получить данные клиента по карте\n 6 - Получить данные всех карт банка \n 7 - Выход ");
                Console.Write(" Ваш выбор: ");

                chose = int.Parse(System.Console.ReadLine());


                switch (chose)
                {
                    case 0:
                        {
                            Function(Afonya, Alfa.Addclient);
                            Function(Izya, Alfa.Addclient);
                            break;
                        }

                    case 1:
                        {
                            Function(Afonya, Alfa.Addclientcard);
                            break;
                        }

                    case 2:
                        {
                            Function(Afonya, Alfa.CardtoCard_Client);
                            break;
                        }
                    case 3:
                        {
                            bunkomat();
                            break;
                        }

                    case 4:
                        {
                            another(Afonya, Izya);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(" Введите номер карты : ");
                            string Card_Number = System.Console.ReadLine();
                            Card found = operation(Card_Number);
                            found.Printl();
                            break;
                        }

                    case 6:
                        {
                            Alfa.PrintAll();
                            break;
                        }

                }
            }
            while (chose != 7);
            Console.WriteLine(" До свидания! ");

        }
    }
}