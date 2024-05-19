using calculator_testing;

static void Main(string[] args)
{
    Calc calculator = new Calc();

    Console.WriteLine("Enter two numbers:");
    double num1 = GetUserInput();
    double num2 = GetUserInput();

    Console.WriteLine("Enter the operation (+, -, *, /):");
    char operation = GetOperation();

    try
    {
        double result;
        switch (operation)
        {
            case '+':
                result = calculator.Addition(num1, num2);
                break;
            case '-':
                result = calculator.Subtraction(num1, num2);
                break;
            case '*':
                result = calculator.Multiplication(num1, num2);
                break;
            case '/':
                result = calculator.Division(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

static double GetUserInput()
{
    double number;
    while (true)
    {
        Console.Write("Enter a number: ");
        if (double.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

static char GetOperation()
{
    char operation;
    while (true)
    {
        Console.Write("Enter an operation (+, -, *, /): ");
        if (char.TryParse(Console.ReadLine(), out operation) && (operation == '+' || operation == '-' || operation == '*' || operation == '/'))
        {
            return operation;
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
        }
    }
}


