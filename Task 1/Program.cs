//Variant 11
namespace Task_1;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть машину.");
        Vehicle vehicle = EnterCar();
        vehicle.Show();
        Console.WriteLine("Введіть поїзд.");
        IShowable train = EnterTrain();
        train.Show();
        Console.WriteLine("Введіть експрес.");
        IShowable express = EnterExpress();
        express.Show();
    }

    public static Car EnterCar()
    {
        string mark;
        int fuelMax;
        string name;
        int speed;
        Console.WriteLine("Введіть ім'я: "); name = Console.ReadLine();
        Console.WriteLine("Введіть швидкість: "); speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть бренд: "); mark = Console.ReadLine();
        Console.WriteLine("Введіть максимальну кількість палива: "); fuelMax = Convert.ToInt32(Console.ReadLine());
        return new Car(name, speed, mark, fuelMax);
    }

    public static Train EnterTrain()
    {
        int carriageCount;
        string name;
        int speed;
        Console.WriteLine("Введіть ім'я: "); name = Console.ReadLine();
        Console.WriteLine("Введіть швидкість: "); speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть кількість: "); carriageCount = Convert.ToInt32(Console.ReadLine());
        return new Train(name, speed, carriageCount);
    }

    public static Express EnterExpress()
    {
        string benefits;
        Console.WriteLine("Введіть переваги: "); benefits = Console.ReadLine();
        Train train = EnterTrain();
        return new Express(train, benefits);
    }
}