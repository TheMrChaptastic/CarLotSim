using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSim
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(int y, string make, string model)
        {
            Year = y;
            Make = make;
            Model = model;
            CarLot.numberOfCars++;
        }

        public int Year { get; set; } = 2012;
        public string Make { get; set; } = "Hyundai";
        public string Model { get; set; } = "Elantra";

    }
}
