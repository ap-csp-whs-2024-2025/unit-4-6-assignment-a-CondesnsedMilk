namespace unit_4_6_assignment_a_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        QuadForm(5, 9, 14);
    }
    static void QuadForm(double a, double b, double c)
    {
        double x1 = -b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c);
        double x2 = -b - Math.Sqrt(Math.Pow(b,2) - 4 * a * c);
        
        if (!double.IsNaN(x1) || double.IsPositiveInfinity(x1) || double.IsNegativeInfinity(x1))
        {
            Console.WriteLine($"Your answers are {x1/2} and {x2/2}");
        }
        else
        {
            Console.WriteLine("There are no x intercepts");
        }
            
    }
}
