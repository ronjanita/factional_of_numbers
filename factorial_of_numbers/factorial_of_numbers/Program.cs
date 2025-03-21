class Programm
{
    static void Main()
    {
        Console.WriteLine("enter number:");
        int input = Convert.ToInt32(Console.ReadLine());
        int result=1;
        for (int i = 0; i <= input; i++)
        {
            result *= i;
        }
        Console.WriteLine($"resultat: {result}");
    }
}