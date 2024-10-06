namespace Strategy_Pattern.Car_Driving_Strategies
{
    internal class BasicDrivingStrategy: IDrivingStrategy
    {
        public void DriveType()
        {
            Console.WriteLine("This is basic driving strategy");
        }
    }
}
