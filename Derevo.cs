using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_laba
{
    class Derevo
    {
        Gilka Gilka;
        Lust Lust;
        string name;


        public Derevo(string name)
        {
            this.name = name;

            this.Gilka = new Gilka();
            this.Lust = new Lust();
        }
        public void Metod()
        {
            Console.WriteLine("Введіть місяць");
            string month = Console.ReadLine();
            if ((month == "вересень") || (month == "жовтень"))
            {
                Lust.Zhovtie();
            }
            else if ((month == "березень") || (month == "квітень") || (month == "травень"))
            {
                Lust.Zacvistu();
            }
            else if (month == "листопад")
            {
                Lust.Opastu();
            }
            else if ((month == "грудень") || (month == "січень") || (month == "лютий"))
            {
                Gilka.Inii();

            }
            else Console.WriteLine("Дерево росте");
        }
        public bool Equals(Derevo obj)
        {
            if (obj == null)
                return false;
            return obj.name == this.name;
        }
        public override string ToString()
        {
            return this.name;
        }
        public override int GetHashCode()
        {
            if (name == "дуб")
                return 1;
            else return 0;
        }
    }
}
