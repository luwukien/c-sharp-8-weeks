class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=========== User Profile Application ===========");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Height (in cm): ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Weight (in kg): ");
        int weight = int.Parse(Console.ReadLine());

        double bmi = CalculateBMI(height, weight);
        String category = BMICategory(bmi);
        Console.WriteLine("BMI: " + bmi.ToString("F2"));
        Console.WriteLine("BMI Category: " + category);
    }

    public static double CalculateBMI(int height, int weight)
    {
        // BMI = weight (kg) / (height (m))^2
        double heightInMeters = height / 100.0;
        return weight / (heightInMeters * heightInMeters);
    }

    public static String BMICategory(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            return "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            return "Overweight";
        }
        else
        {
            return "Obesity";
        }
    }
}