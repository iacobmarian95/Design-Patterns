using Abstract_Factory.DeviceServices;

namespace Abstract_Factory.Abstract_Factory
{
    public class PhoneLowCostAssurance : AssuredProduct
    {
        public IDevice Device
        {
            get
            {
                return new Phone("Apple", "Iphone 4s", 400);
            }
        }

        public IAsssurance Assurance
        {
            get
            {
                return new LowCostAssurance(6, "VeryLowCost");
            }
        }
    }
}
