namespace DesignPatternsDemo;

interface IFactory
{
    SprotsBall CreateProduct();
}

public class SprotsBall 
{
    public string? Name { get; set; }
    public string? Color { get; set; }
    public double? Size { get; set; }
}

public class BasketballMaker : IFactory
{
    public SprotsBall CreateProduct()
    {
        return new SprotsBall
        {
            Name = "Basketball",
            Color = "Yellow",
            Size = 7.5
        };
    }
}

public class FootballMaker : IFactory
{
    public SprotsBall CreateProduct()
    {
        return new SprotsBall
        {
            Name = "Football",
            Color = "White",
            Size = 5.5
        };
    }
}
