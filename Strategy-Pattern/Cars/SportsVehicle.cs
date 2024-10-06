using Strategy_Pattern.Car_Driving_Strategies;

namespace Strategy_Pattern.Cars
{
    public class SportsVehicle: Vehicle
    {
        public SportsVehicle(): base(new SupercarDrivingStrategy())
        {
        }
    }
}
