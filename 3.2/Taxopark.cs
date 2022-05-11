using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._2
{
    class Taxopark
    {
        public string Name { get; set; }
        public List<Car> ListCars { get; set; }
        public Taxopark(string Name)
        {
            this.Name = Name;
            ListCars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            ListCars.Add(car);
        }
        public void Write()
        {
           foreach(Car car in ListCars)
            {
                Console.WriteLine(car.ToString());
            }
        }
      

        public void Price()
        {
            int sum = 0;
            foreach (Car car in ListCars)
            {
                sum = sum + car.Price;
            }
           
            Console.WriteLine("Price: " + sum);
           
        }
        public void Speed(int min, int max)
        {
            Console.Write("Cars with such speed: ");
            foreach (Car car in ListCars)
            {
                if (min <= car.MaxSpeed && car.MaxSpeed >= max)
                {
                    Console.Write(car.Manufacturer+ "; ");

                }
                
            }
           
        }
    }
}
