class CarFactory
{
    private int max_production { get; set; }

    public CarFactory(int max_production)
    {
        this.max_production = max_production;
    }

    public LimitedEditionCar ProduceLimitedEditionCar()
    {
        if (LimitedEditionCar.Counter < max_production)
        {
            return new LimitedEditionCar();
        }

        return null;
    }
}