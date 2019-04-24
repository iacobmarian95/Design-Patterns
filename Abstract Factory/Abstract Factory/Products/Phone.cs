namespace Abstract_Factory
{
    public class Phone : IDevice
    {
        public Phone(string brand, string deviceName, float devicePrice)
        {
            Brand = brand;
            DeviceName = deviceName;
            DevicePrice = devicePrice;
        }

        public string DeviceName { get; set; }
        public float DevicePrice { get; set; }
        public string Brand { get;set; }
    }
}
