using System.Globalization;

class If
{
    public static void IfElse(int number)
    {

        //int number = -5;

        if (number > 0)
        {
            Console.WriteLine("The number is positive. ");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is a negative. ");
        }
        else
        {
            Console.WriteLine("The number is zero." );
        }
    }
    public static void Health(int number)
    {

        if (number > 75)
        {
            Console.WriteLine("The player is good. ");
        }
        else if (number < 75)
        {
             Console.WriteLine("The player is in danger. ");
        }
        else
        {
            Console.WriteLine("Game Over");
        }

    }
}