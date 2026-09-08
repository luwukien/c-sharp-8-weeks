class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Calculator!");
        dynamic num1, num2;

        try
        {
            Console.Write("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }


        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine();
        double result = 0;
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
        Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
    }
}