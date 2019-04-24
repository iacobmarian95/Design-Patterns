using Abstract_Factory.Assurance;

namespace Abstract_Factory.Abstract_Factory
{
    public class PhoneStandardAssurance : AssuredProduct
    {
        public IDevice Device
        {
            get
            {
                return new Phone("Apple", "Iphone X", 1000);
            }
        }

        public IAsssurance Assurance
        {
            get
            {
                return new StandardAssurance(12, "Assurandia");
            }
        }
    }
}
