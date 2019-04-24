using Abstract_Factory.Assurance;

namespace Abstract_Factory.Abstract_Factory
{
    public class TabletStandardAssurance: AssuredProduct
    {
        public IDevice Device
        {
            get
            {
                return new Tablet("Samgsung", 1000, "galaxy");
            }
        }

        public IAsssurance Assurance
        {
            get
            {
                return new StandardAssurance(24, "HighClass");
            }
        }
    }
}
