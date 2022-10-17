Console.Write("Enter matrix height: ");
int height = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter matrix width: ");
int width = Convert.ToInt32(Console.ReadLine());

// phase 1
int[,] matrix = new int[height, width];
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write($"Enter [{i},{j}] value: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// phase 2
Dictionary<int, int> map = new Dictionary<int, int>();
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        int cell = matrix[i, j];
        if (map.ContainsKey(cell))
        {
            map[cell] += 1;
        }
        else
        {
            map[cell] = 1;
        }
    }
}

// phase 3
foreach (var item in map)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}