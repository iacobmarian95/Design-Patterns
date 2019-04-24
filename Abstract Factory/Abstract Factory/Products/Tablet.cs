namespace Abstract_Factory
{
    public class Tablet : IDevice
    {
        public Tablet(string deviceName, float devicePrice, string brand)
        {
            DeviceName = deviceName;
            DevicePrice = devicePrice;
            Brand = brand;
        }
        public string DeviceName { get; set; }
        public float DevicePrice { get; set; }
        public string Brand { get; set; }
    }
}
