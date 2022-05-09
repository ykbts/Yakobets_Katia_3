using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._2
{
    class Taxopark
    {

        public static long Sort(List<Car> Cars)
        {
            Console.Write("Sorted cars: ");
            Cars.Sort();
            foreach (Car car in Cars)
            {
       
              Console.WriteLine(car);

            }
          
            return Cars.Count;
        }
        public static long Price(List<Car> Cars)
        {
            int sum = 0;
            foreach (Car car in Cars)
            {
                sum = sum + car.Price;
            }
           
            Console.WriteLine("Price: " + sum);
            return sum;
        }
        public static long Speed(List<Car> Cars,int min, int max)
        {
            Console.Write("Cars with such speed: ");
            foreach (Car car in Cars)
            {
                if (min <= car.MaxSpeed && car.MaxSpeed >= max)
                {
                    Console.Write(car.Manufacturer+ "; ");

                }
                
            }
            return Cars.Count ;
        }
    }
}
