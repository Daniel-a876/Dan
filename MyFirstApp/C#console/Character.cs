using System.Security.Cryptography.X509Certificates;

class Character
{
    public string name;
    public int health;
    public int strength;
    public static void Player()
    {
        Character player = new Character();
        player.name = "Daniel";
        player.health = 100;
        player.strength = 100;

        Console.WriteLine("Player; " + player.name + " has " + player.health + " health.");

        Character player1 = new Character();
        player1.name = "Tom";
        player1.health = 100;
        player1.strength = 100;
        Console.WriteLine(player1.name);


    }
}