Console.WriteLine("WELCOME TO MY CALCULATOR");

while (true)
{
    Console.WriteLine("------------------------");

    char op;
    double a, b, result = 0;
    
    try
    {
        Console.Write("Enter the first number: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation: ");
        op = Convert.ToChar(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    switch (op)
    {
        case '+':
            result = a + b;
            break;

        case '-':
            result = a - b;
            break;

        case '*':
            result = a * b;
            break;

        case '/':
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                continue;
            }
            result = a / b;
            break;
            
        default:
            Console.WriteLine("Invalid operation");
            continue;
    }

    Console.WriteLine($"Result = {result}");
}