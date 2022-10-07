using System.Runtime.Serialization;
using task2;
using task3;

CarCatalog catalog = new CarCatalog(new Car("Porsche", 2021, 300),
                                             new Car("Man", 2017, 140),
                                             new Car("Aston Martin", 2016, 280),
                                             new Car("Kamaz", 2015, 140));

foreach (var car in catalog.Straigth())
{
    car.Show();
}     
Console.WriteLine();

foreach (var car in catalog.Reverse())
{
    car.Show();
}    
Console.WriteLine();

foreach (var car in catalog.SubsetBySpeed(250, 350))
{
    car.Show();
}    
Console.WriteLine();

foreach (var car in catalog.SubsetByYear(2015, 2017))
{
    car.Show();
}                                               