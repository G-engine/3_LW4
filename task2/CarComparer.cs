namespace task2;

public class CarComparer: IComparer<Car>
{
    public int Type;

    public CarComparer(int type = 0)
    {
        Type = type;
    }
    
    public int Compare(Car? c1, Car? c2)
    {
        if(c1 is null || c2 is null) 
            throw new ArgumentException("Null-parameters");
        switch (Type)
        {
            case 0: //name
                return String.Compare(c1.Name, c2.Name);
            case 1: //year
                return (int)(c1.ProductionYear - c2.ProductionYear);
            case 2: //speed
                return (int)(c1.MaxSpeed - c2.MaxSpeed);
        }
        return String.Compare(c1.Name, c2.Name);
    }
}