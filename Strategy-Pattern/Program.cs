using Strategy_Pattern.Cars;

namespace strategyPattern
{
    public class MyApp
    {
        public static void Main(string[] args)
        {
            var sportsCar = new SportsVehicle();
            sportsCar.drive();

            var passengerCar = new PassengerVehicle();
            passengerCar.drive();

            Console.ReadLine();
        }
    }
}