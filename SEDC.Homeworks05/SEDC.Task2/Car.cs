namespace SEDC.Task2
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public int CalculateSpeed()
        {
            int res = Driver.Skill * Speed;

            return res;
        }
    }
}
