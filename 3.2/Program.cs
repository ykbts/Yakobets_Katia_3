using System;
using System.IO;
using System.Linq;




namespace laba3._2
{
    class Taxi
    {

        static void Main(string[] args)
        {

            Taxopark t=new Taxopark("1");
            t.AddCar(new Car(manufacturer: CarBrand.TeslaModelX, price: 80000, year: 2019, maxSpeed: 250, electric: true, gas: false, fuel: false));
            t.AddCar(new Car(manufacturer: CarBrand.LamborghiniUrus, price: 250000, year: 2020, maxSpeed: 305, electric: false, gas: false, fuel: true));
            t.AddCar(new Car(manufacturer: CarBrand.BentleyBentayga, price: 230000, year: 2018, maxSpeed: 306, electric: false, gas: true, fuel: false));
            t.AddCar(new Car(manufacturer: CarBrand.Porshe718Boxter, price: 65000, year: 2022, maxSpeed: 275, electric: false, gas: false, fuel: true));

            t.Write();
            t.ListCars.Sort();
            Console.WriteLine();
            t.Write();


           t.Price();
           t.Speed( 60, 120);
              
        }

    }
   
}