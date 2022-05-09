using System;
using System.IO;
using System.Linq;




namespace laba3._2
{
    class Taxi
    {

        static void Main(string[] args)
        {


            List<Car> Cars = new List<Car>() {
             new Car(manufacturer: CarBrand.TeslaModelX, price: 80000, year: 2019, maxSpeed: 250, electric: true, gas: false, fuel:false),
             new Car(manufacturer: CarBrand.LamborghiniUrus, price: 250000, year: 2020, maxSpeed: 305, electric: false, gas: false, fuel:true),
             new Car(manufacturer: CarBrand.BentleyBentayga, price: 230000, year: 2018, maxSpeed: 306, electric: false, gas: true, fuel: false),
             new Car(manufacturer: CarBrand.Porshe718Boxter, price: 65000, year: 2022, maxSpeed: 275, electric: false, gas: false, fuel: true),
          };

            Taxopark.Sort(Cars);
            Taxopark.Price(Cars);
            Taxopark.Speed(Cars, 60, 120);
            
        }

    }
   
}