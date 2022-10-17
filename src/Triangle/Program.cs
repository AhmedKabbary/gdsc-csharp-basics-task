PrintTriangleType(1, 2, 3);
PrintTriangleType(12, 16, 20);
PrintTriangleType(7, 7, 7);
PrintTriangleType(5, 6, 2);

void PrintTriangleType(double a, double b, double c)
{
    List<double> arr = new List<double> { a, b, c };
    arr.Sort();

    // check if the 3 sides can form a triangle
    if (!((arr[0] < arr[1] + arr[2]) && (arr[1] < arr[0] + arr[2]) && (arr[2] < arr[0] + arr[1])))
    {
        Console.WriteLine("a, b and c can not form a triangle");
        return;
    }

    double s1 = Math.Pow(arr[2], 2);
    double s2 = Math.Pow(arr[1], 2);
    double s3 = Math.Pow(arr[0], 2);

    if (s1 == s2 + s3)
        Console.WriteLine("Right angle triangle");

    if (s1 < s2 + s3)
        Console.WriteLine("Acute angle triangle");

    if (s1 > s2 + s3)
        Console.WriteLine("Obtuse angle triangle");

}