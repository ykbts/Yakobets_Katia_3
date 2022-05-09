using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._2
{
	class Car : IComparable<Car>
	{

		public CarBrand Manufacturer { set; get; }

		public int Price { set; get; }
		public int Year { set; get; }

		public int MaxSpeed { set; get; }
		public bool Electric { set; get; }
		public bool Gas { set; get; }
		public bool Fuel { set; get; }



		public Car(CarBrand manufacturer, int price, int year, int maxSpeed, bool electric, bool gas, bool fuel)
		{

			Manufacturer = manufacturer;
			Price = price;
			Year = year;
			MaxSpeed = maxSpeed;

			Electric = electric;
			Gas = gas;
			Fuel = fuel;

		}
		public override string ToString()
		{
			String carInfo = $"Manufacturer: {Manufacturer},Price: {Price}, Year: {Year}, MaxSpeed: {MaxSpeed},Gas: {Gas},Elecric: {Electric},Fuel: {Fuel}";


			return carInfo;
		}
		public int CompareTo(Car obj)
		{
			if (this.Electric == true && this.Gas == false && this.Fuel == false)
			{
				return 0;
			}
			if (this.Electric == false && this.Gas == true && this.Fuel == false)
			{				
				return 1;			
			}			
			else 
			{				
				return -1;				
			}

		}
	}
}
