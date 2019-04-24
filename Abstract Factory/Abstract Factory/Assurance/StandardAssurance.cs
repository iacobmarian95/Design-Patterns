namespace Abstract_Factory.Assurance
{
    public class StandardAssurance : IAsssurance
    {
        public StandardAssurance(int assurancePeriod, string serviceProvider)
        {
            AssurancePeriod = assurancePeriod;
            ServiceProvider = serviceProvider;
        }

        public int AssurancePeriod { get; set; }
        public string ServiceProvider { get; set; }
    }
}
