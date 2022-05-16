LineComparison.Shape line = new LineComparison.Shape();
double length1 = line.Line(5, 8, 13, 7);
double length2 = line.Line(7, 5, 6, 2);
Console.WriteLine("Length of Line 1 is: " + length1);
Console.WriteLine("Length of Line 2 is: " + length2);

Console.WriteLine(length1.Equals(length2));