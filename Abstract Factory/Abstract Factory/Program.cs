using Abstract_Factory.Abstract_Factory;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuredProduct factory = new PhoneStandardAssurance();
            IDevice phone = factory.Device;
            IAsssurance asssuranceP = factory.Assurance;

            System.Console.WriteLine($"Device details:\n-Brand - {phone.Brand}\n-Device name - {phone.DeviceName}\n-Device price - {phone.DevicePrice}");
            System.Console.WriteLine("\n-------------------------------------------\n");
            System.Console.WriteLine($"Assurance details:\n-Period - {asssuranceP.AssurancePeriod}\n-Provider - {asssuranceP.ServiceProvider}");

            System.Console.WriteLine("\n#######################################\n");

            factory = new TabletStandardAssurance();
            IDevice tablet = factory.Device;
            IAsssurance asssuranceT = factory.Assurance;

            System.Console.WriteLine($"Device details:\n-Brand - {tablet.Brand}\n-Device name - {tablet.DeviceName}\n-Device price - {tablet.DevicePrice}");
            System.Console.WriteLine("\n-------------------------------------------\n");
            System.Console.WriteLine($"Assurance details:\n-Period - {asssuranceT.AssurancePeriod}\n-Provider - {asssuranceT.ServiceProvider}");
        }
    }
}
