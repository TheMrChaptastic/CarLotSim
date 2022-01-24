
using System;

namespace CarLotSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Cars in lot: {CarLot.numberOfCars}");
            var car = new Car();
            Console.WriteLine($"Cars in lot: {CarLot.numberOfCars}");
            var theirCar = new Car() { Year = 1997, Make = "Ford", Model = "F-150"};
            Console.WriteLine($"Cars in lot: {CarLot.numberOfCars}");
            var newCar = new Car(2010, "Nissan", "Santra");
            Console.WriteLine($"Cars in lot: {CarLot.numberOfCars}");
        }
    }
}
