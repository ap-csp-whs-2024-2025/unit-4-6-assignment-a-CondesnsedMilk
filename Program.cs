using System.Globalization;

namespace unit_4_6_assignment_a_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        var listC = new List<int>() { 1, 2, 3, 4 };
        var listB = new List<int>() {3, 2, 1, 0};
        var listA = new List<int>() {-3, -5, -5, -3};

        MinList(listB);
    }
    static void MinList(List<int> myPassedList)
    {

        int count = 0;
        int minNum = myPassedList.ElementAt(count);

        while (count < myPassedList.Count)
        {
            if (minNum > myPassedList.ElementAt(count))
            {
                minNum = myPassedList.ElementAt(count);
            }
            count++;
        }

        Console.WriteLine($"The minimum is {minNum}");
    }
}
