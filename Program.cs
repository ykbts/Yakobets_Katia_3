using System;
using System.IO;
using System.Linq;




namespace _3_laba
{
    class Program
    {

        static void Main(string[] args)
        {

            Derevo derevo1 = new Derevo("дуб");
            derevo1.Metod();

            Derevo derevo2 = new Derevo("береза");
            Console.WriteLine(derevo1.Equals(derevo2));
            Console.WriteLine(derevo1.ToString());
            Console.WriteLine(derevo2.ToString());
            Console.WriteLine(derevo1.GetHashCode());
            Console.WriteLine(derevo2.GetHashCode());



        }
    }
}
   
   
       

    
