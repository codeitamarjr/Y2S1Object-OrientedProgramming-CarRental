using System;
namespace Y2S1ObjectOrientedProgrammingCarRental.models
{
    public class CarRental
    {
        public int rentalID { get;set; }
        public string carModel { get; set; }
        public string carRegistration { get; set; }

        public CarRental(int _rentalID, string _carModel, string _carRegistration)
        {
            this.rentalID = _rentalID;
            this.carModel = _carModel;
            this.carRegistration = _carRegistration;
        }

        public CarRental()
        {

        }

    }
}
