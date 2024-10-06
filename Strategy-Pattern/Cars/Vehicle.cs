using Strategy_Pattern.Car_Driving_Strategies;

namespace Strategy_Pattern.Cars
{
    public class Vehicle
    {
        IDrivingStrategy _drivingStrategy;
        public Vehicle(IDrivingStrategy drivingStrategy)
        {
            _drivingStrategy = drivingStrategy;
        }

        public void drive()
        {
            _drivingStrategy.DriveType();
        }
    }
}
