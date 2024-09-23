class Var
{
    public static void MyVar()
    {
        string helloworld = "Hello World!";

        Console.WriteLine(helloworld);
    }
    public static void DataTypes()
    {
        string firstName = "Daniel";
        string lastName = "Mendoza";
        firstName = "Sam";

        string myName = firstName + " " + lastName;
        int age = 16;
        float gpa = 10.2f;
        bool is_Student = true;
        double lenght = 2.6;
        decimal dollar = 101.98m;

        


        Console.WriteLine(myName);
        //Console.WritenLine(lastName)
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(is_Student);
        Console.WriteLine(lenght);
        Console.WriteLine(dollar);
    }
}