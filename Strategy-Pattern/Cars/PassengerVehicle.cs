using Strategy_Pattern.Car_Driving_Strategies;

namespace Strategy_Pattern.Cars
{
    public class PassengerVehicle : Vehicle
    {
        public PassengerVehicle() : base(new BasicDrivingStrategy())
        {
        }
    }
}
