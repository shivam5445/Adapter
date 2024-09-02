public class BicycleAdapter : Vehicle
{
    private readonly Bicycle _bicycle;

    public BicycleAdapter(Bicycle bicycle)
    {
        _bicycle = bicycle;
    }

    public void Drive()
    {
        _bicycle.Pedal();
    }
}
