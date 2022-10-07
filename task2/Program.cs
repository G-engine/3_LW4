using task2;

Car[] array = new Car[] {new Car("Porsche", 2021, 300),
                         new Car("Man", 2017, 140),
                         new Car("Aston Martin", 2016, 280),
                         new Car("Kamaz", 2015, 140)};

CarComparer carComparer = new CarComparer();                         
Array.Sort(array, carComparer);
foreach (var car in array)
    car.Show();
    
Console.WriteLine();

carComparer.Type = 1;
Array.Sort(array, carComparer);
foreach (var car in array)
    car.Show();    
    
Console.WriteLine();

carComparer.Type = 2;
Array.Sort(array, carComparer);
foreach (var car in array)
    car.Show();    