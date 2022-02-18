using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot
{
    internal class CarLot
    {
        //Properties
        public List<Car> cars = new List<Car>()
        {
            new Car("Tesla", "Cybertruck", 2024, 80000),
            new Car("Kia", "Forte", 2000, 30000),
            new Car("Ford", "Mustang", 1967, 60000),
            new UsedCar("Mercury", "Milan", 2008, 4000, 200000),
            new UsedCar("Little", "Tikes", 2006, 100, 1.3),
            new UsedCar("Cardbox", "Armored Car", 2022, 9000, 120000)
        };

        //Methods

        //adding
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        //displaying
        public void DisplayCars()
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].ToString()}");
            }
        }

        //removing
        public void RemoveCar(int index)
        {
            cars.RemoveAt(index);
        }
    }
}
