using System.Collections;
using task2;

namespace task3;

public class CarCatalog
{
    private Car[] catalog;

    public CarCatalog(params Car[] cars)
    {
        catalog = new Car[cars.Length];
        for (int i = 0; i < cars.Length; i++)
            catalog[i] = cars[i];
    }

    public IEnumerable<Car> Straigth()
    {
        for (int i = 0; i < catalog.Length; i++)
        {
            yield return catalog[i];
        }
    }

    public IEnumerable<Car> Reverse()
    {
        for (int i = catalog.Length - 1; i >= 0; i--)
        {
            yield return catalog[i];
        }
    }

    public IEnumerable<Car> SubsetByYear(uint minYear, uint maxYear)
    {
        for (int i = 0; i < catalog.Length; i++)
        {
            if(catalog[i].ProductionYear >= minYear && catalog[i].ProductionYear <= maxYear) 
                yield return catalog[i];
        }
    }
    
    public IEnumerable<Car> SubsetBySpeed(uint minSpeed, uint maxSpeed)
    {
        for (int i = 0; i < catalog.Length; i++)
        {
            if(catalog[i].MaxSpeed >= minSpeed && catalog[i].MaxSpeed <= maxSpeed) 
                yield return catalog[i];
        }
    }

}