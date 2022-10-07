using System.Numerics;
using task1;

MyMatrix m1 = new MyMatrix(2,2, 0, 5);
MyMatrix m2 = new MyMatrix(2,3, 0, 7);

m1.Show();
Console.WriteLine();
m2.Show();
Console.WriteLine();

MyMatrix m = new MyMatrix(1,1);
m = m1*m2;
m.Show();
Console.WriteLine();

m += m2;
m.Show();
Console.WriteLine();

m *= 2;
m.Show();
