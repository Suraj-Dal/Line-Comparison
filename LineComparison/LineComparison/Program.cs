LineComparison.Shape line = new LineComparison.Shape();
double length1 = line.Line(5, 8, 13, 7);
double length2 = line.Line(2, 5, 6, 9);
Console.WriteLine("Length of Line 1 is: " + length1);
Console.WriteLine("Length of Line 2 is: " + length2);

if (length1.Equals(length2) == true)
    Console.WriteLine("Length of both lines are same.");
else
    Console.WriteLine("Length of Lines are not same.");

Console.WriteLine(length1.CompareTo(length2));
if (length1.CompareTo(length2) > 0)
    Console.WriteLine("Line 1 is greater than line 2.");
else if (length1.CompareTo(length2) < 0)
    Console.WriteLine("Line 1 is smaller than line 2.");
else
    Console.WriteLine("Lines are equal.");
