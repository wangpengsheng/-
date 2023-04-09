using DesignPatternsDemo;

class Program
{
    static void Main()
    {
        NewBall();
    }

    //工厂模式测试
    private static void NewBall()
    {
        IFactory f1 = new BasketballMaker();
        IFactory f2 = new FootballMaker();

        var bb1 = f1.CreateProduct();
        var bb2 = f2.CreateProduct();

        System.Console.WriteLine(bb1.Name);
        System.Console.WriteLine(bb2.Name);
    }
}