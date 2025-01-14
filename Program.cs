namespace unit_4_6_assignment_a_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first number!");
        float input1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("What's your second number!");
        float input2 = Convert.ToSingle(Console.ReadLine());

        Compare(input1, input2);
    }

    static void Compare(float input1, float input2)
    {
        if (input1 > input2)
        {
            Console.WriteLine($"{input1} is greater than {input2}");
        }
        else if (input1 < input2)
        {
            Console.WriteLine($"{input1} is greater than {input2}");
        }
        else
        {
            Console.WriteLine("They are equal!");
        }
    }
}
