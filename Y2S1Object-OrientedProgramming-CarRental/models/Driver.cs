using System;
using System.Collections.Generic;
namespace Y2S1ObjectOrientedProgrammingCarRental.models
{
    public class Driver
    {
        public List<CarRental> ListOfCarRentals = new List<CarRental>()
        {

            new CarRental(1, "Ford", "a1234"),
            new CarRental(2, "Opel", "b4557"),
            new CarRental(3, "Nissan", "c891")
        };

        public void displayCarRental()
        {
            foreach (CarRental car in ListOfCarRentals)
            {
                Console.WriteLine($"{car.rentalID}, {car.carModel}, {car.carRegistration}");

            }
        }
    }
}
