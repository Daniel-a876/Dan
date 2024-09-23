class Dictionary1
{
    public static void Dict1(string[] args)
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Alicw", "123-345-6789");

        Console.WriteLine(phoneBook["Alice"]);
    }
}