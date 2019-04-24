namespace Abstract_Factory.DeviceServices
{
    public class LowCostAssurance : IAsssurance
    {
        public LowCostAssurance(int assurancePeriod, string serviceProvider)
        {
            AssurancePeriod = assurancePeriod;
            ServiceProvider = serviceProvider;
        }

        public int AssurancePeriod { get; set; }
        public string ServiceProvider { get; set; }
    }
}
