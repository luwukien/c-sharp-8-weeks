class Program
{
    public static void Main(string[] args)
    {
        //int numberOfStudents = GetNumberOfStudents();
        //List<double> scores = GetStudentScores(numberOfStudents);
        //double averageScore = CalculateAverageScore(scores);
        //double highestScore = FindHighestScore(scores);
        //double lowestScore = FindLowestScore(scores);
        //int passedCount = CountPassed(scores);
        //int failedCount = CountFailed(scores);

        //DisplayResults(averageScore, highestScore, lowestScore, passedCount, failedCount);

    }

    public static string ModifyString(string input)
    {
        string output = input.Trim().ToUpper();
        return output;
    }

    public static int CountCharacters(string input)
    {
        int characterCount = input.Length;
        return characterCount;
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        return reversedString;
    }

    public static bool IsPalindrome(string input)
    {
        string reversedString = ReverseString(input);
        return input.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
    }


    public static int GetNumberOfStudents()
    {
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        return numberOfStudents;
    }

    public static List<double> GetStudentScores(int numberOfStudents)
    {
        List<double> scores = new List<double>();
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter the score for student {i + 1}:");
            double score = Convert.ToDouble(Console.ReadLine());
            scores.Add(score);
        }
        return scores;
    }

    public static double CalculateAverageScore(List<double> scores)
    {
        double totalScore = 0;
        foreach (double score in scores)
        {
            totalScore += score;
        }
        return totalScore / scores.Count;
    }

    public static double FindHighestScore(List<double> scores)
    {
        double highestScore = scores[0];
        foreach (double score in scores)
        {
            if (score > highestScore)
            {
                highestScore = score;
            }
        }
        return highestScore;
    }

    public static double FindLowestScore(List<double> scores)
    {
        double lowestScore = scores[0];
        foreach (double score in scores)
        {
            if (score < lowestScore)
            {
                lowestScore = score;
            }
        }
        return lowestScore;
    }

    public static int CountPassed(List<double> scores) 
    { 
        int count = 0;
        foreach (double score in scores)
        {
            if (score > 5.0)
            {
                count++;
            }
        }
        return count;
    }

    public static int CountFailed(List<double> scores)
    {
        int count = 0;
        foreach (double score in scores)
        {
            if (score <= 5.0)
            {
                count++;
            }
        }
        return count;
    }

    public static void DisplayResults(double averageScore, double highestScore, double lowestScore, int passedCount, int failedCount)
    {
        Console.WriteLine($"Average Score: {averageScore}");
        Console.WriteLine($"Highest Score: {highestScore}");
        Console.WriteLine($"Lowest Score: {lowestScore}");
        Console.WriteLine($"Number of Students Passed: {passedCount}");
        Console.WriteLine($"Number of Students Failed: {failedCount}");
    }




}