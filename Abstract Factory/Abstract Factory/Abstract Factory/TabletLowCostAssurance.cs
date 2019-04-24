using Abstract_Factory.DeviceServices;

namespace Abstract_Factory.Abstract_Factory
{
    public class TabletLowCostAssurance: AssuredProduct
    {
        public IDevice Device
        {
            get
            {
                return new Tablet("Samgsun", 200, "first model");
            }
        }

        public IAsssurance Assurance
        {
            get
            {
                return new LowCostAssurance(6, "LowLow");
            }
        }
    }
}
