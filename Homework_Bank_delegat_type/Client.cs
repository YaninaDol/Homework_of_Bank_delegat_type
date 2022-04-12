using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class Client
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }

        public int size;
        public Card[] cards;

        public Client()
        {

        }

        public Client(string surname, string name, string father_Name, int usd)
        {
            Surname = surname;
            Name = name;
            Father_Name = father_Name;
            this.size = 0;
            this.cards = new Card[4];

            cards[this.size] = new Card(surname, name, father_Name, usd);
            this.size++;

        }
        public Card this[int ind]
        {
            get { return cards[ind]; }
            // private set {  }
        }
        public void Addcard(Card card)
        {
            cards[this.size] = card;
            this.size++;
        }

        public void Print()
        {
            for (int i = 0; i < this.size; i++)
            {
                cards[i].Printl();
            }
        }

    }
}
