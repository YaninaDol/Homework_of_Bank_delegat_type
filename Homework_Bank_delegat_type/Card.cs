using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class Card
    {
        public StringBuilder CardNumber = new StringBuilder();
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }
        public int Usd { get; set; }

        public double Cash { get; set; }

        public Card()
        {

        }

        public Card(string surname, string name, string father_Name, int usd)
        {
            Random random = new Random();
            int n1 = random.Next(1000, 9999);
            int n2 = random.Next(1000, 9999);
            int n3 = random.Next(1000, 9999);
            int n4 = random.Next(1000, 9999);


            CardNumber.Append(n1);
            CardNumber.Append(n2);
            CardNumber.Append(n3);
            CardNumber.Append(n4);


            Surname = surname;
            Name = name;
            Father_Name = father_Name;
            this.Usd = usd;
            Cash = 0;


        }

        public void Pay(Card card2, double sum)
        {
            if (this.Usd == card2.Usd)
            {
                if (sum <= this.Cash)
                {
                    this.Cash -= sum;
                    card2.Cash += sum;

                }
                else Console.WriteLine(" Not enough money! ");
            }
            else if (card2.Usd == 2)
            {
                sum /= 29.90d;
                if (sum <= this.Cash)
                {
                    this.Cash -= sum;
                    card2.Cash += sum;

                }
                else Console.WriteLine(" Not enough money! ");

            }

        }

        public void Printl()
        {
            Console.WriteLine($"{this.Surname} {this.Name} {this.Father_Name} {this.CardNumber} {this.Cash}");
        }
    }
}
