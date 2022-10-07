namespace task2;

public class Car
{
    public string Name { get; set; }
    public uint ProductionYear { get; set; }
    public uint MaxSpeed { get; set; }

    public Car(string name, uint productionYear, uint maxSpeed)
    {
        Name = name;
        ProductionYear = productionYear;
        MaxSpeed = maxSpeed;
    }
    
    public static int NameSotring(string n1, string n2)
    {
        int length = Math.Min(n1.Length, n2.Length);
        for (int i = 0; i < length; ++i)
        {
            if (n1[i] != n2[i])
                return n1[i] - n2[i];
        }

        if (n1.Length == n2.Length)
            return 0;
        else if (n1.Length > n2.Length)
            return -1;
        else return 1;
    }

    public void Show()
    {
        Console.WriteLine($"{Name}, {ProductionYear}, {MaxSpeed}");
    }
}