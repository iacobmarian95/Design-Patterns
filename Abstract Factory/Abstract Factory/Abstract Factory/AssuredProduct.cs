namespace Abstract_Factory
{
    public interface AssuredProduct
    {
        IDevice Device { get; }
        IAsssurance Assurance { get; }
    }
}
